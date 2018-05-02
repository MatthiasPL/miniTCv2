namespace miniTCMVP
{
    partial class UserPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.comboBoxDrives = new System.Windows.Forms.ComboBox();
            this.listBoxFolders = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxPath
            // 
            this.textBoxPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPath.Location = new System.Drawing.Point(41, 3);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(158, 20);
            this.textBoxPath.TabIndex = 0;
            this.textBoxPath.TextChanged += new System.EventHandler(this.textBoxPath_TextChanged);
            // 
            // comboBoxDrives
            // 
            this.comboBoxDrives.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDrives.FormattingEnabled = true;
            this.comboBoxDrives.Location = new System.Drawing.Point(124, 29);
            this.comboBoxDrives.Name = "comboBoxDrives";
            this.comboBoxDrives.Size = new System.Drawing.Size(75, 21);
            this.comboBoxDrives.TabIndex = 1;
            this.comboBoxDrives.DropDown += new System.EventHandler(this.comboBoxDrives_DropDown);
            this.comboBoxDrives.SelectedIndexChanged += new System.EventHandler(this.comboBoxDrives_SelectedIndexChanged);
            // 
            // listBoxFolders
            // 
            this.listBoxFolders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxFolders.FormattingEnabled = true;
            this.listBoxFolders.Location = new System.Drawing.Point(3, 56);
            this.listBoxFolders.Name = "listBoxFolders";
            this.listBoxFolders.Size = new System.Drawing.Size(196, 199);
            this.listBoxFolders.TabIndex = 2;
            this.listBoxFolders.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxFolders_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Path:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Drive:";
            // 
            // UserPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxFolders);
            this.Controls.Add(this.comboBoxDrives);
            this.Controls.Add(this.textBoxPath);
            this.Name = "UserPanel";
            this.Size = new System.Drawing.Size(202, 260);
            this.Load += new System.EventHandler(this.UserPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.ComboBox comboBoxDrives;
        private System.Windows.Forms.ListBox listBoxFolders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
