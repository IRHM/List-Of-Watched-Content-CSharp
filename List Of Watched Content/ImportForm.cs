using System;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;

namespace List_Of_Watched_Content
{
    public partial class ImportForm : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        string SelectedFileExt;
        string SelectedFileDir;
        string FileNameOnServer;
        string RandomString;

        public ImportForm()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 3, 3));
        }

        private void ImportForm_Load(object sender, EventArgs e)
        {

        }

        private void PanelCloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PanelMinButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            DraggableAreaClass.ReleaseCapture();
            DraggableAreaClass.SendMessage(this.Handle, DraggableAreaClass.WM_NCLBUTTONDOWN, DraggableAreaClass.HT_CAPTION, 0);
        }

        private void ImportSelectFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog SelectFile = new OpenFileDialog();

            SelectFile.Filter = "Image|*.csv;*.txt;|All files (*.*)|*.*";
            SelectFile.FilterIndex = 1;
            SelectFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments).ToString();
            SelectFile.RestoreDirectory = true;

            if (SelectFile.ShowDialog() == DialogResult.OK)
            {
                SelectedFileDir = SelectFile.FileName;
                SelectedFileExt = Path.GetExtension(SelectedFileDir);

                if (SelectedFileExt == ".csv" || SelectedFileExt == ".txt")
                {
                    FileToImportTextBox.Text = SelectedFileDir;
                }
                else
                {
                    MessageBox.Show("You can only select valid CSV or TXT files!");
                }
            }
        }

        private void ImportImportButton_Click(object sender, EventArgs e)
        {
            RandomString = RandomStringGeneratorClass.RandomString(16);

            if (File.Exists(FileToImportTextBox.Text)) // Directory.Exists is a thing as well!
            {
                WebClient Client = new WebClient();
                Client.Headers.Add("Content-Type", "binary/octet-stream");

                byte[] result = Client.UploadFile("https://cd.sbond.ml/importer.php?RandomString=" + RandomString, "POST", FileToImportTextBox.Text);
                string s = System.Text.Encoding.UTF8.GetString(result, 0, result.Length);

                FileNameOnServer = SendRequest("https://cd.sbond.ml/importer.php?RandomString=" + RandomString); // Get response from php script

                if (SelectedFileExt == ".csv")
                {
                    SQLExecuter(";");
                }
                else if (SelectedFileExt == ".txt")
                {
                    SQLExecuter(",");
                }

                Home Home = new Home();
                Home.Refresher();

                Close();
            }
            else
            {
                MessageBox.Show("The file doesn't exist!");
            }
        }

        private string SendRequest(string url)
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    return client.DownloadString(new Uri(url)); // Download response from php script
                }
            }
            catch (WebException ex)
            {
                MessageBox.Show(ex.Message, "Something broke..", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // catch errors and show them if they occur
                return null;
            }
        }

        private void SQLExecuter(string TerminatedBy)
        {
            DataTable Exportdt = new DataTable();
            string ExportSQLCommand = ($@"
                    LOAD DATA INFILE 'C:\\Users\\sbond\\Desktop\\Watch-List-Exports\\imports\\{FileNameOnServer}' 
                    INTO TABLE info
                    FIELDS TERMINATED BY '{TerminatedBy}' 
                    ENCLOSED BY '""'
                    LINES TERMINATED BY '\r\n'
                    IGNORE 1 ROWS;
                        ");
            DAL.ExecCommand(ExportSQLCommand);
        }
    }
}
