namespace List_Of_Watched_Content
{
    partial class ExportForm
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
            this.TopPanel = new System.Windows.Forms.Panel();
            this.PanelName = new System.Windows.Forms.Label();
            this.PanelMinButton = new System.Windows.Forms.Button();
            this.PanelCloseButton = new System.Windows.Forms.Button();
            this.ExportExportButton = new System.Windows.Forms.Button();
            this.ExportCSVCheckBox = new System.Windows.Forms.CheckBox();
            this.ExportCheckBoxGroup = new System.Windows.Forms.GroupBox();
            this.ExportTXTCheckBox = new System.Windows.Forms.CheckBox();
            this.OpenDownloadsCheckBox = new System.Windows.Forms.CheckBox();
            this.TopPanel.SuspendLayout();
            this.ExportCheckBoxGroup.SuspendLayout();
            this.SuspendLayout();
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
            this.TopPanel.TabIndex = 28;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            // 
            // PanelName
            // 
            this.PanelName.AutoSize = true;
            this.PanelName.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelName.ForeColor = System.Drawing.Color.White;
            this.PanelName.Location = new System.Drawing.Point(5, 2);
            this.PanelName.Name = "PanelName";
            this.PanelName.Size = new System.Drawing.Size(125, 21);
            this.PanelName.TabIndex = 30;
            this.PanelName.Text = "Export Settings";
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
            // ExportExportButton
            // 
            this.ExportExportButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ExportExportButton.FlatAppearance.BorderSize = 0;
            this.ExportExportButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.ExportExportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExportExportButton.ForeColor = System.Drawing.Color.Transparent;
            this.ExportExportButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ExportExportButton.Location = new System.Drawing.Point(228, 120);
            this.ExportExportButton.Name = "ExportExportButton";
            this.ExportExportButton.Size = new System.Drawing.Size(75, 30);
            this.ExportExportButton.TabIndex = 32;
            this.ExportExportButton.Text = "Export >";
            this.ExportExportButton.UseVisualStyleBackColor = false;
            this.ExportExportButton.Click += new System.EventHandler(this.ExportExportButton_Click);
            // 
            // ExportCSVCheckBox
            // 
            this.ExportCSVCheckBox.AutoSize = true;
            this.ExportCSVCheckBox.FlatAppearance.BorderSize = 0;
            this.ExportCSVCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExportCSVCheckBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportCSVCheckBox.ForeColor = System.Drawing.Color.White;
            this.ExportCSVCheckBox.Location = new System.Drawing.Point(23, 29);
            this.ExportCSVCheckBox.Name = "ExportCSVCheckBox";
            this.ExportCSVCheckBox.Size = new System.Drawing.Size(55, 25);
            this.ExportCSVCheckBox.TabIndex = 33;
            this.ExportCSVCheckBox.Text = "CSV";
            this.ExportCSVCheckBox.UseVisualStyleBackColor = true;
            this.ExportCSVCheckBox.Click += new System.EventHandler(this.ExportCSVCheckBox_Click);
            // 
            // ExportCheckBoxGroup
            // 
            this.ExportCheckBoxGroup.Controls.Add(this.ExportTXTCheckBox);
            this.ExportCheckBoxGroup.Controls.Add(this.ExportCSVCheckBox);
            this.ExportCheckBoxGroup.ForeColor = System.Drawing.Color.White;
            this.ExportCheckBoxGroup.Location = new System.Drawing.Point(12, 34);
            this.ExportCheckBoxGroup.Name = "ExportCheckBoxGroup";
            this.ExportCheckBoxGroup.Size = new System.Drawing.Size(291, 77);
            this.ExportCheckBoxGroup.TabIndex = 34;
            this.ExportCheckBoxGroup.TabStop = false;
            this.ExportCheckBoxGroup.Text = "Type";
            // 
            // ExportTXTCheckBox
            // 
            this.ExportTXTCheckBox.AutoSize = true;
            this.ExportTXTCheckBox.FlatAppearance.BorderSize = 0;
            this.ExportTXTCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExportTXTCheckBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportTXTCheckBox.ForeColor = System.Drawing.Color.White;
            this.ExportTXTCheckBox.Location = new System.Drawing.Point(84, 29);
            this.ExportTXTCheckBox.Name = "ExportTXTCheckBox";
            this.ExportTXTCheckBox.Size = new System.Drawing.Size(52, 25);
            this.ExportTXTCheckBox.TabIndex = 34;
            this.ExportTXTCheckBox.Text = "Text";
            this.ExportTXTCheckBox.UseVisualStyleBackColor = true;
            this.ExportTXTCheckBox.Click += new System.EventHandler(this.ExportTXTCheckBox_Click);
            // 
            // OpenDownloadsCheckBox
            // 
            this.OpenDownloadsCheckBox.AutoSize = true;
            this.OpenDownloadsCheckBox.FlatAppearance.BorderSize = 0;
            this.OpenDownloadsCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenDownloadsCheckBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenDownloadsCheckBox.ForeColor = System.Drawing.Color.White;
            this.OpenDownloadsCheckBox.Location = new System.Drawing.Point(15, 121);
            this.OpenDownloadsCheckBox.Name = "OpenDownloadsCheckBox";
            this.OpenDownloadsCheckBox.Size = new System.Drawing.Size(194, 25);
            this.OpenDownloadsCheckBox.TabIndex = 35;
            this.OpenDownloadsCheckBox.Text = "Open Downloads Folder";
            this.OpenDownloadsCheckBox.UseVisualStyleBackColor = true;
            // 
            // ExportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(315, 162);
            this.Controls.Add(this.OpenDownloadsCheckBox);
            this.Controls.Add(this.ExportCheckBoxGroup);
            this.Controls.Add(this.ExportExportButton);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExportForm";
            this.Text = "ExportForm";
            this.Load += new System.EventHandler(this.ExportForm_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.ExportCheckBoxGroup.ResumeLayout(false);
            this.ExportCheckBoxGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label PanelName;
        private System.Windows.Forms.Button PanelMinButton;
        private System.Windows.Forms.Button PanelCloseButton;
        private System.Windows.Forms.Button ExportExportButton;
        private System.Windows.Forms.CheckBox ExportCSVCheckBox;
        private System.Windows.Forms.GroupBox ExportCheckBoxGroup;
        private System.Windows.Forms.CheckBox ExportTXTCheckBox;
        private System.Windows.Forms.CheckBox OpenDownloadsCheckBox;
    }
}