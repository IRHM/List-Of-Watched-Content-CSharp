using System;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using System.Net.Http;
using Nancy.Json;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Drawing;

namespace List_Of_Watched_Content
{
    public partial class Home : Form
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

        string NameOfShow;
        string CategoryOfShow;
        string TypeOfShow;
        string Ratings;
        string UpdatedRatings;
        string Review;
        string Year;
        string SelectedItemHomeListView;
        public static string PassNameOfShow;
        public static string PassReviewText;

        public Home()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 3, 3));
        }

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            DraggableAreaClass.ReleaseCapture();
            DraggableAreaClass.SendMessage(this.Handle, DraggableAreaClass.WM_NCLBUTTONDOWN, DraggableAreaClass.HT_CAPTION, 0);
        }

        public Boolean PresenceCheck(string inputString)
        {
            if (String.IsNullOrWhiteSpace(inputString))
            {
                return false;
            }

            return true;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            HomeReviewTextBox.Height = 375;
            HomeShowListView.Height = 441;
            HomeShowListView.Location = new Point (12, 33);
            
            PopDropdowns();
            DisplayShows("");
        }

        private void PopDropdowns()
        {
            CategoryDropdown.SelectedIndex = 0;
            ContentTypeDropdown.SelectedIndex = 0;
            RatingsDropdown.SelectedIndex = 0;
        }

        private void HomeAddButton_Click(object sender, EventArgs e)
        {
            if (HomeTextbox.Text == "" || HomeTextbox.Text == "Movie or TV Shows Name..." || 
                CategoryDropdown.Text == "-- Category" || ContentTypeDropdown.Text == "-- Type")
            {
                MessageBox.Show("No Show Name, Category or Type of show was input...");
            }
            else
            {
                if (HomeReviewTextBox.Text == "" || HomeReviewTextBox.Text == "Review or Just Your General Thoughts...")
                {
                    HomeReviewTextBox.Text = "No Review/Thoughts Given.";
                }
                switch (RatingsDropdown.SelectedIndex)
                {
                    case 0:
                        UpdatedRatings = "No Ratings Given.";
                        break;
                    case 1:
                        UpdatedRatings = "1/5";
                        break;
                    case 2:
                        UpdatedRatings = "2/5";
                        break;
                    case 3:
                        UpdatedRatings = "3/5";
                        break;
                    case 4:
                        UpdatedRatings = "4/5";
                        break;
                    case 5:
                        UpdatedRatings = "5/5";
                        break;
                    default:
                        UpdatedRatings = "No Ratings Given";
                        break;
                }

                NameOfShow = HomeTextbox.Text;
                CategoryOfShow = CategoryDropdown.Text;
                TypeOfShow = ContentTypeDropdown.Text;
                Ratings = UpdatedRatings;
                Review = HomeReviewTextBox.Text;
                Year = HomeYearTextBox.Text;

                if (PresenceCheck(NameOfShow) || PresenceCheck(CategoryOfShow) || PresenceCheck(TypeOfShow))
                {
                    DataTable dtt = new DataTable();
                    string SQLCommandd = ($"INSERT INTO info (Name, Category, Show_Type, Rating,  Review, Year) " +
                        $"VALUES ('{NameOfShow}', '{CategoryOfShow}', '{TypeOfShow}', '{Ratings} ', '{Review}', '{Year}')");

                    dtt = DAL.ExecCommand(SQLCommandd);
                    PopDropdowns();
                    DisplayShows("");
                    HomeReviewTextBox.Text = "Review or Just Your General Thoughts...";
                }
                else
                {
                    MessageBox.Show("One of the values are empty.");
                }
            }
        }

        private void HomeTextbox_Leave(object sender, EventArgs e)
        {
            ActiveForm.AcceptButton = null; // remove "return" button behavior
        }

        private void HomeTextbox_Enter(object sender, EventArgs e)
        {
            ActiveForm.AcceptButton = HomeAddButton; // ADD will be 'clicked' when user presses return
            if (HomeTextbox.Text == "Movie or TV Shows Name...")
            {
                HomeTextbox.Text = "";
                HomeTextbox.ForeColor = Color.White;
            }
        }

        private void HomeReviewTextBox_Enter(object sender, EventArgs e)
        {
            if (HomeReviewTextBox.Text == "Review or Just Your General Thoughts...")
            {
                HomeReviewTextBox.Text = "";
                HomeReviewTextBox.ForeColor = Color.White;
            }
        }

        private void HomeYearTextBox_Enter(object sender, EventArgs e)
        {
            if (HomeYearTextBox.Text == "Year")
            {
                HomeYearTextBox.Text = "";
                HomeYearTextBox.ForeColor = Color.White;
            }
        }

        public void Refresher()
        {
            InfoNameOfShow.Hide();
            InfoRating.Hide();
            InfoCategory.Hide();
            InfoTypeOfShow.Hide();
            HomeLessButton.Hide();
            HomeTextbox.Show();
            RatingsDropdown.Show();
            CategoryDropdown.Show();
            ContentTypeDropdown.Show();
            HomeReviewTextBox.Show();
            HomeYearTextBox.Show();
            HomeAddButton.Show();
            HomeAdvancedButton.Hide();
            InfoLabel_All.Hide();
            InfoPicture_Poster.Hide();
            SettingsExportListLabel.Hide();
            SettingsImportShowsLinkLabel.Hide();
            SettingsDeleteAllLinkLabel.Hide();

            HomeTextbox.Text = "Movie or TV Shows Name...";
            HomeTextbox.ForeColor = Color.Gray;
            HomeReviewTextBox.Text = "Review or Just Your General Thoughts...";
            HomeReviewTextBox.ReadOnly = false;
            HomeReviewTextBox.ForeColor = Color.Gray;
            HomeYearTextBox.Text = "Year";
            HomeYearTextBox.ForeColor = Color.Gray;

            HomeReviewTextBox.Height = 375;
            PopDropdowns();
            DisplayShows("");
        }

        public void HomeRefreshListButton_Click(object sender, EventArgs e)
        {
            Refresher();
        }

        private void DisplayShows(string type)
        {
            HomeShowListView.Clear();
            //HomeShowListbox.GridLines = true;
            HomeShowListView.Scrollable = true;
            HomeShowListView.View = View.Details;
            HomeShowListView.Columns.Add("Name", 270, HorizontalAlignment.Left);
            HomeShowListView.Columns.Add("Category", 100, HorizontalAlignment.Left);
            HomeShowListView.Columns.Add("Type", 93, HorizontalAlignment.Left);

            DataTable dt = new DataTable();
            string SQLCommand = ("SELECT * FROM info " + type);
            dt = DAL.ExecCommand(SQLCommand);

            foreach (DataRow Item in dt.Rows)
            {
                ListViewItem CurrentItem = new ListViewItem();
                CurrentItem.SubItems.Add(Item[0].ToString());
                CurrentItem.SubItems.Add(Item[1].ToString());
                CurrentItem.SubItems.Add(Item[2].ToString());

                HomeShowListView.Items.Add(new ListViewItem(new string[]
                {
                    // Replace %27 (accepted by search) by Apostrophe so it is readable
                    Item[1].ToString().Replace("%27", "'"), Item[2].ToString(), Item[3].ToString()
                }));
            }
        }

        private void HomeSearchShowsButton_Click(object sender, EventArgs e)
        {
            if (HomeSearchShowsTextBox.Visible == false)
            {
                HomeShowListView.Height = 403;
                HomeShowListView.Location = new Point(12, 71);
                HomeSearchShowsTextBox.Show();
            }
            else
            {
                HomeShowListView.Height = 441;
                HomeShowListView.Location = new Point(12, 33);
                HomeSearchShowsTextBox.Hide();
                HomeSearchShowsTextBox.Text = "Search Your Watch List...";
                Refresher();
            }
        }

        private void HomeSearchShowsTextBox_TextChanged(object sender, EventArgs e)
        {
            if (HomeSearchShowsTextBox.Text == "Search Your Watch List..." || HomeSearchShowsTextBox.Text == "")
            {
                DisplayShows("");
            }
            else
            {
                string Query = HomeSearchShowsTextBox.Text;
                DisplayShows($"WHERE Name LIKE '%{Query}%'");
            }
        }

        private void HomeSearchShowsTextBox_Enter(object sender, EventArgs e)
        {
            if (HomeSearchShowsTextBox.Text == "Search Your Watch List...")
            {
                HomeSearchShowsTextBox.Text = "";
            }
        }

        private void HomeMovieCheckBox_Click(object sender, EventArgs e)
        {
            HomeTVCheckBox.Checked = false;
            if (HomeMovieCheckBox.Checked)
            {
                DisplayShows("WHERE Show_Type = 'Movie'");
            }
            else
            {
                DisplayShows("");
            }
        }

        private void HomeTVCheckBox_Click(object sender, EventArgs e)
        {
            HomeMovieCheckBox.Checked = false;
            if (HomeTVCheckBox.Checked)
            {
                DisplayShows("WHERE Show_Type = 'TV Show'");
            }
            else
            {
                DisplayShows("");
            }
        }

        public void HomeShowListbox_Click(object sender, EventArgs e)
        {
            SelectedItemHomeListView = HomeShowListView.SelectedItems[0].Text.Replace("'", "%27"); // Put %27 back in
        }

        private void GetInfo(string ShowInfo, string LabelName)
        {
            DataTable dt = new DataTable();
            string SQLCommand = ($"SELECT * FROM info WHERE NAME = ('{InfoNameOfShow.Text.Replace("'", "%27")}')");
            dt = DAL.ExecCommand(SQLCommand);
            string ShowCategory = dt.Rows[0][ShowInfo].ToString();
            Label CurrentLabel = Controls.Find(LabelName, true).OfType<Label>().SingleOrDefault();
            CurrentLabel.Text = ShowCategory;
        }

        private async void HomeMoreButton_ClickAsync(object sender, EventArgs e)
        {
            if(HomeShowListView.SelectedItems.Count > 0)
            {
                Refresher();
                HomeTextbox.Hide();
                RatingsDropdown.Hide();
                CategoryDropdown.Hide();
                ContentTypeDropdown.Hide();
                HomeAddButton.Hide();
                HomeYearTextBox.Hide();
                SettingsExportListLabel.Hide();
                InfoNameOfShow.Show();
                InfoRating.Show();
                InfoCategory.Show();
                InfoTypeOfShow.Show();
                HomeLessButton.Show();
                HomeAdvancedButton.Show();
                InfoLabel_All.Show();
                InfoPicture_Poster.Show();
                HomeReviewTextBox.Show();

                HomeReviewTextBox.Height = 140;
                HomeReviewTextBox.ForeColor = Color.White;
                HomeReviewTextBox.ReadOnly = true;
                InfoNameOfShow.Text = SelectedItemHomeListView.Replace("%27", "'");

                //GetInfo(Column in table, Label on form);   <-- Gets Column and applies the data to the label
                GetInfo("Category", "InfoCategory");
                GetInfo("Show_Type", "InfoTypeOfShow");
                GetInfo("Rating", "InfoRating");
                GetInfo("Year", "HomeYearLabel");

                DataTable dt = new DataTable();
                string SQLCommand = ($"SELECT * FROM info WHERE NAME = ('{InfoNameOfShow.Text.Replace("'", "%27")}')");
                dt = DAL.ExecCommand(SQLCommand);
                string ShowCategory = dt.Rows[0]["Review"].ToString();
                HomeReviewTextBox.Text = ShowCategory;

                await ShowsExtendedInfo();
            }
        }

        public async Task ShowsExtendedInfo()
        {
            if (InfoTypeOfShow.Text == "TV Show")
            {
                InfoTypeOfShow.Text = "series";
            }
            using (var httpClient = new HttpClient())
            {
                var Json = await httpClient.GetStringAsync("http://www.omdbapi.com/?apikey=1ed13ca2&t=" + InfoNameOfShow.Text.Replace("'", "%27")
                     + "&type=" + InfoTypeOfShow.Text.ToLower() + "&y=" + HomeYearLabel.Text );
                var ShowsExtendedInfo = new JavaScriptSerializer().Deserialize<ShowsExtendedInfo>(Json);

                if (InfoTypeOfShow.Text == "Movie")
                {
                    InfoLabel_All.Text = "Released: " + ShowsExtendedInfo.Released
                        + "\nRating: " + ShowsExtendedInfo.imdbRating + "/10 (" + ShowsExtendedInfo.imdbVotes + " Votes)"
                        + "\nRuntime: " + ShowsExtendedInfo.Runtime;
                }
                else
                {
                    InfoLabel_All.Text = "Years: " + ShowsExtendedInfo.Year
                        + "\nReleased: " + ShowsExtendedInfo.Released
                        + "\nSeasons: " + ShowsExtendedInfo.totalSeasons
                        + "\nRating: " + ShowsExtendedInfo.imdbRating + "/10 (" + ShowsExtendedInfo.imdbVotes + " Votes)"
                        + "\nRuntime: " + ShowsExtendedInfo.Runtime;
                }
                if (ShowsExtendedInfo.Poster == null || ShowsExtendedInfo.Poster == "N/A")
                {
                    InfoPicture_Poster.ImageLocation = "https://ul.sbond.ml/i/etc/imgnotfound.png";
                    InfoLabel_All.Text = "Nothing Found.";
                }
                else
                {
                    InfoPicture_Poster.ImageLocation = ShowsExtendedInfo.Poster;
                }
            }
        }

        private void HomeLessButton_Click(object sender, EventArgs e)
        {
            Refresher();
        }

        private async void InfoNameOfShow_LinkClickedAsync(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (InfoTypeOfShow.Text == "TV Show")
            {
                InfoTypeOfShow.Text = "series";
            }
            await OpenLinkAsync();
        }

        public async Task OpenLinkAsync()
        {
            using (var httpClient = new HttpClient())
            {
                var Json = await httpClient.GetStringAsync("http://www.omdbapi.com/?apikey=1ed13ca2&t=" + InfoNameOfShow.Text.Replace("'", "%27")
                 + "&type=" + InfoTypeOfShow.Text.ToLower());
                var ShowsExtendedInfo = new JavaScriptSerializer().Deserialize<ShowsExtendedInfo>(Json);
                Process.Start("https://www.imdb.com/title/" + ShowsExtendedInfo.imdbID);
            }
        }

        private void HomeAdvancedButton_Click(object sender, EventArgs e)
        {
            PassNameOfShow = InfoNameOfShow.Text.Replace("'", "%27"); // Passing all text in 'InfoNameOfShow.text' to any other form (Make sure you define variable stuff at the top)
            PassReviewText = HomeReviewTextBox.Text;
            Advanced AdvancedForm = new Advanced();
            AdvancedForm.Show();
        }

        private void PanelCloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PanelMinButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void HomeYearTextBox_MouseHover(object sender, EventArgs e)
        {

        }

        private void HomeToolTip_Draw(object sender, DrawToolTipEventArgs e)
        {
            e.DrawBackground();
            e.DrawText();
        }

        private void HomeSettingsButton_Click(object sender, EventArgs e)
        {
            HomeTextbox.Hide();
            HomeYearTextBox.Hide();
            RatingsDropdown.Hide();
            CategoryDropdown.Hide();
            ContentTypeDropdown.Hide();
            HomeReviewTextBox.Hide();
            HomeLessButton.Show();
            InfoCategory.Hide();
            InfoRating.Hide();
            InfoTypeOfShow.Hide();
            HomeAdvancedButton.Hide();
            InfoLabel_All.Hide();
            InfoPicture_Poster.Hide();
            SettingsExportListLabel.Show();
            SettingsImportShowsLinkLabel.Show();
            SettingsDeleteAllLinkLabel.Show();
            InfoNameOfShow.Show(); // Recycling
            InfoNameOfShow.Text = "Settings";
            InfoNameOfShow.Links.Clear();
        }

        private void SettingsExportListLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ExportForm ExportForm = new ExportForm();
            ExportForm.Show();
        }

        private void SettingsImportShowsLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ImportForm ImportForm = new ImportForm();
            ImportForm.Show();
        }

        private void SettingsDeleteAllLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show($"Are you sure?\nThis is irreversable and will delete all of your shows!", "Delete Shows", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                // user clicks yes
                DataTable DeleteAllShows = new DataTable();
                string SQLCommand = ("DELETE FROM info");
                DeleteAllShows = DAL.ExecCommand(SQLCommand);
                Refresher();
            }
            else
            {
                // user clicks no
            }
        }
    }

    class ShowsExtendedInfo
    {
        public string Title { get; set; }
        public string Year { get; set; } // Years (from release to last episode)
        public string Released { get; set; } // Release date
        public string totalSeasons { get; set; }
        public string imdbRating { get; set; } // Average rating from votes on IMDb
        public string imdbVotes { get; set; } // How many voted on IMDb
        public string Poster { get; set; }
        public string imdbID { get; set; }
        public string Runtime { get; set; }
    }
}