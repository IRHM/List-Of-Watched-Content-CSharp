namespace List_Of_Watched_Content
{
    partial class ImportForm
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
            this.ImportCheckBoxGroup = new System.Windows.Forms.GroupBox();
            this.ImportImportButton = new System.Windows.Forms.Button();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.PanelName = new System.Windows.Forms.Label();
            this.PanelMinButton = new System.Windows.Forms.Button();
            this.PanelCloseButton = new System.Windows.Forms.Button();
            this.ImportSelectFileButton = new System.Windows.Forms.Button();
            this.FileToImportTextBox = new System.Windows.Forms.TextBox();
            this.ImportCheckBoxGroup.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImportCheckBoxGroup
            // 
            this.ImportCheckBoxGroup.Controls.Add(this.FileToImportTextBox);
            this.ImportCheckBoxGroup.Controls.Add(this.ImportSelectFileButton);
            this.ImportCheckBoxGroup.ForeColor = System.Drawing.Color.White;
            this.ImportCheckBoxGroup.Location = new System.Drawing.Point(12, 32);
            this.ImportCheckBoxGroup.Name = "ImportCheckBoxGroup";
            this.ImportCheckBoxGroup.Size = new System.Drawing.Size(291, 77);
            this.ImportCheckBoxGroup.TabIndex = 38;
            this.ImportCheckBoxGroup.TabStop = false;
            this.ImportCheckBoxGroup.Text = "Type";
            // 
            // ImportImportButton
            // 
            this.ImportImportButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ImportImportButton.FlatAppearance.BorderSize = 0;
            this.ImportImportButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.ImportImportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImportImportButton.ForeColor = System.Drawing.Color.Transparent;
            this.ImportImportButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ImportImportButton.Location = new System.Drawing.Point(228, 118);
            this.ImportImportButton.Name = "ImportImportButton";
            this.ImportImportButton.Size = new System.Drawing.Size(75, 30);
            this.ImportImportButton.TabIndex = 37;
            this.ImportImportButton.Text = "Import >";
            this.ImportImportButton.UseVisualStyleBackColor = false;
            this.ImportImportButton.Click += new System.EventHandler(this.ImportImportButton_Click);
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
            this.TopPanel.Size = new System.Drawing.Size(315, 26);
            this.TopPanel.TabIndex = 36;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            // 
            // PanelName
            // 
            this.PanelName.AutoSize = true;
            this.PanelName.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelName.ForeColor = System.Drawing.Color.White;
            this.PanelName.Location = new System.Drawing.Point(5, 2);
            this.PanelName.Name = "PanelName";
            this.PanelName.Size = new System.Drawing.Size(128, 21);
            this.PanelName.TabIndex = 30;
            this.PanelName.Text = "Import Settings";
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
            this.PanelMinButton.Location = new System.Drawing.Point(238, 0);
            this.PanelMinButton.Name = "PanelMinButton";
            this.PanelMinButton.Size = new System.Drawing.Size(40, 26);
            this.PanelMinButton.TabIndex = 29;
            this.PanelMinButton.Text = "0";
            this.PanelMinButton.TextAlign = System.Drawing.ContentAlignment.TopRight;
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
            this.PanelCloseButton.Location = new System.Drawing.Point(275, 0);
            this.PanelCloseButton.Name = "PanelCloseButton";
            this.PanelCloseButton.Size = new System.Drawing.Size(40, 26);
            this.PanelCloseButton.TabIndex = 28;
            this.PanelCloseButton.Text = "r";
            this.PanelCloseButton.UseVisualStyleBackColor = false;
            this.PanelCloseButton.Click += new System.EventHandler(this.PanelCloseButton_Click);
            // 
            // ImportSelectFileButton
            // 
            this.ImportSelectFileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ImportSelectFileButton.FlatAppearance.BorderSize = 0;
            this.ImportSelectFileButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.ImportSelectFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImportSelectFileButton.ForeColor = System.Drawing.Color.Transparent;
            this.ImportSelectFileButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ImportSelectFileButton.Location = new System.Drawing.Point(239, 30);
            this.ImportSelectFileButton.Name = "ImportSelectFileButton";
            this.ImportSelectFileButton.Size = new System.Drawing.Size(36, 26);
            this.ImportSelectFileButton.TabIndex = 30;
            this.ImportSelectFileButton.Text = "...";
            this.ImportSelectFileButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ImportSelectFileButton.UseVisualStyleBackColor = false;
            this.ImportSelectFileButton.Click += new System.EventHandler(this.ImportSelectFileButton_Click);
            // 
            // FileToImportTextBox
            // 
            this.FileToImportTextBox.AllowDrop = true;
            this.FileToImportTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.FileToImportTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.FileToImportTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.FileToImportTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FileToImportTextBox.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.FileToImportTextBox.ForeColor = System.Drawing.Color.Gray;
            this.FileToImportTextBox.Location = new System.Drawing.Point(6, 29);
            this.FileToImportTextBox.Name = "FileToImportTextBox";
            this.FileToImportTextBox.Size = new System.Drawing.Size(227, 27);
            this.FileToImportTextBox.TabIndex = 31;
            this.FileToImportTextBox.Text = "File To Import...";
            // 
            // ImportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(315, 162);
            this.Controls.Add(this.ImportCheckBoxGroup);
            this.Controls.Add(this.ImportImportButton);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ImportForm";
            this.Text = "ImportForm";
            this.Load += new System.EventHandler(this.ImportForm_Load);
            this.ImportCheckBoxGroup.ResumeLayout(false);
            this.ImportCheckBoxGroup.PerformLayout();
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox ImportCheckBoxGroup;
        private System.Windows.Forms.Button ImportImportButton;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label PanelName;
        private System.Windows.Forms.Button PanelMinButton;
        private System.Windows.Forms.Button PanelCloseButton;
        private System.Windows.Forms.Button ImportSelectFileButton;
        private System.Windows.Forms.TextBox FileToImportTextBox;
    }
}