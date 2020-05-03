namespace List_Of_Watched_Content
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.HomeTextbox = new System.Windows.Forms.TextBox();
            this.ContentTypeDropdown = new System.Windows.Forms.ComboBox();
            this.CategoryDropdown = new System.Windows.Forms.ComboBox();
            this.HomeMovieCheckBox = new System.Windows.Forms.CheckBox();
            this.HomeTVCheckBox = new System.Windows.Forms.CheckBox();
            this.HomeReviewTextBox = new System.Windows.Forms.RichTextBox();
            this.InfoNameOfShow = new System.Windows.Forms.LinkLabel();
            this.InfoCategory = new System.Windows.Forms.Label();
            this.InfoRating = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.InfoTypeOfShow = new System.Windows.Forms.Label();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.PanelName = new System.Windows.Forms.Label();
            this.PanelMinButton = new System.Windows.Forms.Button();
            this.PanelCloseButton = new System.Windows.Forms.Button();
            this.HomeShowListView = new MetroFramework.Controls.MetroListView();
            this.HomeMoreButton = new System.Windows.Forms.Button();
            this.HomeLessButton = new System.Windows.Forms.Button();
            this.HomeAddButton = new System.Windows.Forms.Button();
            this.HomeAdvancedButton = new System.Windows.Forms.Button();
            this.RatingsDropdown = new System.Windows.Forms.ComboBox();
            this.InfoLabel_All = new System.Windows.Forms.Label();
            this.HomeSearchShowsTextBox = new System.Windows.Forms.TextBox();
            this.HomeYearTextBox = new System.Windows.Forms.TextBox();
            this.HomeYearLabel = new System.Windows.Forms.Label();
            this.HomeToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.HomeSearchShowsButton = new System.Windows.Forms.Button();
            this.HomeSettingsButton = new System.Windows.Forms.Button();
            this.SettingsExportListLabel = new System.Windows.Forms.LinkLabel();
            this.SettingsDeleteAllLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SettingsImportShowsLinkLabel = new System.Windows.Forms.LinkLabel();
            this.InfoPicture_Poster = new System.Windows.Forms.PictureBox();
            this.HomeRefreshListButton = new System.Windows.Forms.Button();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InfoPicture_Poster)).BeginInit();
            this.SuspendLayout();
            // 
            // HomeTextbox
            // 
            this.HomeTextbox.AllowDrop = true;
            this.HomeTextbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.HomeTextbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.HomeTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.HomeTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HomeTextbox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeTextbox.ForeColor = System.Drawing.Color.Gray;
            this.HomeTextbox.Location = new System.Drawing.Point(482, 33);
            this.HomeTextbox.Name = "HomeTextbox";
            this.HomeTextbox.Size = new System.Drawing.Size(450, 33);
            this.HomeTextbox.TabIndex = 10;
            this.HomeTextbox.Text = "Movie or TV Shows Name...";
            this.HomeToolTip.SetToolTip(this.HomeTextbox, "Enter Movie/TV Show Name.");
            this.HomeTextbox.Enter += new System.EventHandler(this.HomeTextbox_Enter);
            this.HomeTextbox.Leave += new System.EventHandler(this.HomeTextbox_Leave);
            // 
            // ContentTypeDropdown
            // 
            this.ContentTypeDropdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ContentTypeDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ContentTypeDropdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ContentTypeDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContentTypeDropdown.ForeColor = System.Drawing.Color.White;
            this.ContentTypeDropdown.FormattingEnabled = true;
            this.ContentTypeDropdown.Items.AddRange(new object[] {
            "-- Type",
            "Movie",
            "TV Show"});
            this.ContentTypeDropdown.Location = new System.Drawing.Point(782, 71);
            this.ContentTypeDropdown.Name = "ContentTypeDropdown";
            this.ContentTypeDropdown.Size = new System.Drawing.Size(150, 23);
            this.ContentTypeDropdown.TabIndex = 4;
            this.HomeToolTip.SetToolTip(this.ContentTypeDropdown, "Chose a type of show.");
            // 
            // CategoryDropdown
            // 
            this.CategoryDropdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.CategoryDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryDropdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CategoryDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryDropdown.ForeColor = System.Drawing.Color.White;
            this.CategoryDropdown.FormattingEnabled = true;
            this.CategoryDropdown.Items.AddRange(new object[] {
            "-- Category",
            "Action",
            "Adventure",
            "Comedy",
            "Crime",
            "Drama",
            "Horror",
            "Science Fiction",
            "Thriller",
            "Western",
            "Other/Unknown"});
            this.CategoryDropdown.Location = new System.Drawing.Point(628, 71);
            this.CategoryDropdown.Name = "CategoryDropdown";
            this.CategoryDropdown.Size = new System.Drawing.Size(150, 23);
            this.CategoryDropdown.TabIndex = 5;
            this.HomeToolTip.SetToolTip(this.CategoryDropdown, "Chose a category.");
            // 
            // HomeMovieCheckBox
            // 
            this.HomeMovieCheckBox.AutoSize = true;
            this.HomeMovieCheckBox.FlatAppearance.BorderSize = 0;
            this.HomeMovieCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeMovieCheckBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeMovieCheckBox.ForeColor = System.Drawing.Color.White;
            this.HomeMovieCheckBox.Location = new System.Drawing.Point(13, 482);
            this.HomeMovieCheckBox.Name = "HomeMovieCheckBox";
            this.HomeMovieCheckBox.Size = new System.Drawing.Size(76, 25);
            this.HomeMovieCheckBox.TabIndex = 11;
            this.HomeMovieCheckBox.Text = "Movies";
            this.HomeToolTip.SetToolTip(this.HomeMovieCheckBox, "Filter by Movies.");
            this.HomeMovieCheckBox.UseVisualStyleBackColor = true;
            this.HomeMovieCheckBox.Click += new System.EventHandler(this.HomeMovieCheckBox_Click);
            // 
            // HomeTVCheckBox
            // 
            this.HomeTVCheckBox.AutoSize = true;
            this.HomeTVCheckBox.FlatAppearance.BorderSize = 0;
            this.HomeTVCheckBox.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.HomeTVCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeTVCheckBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeTVCheckBox.ForeColor = System.Drawing.Color.White;
            this.HomeTVCheckBox.Location = new System.Drawing.Point(95, 482);
            this.HomeTVCheckBox.Name = "HomeTVCheckBox";
            this.HomeTVCheckBox.Size = new System.Drawing.Size(94, 25);
            this.HomeTVCheckBox.TabIndex = 12;
            this.HomeTVCheckBox.Text = "TV Shows";
            this.HomeToolTip.SetToolTip(this.HomeTVCheckBox, "Filter by TV Shows.");
            this.HomeTVCheckBox.UseVisualStyleBackColor = true;
            this.HomeTVCheckBox.Click += new System.EventHandler(this.HomeTVCheckBox_Click);
            // 
            // HomeReviewTextBox
            // 
            this.HomeReviewTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.HomeReviewTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HomeReviewTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeReviewTextBox.ForeColor = System.Drawing.Color.Gray;
            this.HomeReviewTextBox.Location = new System.Drawing.Point(482, 99);
            this.HomeReviewTextBox.Name = "HomeReviewTextBox";
            this.HomeReviewTextBox.Size = new System.Drawing.Size(450, 140);
            this.HomeReviewTextBox.TabIndex = 14;
            this.HomeReviewTextBox.Text = "Review or Just Your General Thoughts...";
            this.HomeReviewTextBox.Enter += new System.EventHandler(this.HomeReviewTextBox_Enter);
            // 
            // InfoNameOfShow
            // 
            this.InfoNameOfShow.ActiveLinkColor = System.Drawing.Color.Black;
            this.InfoNameOfShow.AutoSize = true;
            this.InfoNameOfShow.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoNameOfShow.ForeColor = System.Drawing.Color.White;
            this.InfoNameOfShow.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.InfoNameOfShow.Location = new System.Drawing.Point(477, 34);
            this.InfoNameOfShow.Name = "InfoNameOfShow";
            this.InfoNameOfShow.Size = new System.Drawing.Size(134, 28);
            this.InfoNameOfShow.TabIndex = 1;
            this.InfoNameOfShow.TabStop = true;
            this.InfoNameOfShow.Text = "Show Name";
            this.InfoNameOfShow.Visible = false;
            this.InfoNameOfShow.VisitedLinkColor = System.Drawing.Color.Black;
            this.InfoNameOfShow.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.InfoNameOfShow_LinkClickedAsync);
            // 
            // InfoCategory
            // 
            this.InfoCategory.AutoSize = true;
            this.InfoCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InfoCategory.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.InfoCategory.Location = new System.Drawing.Point(651, 72);
            this.InfoCategory.Name = "InfoCategory";
            this.InfoCategory.Size = new System.Drawing.Size(125, 20);
            this.InfoCategory.TabIndex = 18;
            this.InfoCategory.Text = "Other/Unknown";
            this.InfoCategory.Visible = false;
            // 
            // InfoRating
            // 
            this.InfoRating.AutoSize = true;
            this.InfoRating.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InfoRating.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoRating.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.InfoRating.Location = new System.Drawing.Point(478, 72);
            this.InfoRating.Name = "InfoRating";
            this.InfoRating.Size = new System.Drawing.Size(138, 20);
            this.InfoRating.TabIndex = 19;
            this.InfoRating.Text = "No Ratings Given.";
            this.InfoRating.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(622, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 20;
            this.label1.Visible = false;
            // 
            // InfoTypeOfShow
            // 
            this.InfoTypeOfShow.AutoSize = true;
            this.InfoTypeOfShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InfoTypeOfShow.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoTypeOfShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.InfoTypeOfShow.Location = new System.Drawing.Point(807, 72);
            this.InfoTypeOfShow.Name = "InfoTypeOfShow";
            this.InfoTypeOfShow.Size = new System.Drawing.Size(125, 20);
            this.InfoTypeOfShow.TabIndex = 21;
            this.InfoTypeOfShow.Text = "Other/Unknown";
            this.InfoTypeOfShow.Visible = false;
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.TopPanel.Controls.Add(this.PanelName);
            this.TopPanel.Controls.Add(this.PanelMinButton);
            this.TopPanel.Controls.Add(this.PanelCloseButton);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(944, 26);
            this.TopPanel.TabIndex = 27;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            // 
            // PanelName
            // 
            this.PanelName.AutoSize = true;
            this.PanelName.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelName.ForeColor = System.Drawing.Color.White;
            this.PanelName.Location = new System.Drawing.Point(5, 2);
            this.PanelName.Name = "PanelName";
            this.PanelName.Size = new System.Drawing.Size(89, 21);
            this.PanelName.TabIndex = 30;
            this.PanelName.Text = "Watch List";
            // 
            // PanelMinButton
            // 
            this.PanelMinButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.PanelMinButton.BackColor = System.Drawing.Color.Transparent;
            this.PanelMinButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.PanelMinButton.FlatAppearance.BorderSize = 0;
            this.PanelMinButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.PanelMinButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.PanelMinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PanelMinButton.Font = new System.Drawing.Font("Marlett", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.PanelMinButton.ForeColor = System.Drawing.Color.White;
            this.PanelMinButton.Location = new System.Drawing.Point(867, 0);
            this.PanelMinButton.Name = "PanelMinButton";
            this.PanelMinButton.Size = new System.Drawing.Size(40, 26);
            this.PanelMinButton.TabIndex = 29;
            this.PanelMinButton.Text = "0";
            this.PanelMinButton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.HomeToolTip.SetToolTip(this.PanelMinButton, "Minimize");
            this.PanelMinButton.UseVisualStyleBackColor = false;
            this.PanelMinButton.Click += new System.EventHandler(this.PanelMinButton_Click);
            // 
            // PanelCloseButton
            // 
            this.PanelCloseButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.PanelCloseButton.BackColor = System.Drawing.Color.Transparent;
            this.PanelCloseButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.PanelCloseButton.FlatAppearance.BorderSize = 0;
            this.PanelCloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.PanelCloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.PanelCloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PanelCloseButton.Font = new System.Drawing.Font("Marlett", 11.25F);
            this.PanelCloseButton.ForeColor = System.Drawing.Color.White;
            this.PanelCloseButton.Location = new System.Drawing.Point(904, 0);
            this.PanelCloseButton.Name = "PanelCloseButton";
            this.PanelCloseButton.Size = new System.Drawing.Size(40, 26);
            this.PanelCloseButton.TabIndex = 28;
            this.PanelCloseButton.Text = "r";
            this.HomeToolTip.SetToolTip(this.PanelCloseButton, "Close");
            this.PanelCloseButton.UseVisualStyleBackColor = false;
            this.PanelCloseButton.Click += new System.EventHandler(this.PanelCloseButton_Click);
            // 
            // HomeShowListView
            // 
            this.HomeShowListView.AllowSorting = true;
            this.HomeShowListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.HomeShowListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HomeShowListView.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.HomeShowListView.ForeColor = System.Drawing.Color.White;
            this.HomeShowListView.FullRowSelect = true;
            this.HomeShowListView.Location = new System.Drawing.Point(12, 71);
            this.HomeShowListView.MultiSelect = false;
            this.HomeShowListView.Name = "HomeShowListView";
            this.HomeShowListView.OwnerDraw = true;
            this.HomeShowListView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HomeShowListView.Size = new System.Drawing.Size(464, 403);
            this.HomeShowListView.Style = MetroFramework.MetroColorStyle.Black;
            this.HomeShowListView.TabIndex = 1;
            this.HomeShowListView.UseCompatibleStateImageBehavior = false;
            this.HomeShowListView.UseCustomBackColor = true;
            this.HomeShowListView.UseCustomForeColor = true;
            this.HomeShowListView.UseSelectable = true;
            this.HomeShowListView.UseStyleColors = true;
            this.HomeShowListView.View = System.Windows.Forms.View.Details;
            this.HomeShowListView.Click += new System.EventHandler(this.HomeShowListbox_Click);
            // 
            // HomeMoreButton
            // 
            this.HomeMoreButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.HomeMoreButton.FlatAppearance.BorderSize = 0;
            this.HomeMoreButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.HomeMoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeMoreButton.ForeColor = System.Drawing.Color.Transparent;
            this.HomeMoreButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.HomeMoreButton.Location = new System.Drawing.Point(401, 482);
            this.HomeMoreButton.Name = "HomeMoreButton";
            this.HomeMoreButton.Size = new System.Drawing.Size(75, 30);
            this.HomeMoreButton.TabIndex = 31;
            this.HomeMoreButton.Text = " More⏵";
            this.HomeMoreButton.UseVisualStyleBackColor = false;
            this.HomeMoreButton.Click += new System.EventHandler(this.HomeMoreButton_ClickAsync);
            // 
            // HomeLessButton
            // 
            this.HomeLessButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.HomeLessButton.FlatAppearance.BorderSize = 0;
            this.HomeLessButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.HomeLessButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeLessButton.ForeColor = System.Drawing.Color.Transparent;
            this.HomeLessButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.HomeLessButton.Location = new System.Drawing.Point(482, 482);
            this.HomeLessButton.Name = "HomeLessButton";
            this.HomeLessButton.Size = new System.Drawing.Size(75, 30);
            this.HomeLessButton.TabIndex = 32;
            this.HomeLessButton.Text = "⏴Less ";
            this.HomeLessButton.UseVisualStyleBackColor = false;
            this.HomeLessButton.Visible = false;
            this.HomeLessButton.Click += new System.EventHandler(this.HomeLessButton_Click);
            // 
            // HomeAddButton
            // 
            this.HomeAddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.HomeAddButton.FlatAppearance.BorderSize = 0;
            this.HomeAddButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.HomeAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeAddButton.ForeColor = System.Drawing.Color.White;
            this.HomeAddButton.Location = new System.Drawing.Point(857, 482);
            this.HomeAddButton.Name = "HomeAddButton";
            this.HomeAddButton.Size = new System.Drawing.Size(75, 30);
            this.HomeAddButton.TabIndex = 33;
            this.HomeAddButton.Text = "Add";
            this.HomeAddButton.UseVisualStyleBackColor = false;
            this.HomeAddButton.Click += new System.EventHandler(this.HomeAddButton_Click);
            // 
            // HomeAdvancedButton
            // 
            this.HomeAdvancedButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.HomeAdvancedButton.FlatAppearance.BorderSize = 0;
            this.HomeAdvancedButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.HomeAdvancedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeAdvancedButton.ForeColor = System.Drawing.Color.Transparent;
            this.HomeAdvancedButton.Location = new System.Drawing.Point(857, 482);
            this.HomeAdvancedButton.Name = "HomeAdvancedButton";
            this.HomeAdvancedButton.Size = new System.Drawing.Size(75, 30);
            this.HomeAdvancedButton.TabIndex = 34;
            this.HomeAdvancedButton.Text = "Advanced";
            this.HomeAdvancedButton.UseVisualStyleBackColor = false;
            this.HomeAdvancedButton.Click += new System.EventHandler(this.HomeAdvancedButton_Click);
            // 
            // RatingsDropdown
            // 
            this.RatingsDropdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.RatingsDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RatingsDropdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RatingsDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RatingsDropdown.ForeColor = System.Drawing.Color.White;
            this.RatingsDropdown.FormattingEnabled = true;
            this.RatingsDropdown.Items.AddRange(new object[] {
            "-- Rating",
            "1/5",
            "2/5",
            "3/5",
            "4/5",
            "5/5"});
            this.RatingsDropdown.Location = new System.Drawing.Point(540, 71);
            this.RatingsDropdown.Name = "RatingsDropdown";
            this.RatingsDropdown.Size = new System.Drawing.Size(84, 23);
            this.RatingsDropdown.TabIndex = 22;
            this.HomeToolTip.SetToolTip(this.RatingsDropdown, "Rate the show out of 5.");
            // 
            // InfoLabel_All
            // 
            this.InfoLabel_All.AutoSize = true;
            this.InfoLabel_All.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoLabel_All.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.InfoLabel_All.Location = new System.Drawing.Point(668, 245);
            this.InfoLabel_All.Name = "InfoLabel_All";
            this.InfoLabel_All.Size = new System.Drawing.Size(49, 20);
            this.InfoLabel_All.TabIndex = 23;
            this.InfoLabel_All.Text = "Info...";
            this.InfoLabel_All.Visible = false;
            // 
            // HomeSearchShowsTextBox
            // 
            this.HomeSearchShowsTextBox.AllowDrop = true;
            this.HomeSearchShowsTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.HomeSearchShowsTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.HomeSearchShowsTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.HomeSearchShowsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HomeSearchShowsTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeSearchShowsTextBox.ForeColor = System.Drawing.Color.Gray;
            this.HomeSearchShowsTextBox.Location = new System.Drawing.Point(12, 33);
            this.HomeSearchShowsTextBox.Name = "HomeSearchShowsTextBox";
            this.HomeSearchShowsTextBox.Size = new System.Drawing.Size(464, 33);
            this.HomeSearchShowsTextBox.TabIndex = 35;
            this.HomeSearchShowsTextBox.Text = "Search Your Watch List...";
            this.HomeSearchShowsTextBox.Visible = false;
            this.HomeSearchShowsTextBox.TextChanged += new System.EventHandler(this.HomeSearchShowsTextBox_TextChanged);
            this.HomeSearchShowsTextBox.Enter += new System.EventHandler(this.HomeSearchShowsTextBox_Enter);
            // 
            // HomeYearTextBox
            // 
            this.HomeYearTextBox.AllowDrop = true;
            this.HomeYearTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.HomeYearTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.HomeYearTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.HomeYearTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HomeYearTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.HomeYearTextBox.ForeColor = System.Drawing.Color.Gray;
            this.HomeYearTextBox.Location = new System.Drawing.Point(482, 70);
            this.HomeYearTextBox.Name = "HomeYearTextBox";
            this.HomeYearTextBox.Size = new System.Drawing.Size(54, 25);
            this.HomeYearTextBox.TabIndex = 37;
            this.HomeYearTextBox.Text = "Year";
            this.HomeYearTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HomeToolTip.SetToolTip(this.HomeYearTextBox, "Set Year (for better accuracy with extra info) or keep default.");
            this.HomeYearTextBox.Enter += new System.EventHandler(this.HomeYearTextBox_Enter);
            this.HomeYearTextBox.MouseHover += new System.EventHandler(this.HomeYearTextBox_MouseHover);
            // 
            // HomeYearLabel
            // 
            this.HomeYearLabel.AutoSize = true;
            this.HomeYearLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeYearLabel.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeYearLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.HomeYearLabel.Location = new System.Drawing.Point(901, 44);
            this.HomeYearLabel.Name = "HomeYearLabel";
            this.HomeYearLabel.Size = new System.Drawing.Size(31, 16);
            this.HomeYearLabel.TabIndex = 38;
            this.HomeYearLabel.Text = "Year";
            this.HomeYearLabel.Visible = false;
            // 
            // HomeToolTip
            // 
            this.HomeToolTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.HomeToolTip.ForeColor = System.Drawing.Color.White;
            this.HomeToolTip.OwnerDraw = true;
            this.HomeToolTip.Draw += new System.Windows.Forms.DrawToolTipEventHandler(this.HomeToolTip_Draw);
            // 
            // HomeSearchShowsButton
            // 
            this.HomeSearchShowsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.HomeSearchShowsButton.FlatAppearance.BorderSize = 0;
            this.HomeSearchShowsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.HomeSearchShowsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeSearchShowsButton.ForeColor = System.Drawing.Color.Transparent;
            this.HomeSearchShowsButton.Location = new System.Drawing.Point(278, 482);
            this.HomeSearchShowsButton.Name = "HomeSearchShowsButton";
            this.HomeSearchShowsButton.Size = new System.Drawing.Size(75, 30);
            this.HomeSearchShowsButton.TabIndex = 36;
            this.HomeSearchShowsButton.Text = "Search";
            this.HomeSearchShowsButton.UseVisualStyleBackColor = false;
            this.HomeSearchShowsButton.Click += new System.EventHandler(this.HomeSearchShowsButton_Click);
            // 
            // HomeSettingsButton
            // 
            this.HomeSettingsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.HomeSettingsButton.FlatAppearance.BorderSize = 0;
            this.HomeSettingsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.HomeSettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeSettingsButton.ForeColor = System.Drawing.Color.Transparent;
            this.HomeSettingsButton.Location = new System.Drawing.Point(197, 482);
            this.HomeSettingsButton.Name = "HomeSettingsButton";
            this.HomeSettingsButton.Size = new System.Drawing.Size(75, 30);
            this.HomeSettingsButton.TabIndex = 39;
            this.HomeSettingsButton.Text = "Settings";
            this.HomeSettingsButton.UseVisualStyleBackColor = false;
            this.HomeSettingsButton.Click += new System.EventHandler(this.HomeSettingsButton_Click);
            // 
            // SettingsExportListLabel
            // 
            this.SettingsExportListLabel.ActiveLinkColor = System.Drawing.Color.White;
            this.SettingsExportListLabel.AutoSize = true;
            this.SettingsExportListLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsExportListLabel.ForeColor = System.Drawing.Color.White;
            this.SettingsExportListLabel.LinkColor = System.Drawing.Color.White;
            this.SettingsExportListLabel.Location = new System.Drawing.Point(836, 77);
            this.SettingsExportListLabel.Name = "SettingsExportListLabel";
            this.SettingsExportListLabel.Size = new System.Drawing.Size(96, 17);
            this.SettingsExportListLabel.TabIndex = 40;
            this.SettingsExportListLabel.TabStop = true;
            this.SettingsExportListLabel.Text = "Export This List";
            this.SettingsExportListLabel.Visible = false;
            this.SettingsExportListLabel.VisitedLinkColor = System.Drawing.Color.White;
            this.SettingsExportListLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SettingsExportListLabel_LinkClicked);
            // 
            // SettingsDeleteAllLinkLabel
            // 
            this.SettingsDeleteAllLinkLabel.ActiveLinkColor = System.Drawing.Color.White;
            this.SettingsDeleteAllLinkLabel.AutoSize = true;
            this.SettingsDeleteAllLinkLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsDeleteAllLinkLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.SettingsDeleteAllLinkLabel.LinkColor = System.Drawing.Color.Red;
            this.SettingsDeleteAllLinkLabel.Location = new System.Drawing.Point(828, 457);
            this.SettingsDeleteAllLinkLabel.Name = "SettingsDeleteAllLinkLabel";
            this.SettingsDeleteAllLinkLabel.Size = new System.Drawing.Size(104, 17);
            this.SettingsDeleteAllLinkLabel.TabIndex = 41;
            this.SettingsDeleteAllLinkLabel.TabStop = true;
            this.SettingsDeleteAllLinkLabel.Text = "Delete All Shows";
            this.SettingsDeleteAllLinkLabel.Visible = false;
            this.SettingsDeleteAllLinkLabel.VisitedLinkColor = System.Drawing.Color.White;
            this.SettingsDeleteAllLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SettingsDeleteAllLinkLabel_LinkClicked);
            // 
            // SettingsImportShowsLinkLabel
            // 
            this.SettingsImportShowsLinkLabel.ActiveLinkColor = System.Drawing.Color.White;
            this.SettingsImportShowsLinkLabel.AutoSize = true;
            this.SettingsImportShowsLinkLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsImportShowsLinkLabel.ForeColor = System.Drawing.Color.White;
            this.SettingsImportShowsLinkLabel.LinkColor = System.Drawing.Color.White;
            this.SettingsImportShowsLinkLabel.Location = new System.Drawing.Point(814, 99);
            this.SettingsImportShowsLinkLabel.Name = "SettingsImportShowsLinkLabel";
            this.SettingsImportShowsLinkLabel.Size = new System.Drawing.Size(118, 17);
            this.SettingsImportShowsLinkLabel.TabIndex = 42;
            this.SettingsImportShowsLinkLabel.TabStop = true;
            this.SettingsImportShowsLinkLabel.Text = "Import Your Shows";
            this.SettingsImportShowsLinkLabel.Visible = false;
            this.SettingsImportShowsLinkLabel.VisitedLinkColor = System.Drawing.Color.White;
            this.SettingsImportShowsLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SettingsImportShowsLinkLabel_LinkClicked);
            // 
            // InfoPicture_Poster
            // 
            this.InfoPicture_Poster.Location = new System.Drawing.Point(482, 245);
            this.InfoPicture_Poster.Name = "InfoPicture_Poster";
            this.InfoPicture_Poster.Size = new System.Drawing.Size(180, 229);
            this.InfoPicture_Poster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.InfoPicture_Poster.TabIndex = 24;
            this.InfoPicture_Poster.TabStop = false;
            this.InfoPicture_Poster.Visible = false;
            // 
            // HomeRefreshListButton
            // 
            this.HomeRefreshListButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.HomeRefreshListButton.FlatAppearance.BorderSize = 0;
            this.HomeRefreshListButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.HomeRefreshListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeRefreshListButton.ForeColor = System.Drawing.Color.Transparent;
            this.HomeRefreshListButton.Image = global::List_Of_Watched_Content.Properties.Resources.refresh_white_24x24;
            this.HomeRefreshListButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.HomeRefreshListButton.Location = new System.Drawing.Point(359, 482);
            this.HomeRefreshListButton.Name = "HomeRefreshListButton";
            this.HomeRefreshListButton.Size = new System.Drawing.Size(36, 30);
            this.HomeRefreshListButton.TabIndex = 29;
            this.HomeRefreshListButton.UseVisualStyleBackColor = false;
            this.HomeRefreshListButton.Click += new System.EventHandler(this.HomeRefreshListButton_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(944, 523);
            this.Controls.Add(this.SettingsImportShowsLinkLabel);
            this.Controls.Add(this.SettingsDeleteAllLinkLabel);
            this.Controls.Add(this.HomeSettingsButton);
            this.Controls.Add(this.HomeSearchShowsTextBox);
            this.Controls.Add(this.HomeShowListView);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.InfoPicture_Poster);
            this.Controls.Add(this.InfoLabel_All);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HomeTVCheckBox);
            this.Controls.Add(this.HomeMovieCheckBox);
            this.Controls.Add(this.HomeSearchShowsButton);
            this.Controls.Add(this.HomeLessButton);
            this.Controls.Add(this.HomeMoreButton);
            this.Controls.Add(this.HomeRefreshListButton);
            this.Controls.Add(this.HomeAddButton);
            this.Controls.Add(this.HomeAdvancedButton);
            this.Controls.Add(this.InfoNameOfShow);
            this.Controls.Add(this.HomeTextbox);
            this.Controls.Add(this.HomeYearLabel);
            this.Controls.Add(this.HomeYearTextBox);
            this.Controls.Add(this.RatingsDropdown);
            this.Controls.Add(this.CategoryDropdown);
            this.Controls.Add(this.SettingsExportListLabel);
            this.Controls.Add(this.InfoRating);
            this.Controls.Add(this.InfoCategory);
            this.Controls.Add(this.InfoTypeOfShow);
            this.Controls.Add(this.HomeReviewTextBox);
            this.Controls.Add(this.ContentTypeDropdown);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InfoPicture_Poster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel InfoNameOfShow;
        private System.Windows.Forms.TextBox HomeTextbox;
        private System.Windows.Forms.ComboBox ContentTypeDropdown;
        private System.Windows.Forms.ComboBox CategoryDropdown;
        private System.Windows.Forms.CheckBox HomeMovieCheckBox;
        private System.Windows.Forms.CheckBox HomeTVCheckBox;
        private System.Windows.Forms.RichTextBox HomeReviewTextBox;
        private System.Windows.Forms.Label InfoCategory;
        private System.Windows.Forms.Label InfoRating;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label InfoTypeOfShow;
        private System.Windows.Forms.PictureBox InfoPicture_Poster;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Button PanelCloseButton;
        private System.Windows.Forms.Button PanelMinButton;
        private System.Windows.Forms.Button HomeRefreshListButton;
        private MetroFramework.Controls.MetroListView HomeShowListView;
        private System.Windows.Forms.Button HomeMoreButton;
        private System.Windows.Forms.Button HomeLessButton;
        private System.Windows.Forms.Button HomeAddButton;
        private System.Windows.Forms.Button HomeAdvancedButton;
        private System.Windows.Forms.ComboBox RatingsDropdown;
        private System.Windows.Forms.Label InfoLabel_All;
        private System.Windows.Forms.Label PanelName;
        private System.Windows.Forms.TextBox HomeSearchShowsTextBox;
        private System.Windows.Forms.Button HomeSearchShowsButton;
        private System.Windows.Forms.TextBox HomeYearTextBox;
        private System.Windows.Forms.Label HomeYearLabel;
        private System.Windows.Forms.ToolTip HomeToolTip;
        private System.Windows.Forms.Button HomeSettingsButton;
        private System.Windows.Forms.LinkLabel SettingsExportListLabel;
        private System.Windows.Forms.LinkLabel SettingsDeleteAllLinkLabel;
        private System.Windows.Forms.LinkLabel SettingsImportShowsLinkLabel;
    }
}

