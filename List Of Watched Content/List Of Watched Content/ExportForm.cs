using System;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing;

namespace List_Of_Watched_Content
{
    public partial class ExportForm : Form
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

        string Random16 = RandomStringGeneratorClass.RandomString(16);

        public ExportForm()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 3, 3));
        }

        private void ExportForm_Load(object sender, EventArgs e)
        {

        }

        private void PanelCloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PanelMinButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            DraggableAreaClass.ReleaseCapture();
            DraggableAreaClass.SendMessage(this.Handle, DraggableAreaClass.WM_NCLBUTTONDOWN, DraggableAreaClass.HT_CAPTION, 0);
        }

        private void ExportCSVCheckBox_Click(object sender, EventArgs e)
        {
            ExportTXTCheckBox.Checked = false;
        }

        private void ExportTXTCheckBox_Click(object sender, EventArgs e)
        {
            ExportCSVCheckBox.Checked = false;
        }

        public void Exporter(string FileType, string TerminatedBy)
        {
            DataTable Exportdt = new DataTable();
            string ExportSQLCommand = ($@"
                SELECT
	                'id', 'Name', 'Category', 'Show_Type', 'Rating', 'Review', 'Year', 'Time_Added', 'Time_Updated'
                UNION ALL
                SELECT
	                id, Name, Category, Show_Type, Rating, Review, Year, Time_Added, Time_Updated
                FROM
	                info
                INTO OUTFILE 'C:\\Users\\sbond\\Desktop\\Watch-List-Exports\\outputs\\output{Random16}.{FileType}'
                FIELDS ENCLOSED BY '""'
                TERMINATED BY '{TerminatedBy}'
                ESCAPED BY '""'
                LINES TERMINATED BY '\r\n'
                    ");
            DAL.ExecCommand(ExportSQLCommand);
        }

        private void ExportExportButton_Click(object sender, EventArgs e)
        {
            if (ExportCSVCheckBox.Checked == true)
            {
                Exporter("csv", ";");
                Process.Start("https://cd.sbond.ml/downloader.php?FileName=output" + Random16 + ".csv");
            }

            if (ExportTXTCheckBox.Checked == true)
            {
                Exporter("txt", ",");
                Process.Start("https://cd.sbond.ml/downloader.php?FileName=output" + Random16 + ".txt");
            }

            if (OpenDownloadsCheckBox.Checked == true)
            {
                Process.Start("shell:downloads");
            }
            this.Close();
        }
    }
}
