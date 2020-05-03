using System;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace List_Of_Watched_Content
{
    public partial class Advanced : Form
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

        public Advanced()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 3, 3));
        }

        private void Advanced_Load(object sender, EventArgs e)
        {
            this.Height = 278;
            AdvancedDeleteButton.Location = new Point(259, 238);
            AdvancedDeleteButton.ForeColor = Color.Red;
            Pop();
        }

        public void Pop()
        {
            this.Text = Home.PassNameOfShow.Replace("%27", "'");

            AdvancedReviewTextBox.Text = Home.PassReviewText;

            AdvancedTypeDropDown.SelectedIndex = 0;
            AdvancedCategoryDropDown.SelectedIndex = 0;
            AdvancedRatingsDropdown.SelectedIndex = 0;
        }


        private void AdvancedDeleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Do you want to delete '{Home.PassNameOfShow}'?", "Delete From List", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // user clicks yes
                DataTable dt = new DataTable();
                string SQLCommand = ($"DELETE FROM info WHERE NAME = ('{Home.PassNameOfShow}'); LIMIT 1");
                dt = DAL.ExecCommand(SQLCommand);
                this.Close();
            }
            else
            {
                // user clicks no
            }
        }

        private void Updating(string WhatColumn, ref string TextOrDropBox)
        {
            DataTable dt = new DataTable();
            string SQLCommand = ($"UPDATE info SET {WhatColumn} = '{TextOrDropBox}' WHERE NAME = '{Home.PassNameOfShow}'");
            dt = DAL.ExecCommand(SQLCommand);
        }

        private void AdvancedChangeNameButton_Click(object sender, EventArgs e)
        {
            if (AdvancedNameTextBox.Text == "")
            {
                MessageBox.Show("You need to type in a Show Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string NameTextBox = AdvancedNameTextBox.Text.Replace("'", "%27");
                Updating("Name", ref NameTextBox);
                this.Close();
            }
        }

        private void AdvancedChangeYearButton_Click(object sender, EventArgs e)
        {
            if (AdvancedYearTextBox.Text == "")
            {
                MessageBox.Show("You need to type in a Year.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string YearTextBox = AdvancedYearTextBox.Text;
                Updating("Year", ref YearTextBox);
            }
        }

        private void AdvancedChangeTypeButton_Click(object sender, EventArgs e)
        {
            if (AdvancedTypeDropDown.Text == "-- Type" || AdvancedTypeDropDown.Text == "")
            {
                MessageBox.Show("You need to select a Type Of Show.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string TypeDropBox = AdvancedTypeDropDown.Text;
                Updating("Show_Type", ref TypeDropBox);
            }
        }

        private void AdvancedChangeCatButton_Click(object sender, EventArgs e)
        {
            if (AdvancedCategoryDropDown.Text == "-- Category" || AdvancedCategoryDropDown.Text == "")
            {
                MessageBox.Show("You need to select a Category.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string CatDropBox = AdvancedCategoryDropDown.Text;
                Updating("Category", ref CatDropBox);
            }
        }

        private void AdvancedChangeRatingButton_Click(object sender, EventArgs e)
        {
            if (AdvancedRatingsDropdown.Text == "-- Rating" || AdvancedRatingsDropdown.Text == "")
            {
                MessageBox.Show("You need to select a Rating.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string RatDropBox = AdvancedRatingsDropdown.Text;
                Updating("Rating", ref RatDropBox);
            }
        }

        private void AdvancedChangeReviewBtn_Click(object sender, EventArgs e)
        {
            if (AdvancedReviewTextBox.Text == "")
            {
                AdvancedReviewTextBox.Text = "No Review/Thoughts Given.";
                string ReviewTextBox = AdvancedReviewTextBox.Text;
                Updating("Review", ref ReviewTextBox);
            }
            else
            {
                string ReviewTextBox = AdvancedReviewTextBox.Text;
                Updating("Review", ref ReviewTextBox);
            }
        }

        private void AdvancedMoreButton_Click(object sender, EventArgs e)
        {
            if (AdvancedMoreButton.Text == "▼")
            {
                this.Height = 617;
                AdvancedDeleteButton.Location = new Point(259, 576);
                AdvancedReviewTextBox.Show();
                AdvancedChangeReviewBtn.Show();
                AdvancedMoreButton.Text = "▲";
            }
            else
            {
                this.Height = 278;
                AdvancedDeleteButton.Location = new Point(259, 238);
                AdvancedReviewTextBox.Hide();
                AdvancedChangeReviewBtn.Hide();
                AdvancedMoreButton.Text = "▼";
            }
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

        private void AdvancedNameTextBox_Enter(object sender, EventArgs e)
        {
            if (AdvancedNameTextBox.Text == "Updated Name...")
            {
                AdvancedNameTextBox.Text = "";
            }
            AdvancedNameTextBox.ForeColor = Color.White;
        }

        private void AdvancedYearTextBox_Enter(object sender, EventArgs e)
        {
            if (AdvancedYearTextBox.Text == "Updated Year...")
            {
                AdvancedYearTextBox.Text = "";
            }
            AdvancedYearTextBox.ForeColor = Color.White;
        }

        private void AdvancedToolTip_Draw(object sender, DrawToolTipEventArgs e)
        {
            e.DrawBackground();
            e.DrawText();
        }
    }
}
