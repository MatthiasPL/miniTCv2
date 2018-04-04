namespace miniTCv2
{
    partial class MiniTCView
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
            this.listBoxContainer = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBoxPath
            // 
            this.textBoxPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPath.Location = new System.Drawing.Point(47, 3);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(100, 20);
            this.textBoxPath.TabIndex = 0;
            // 
            // comboBoxDrives
            // 
            this.comboBoxDrives.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxDrives.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDrives.FormattingEnabled = true;
            this.comboBoxDrives.Location = new System.Drawing.Point(102, 29);
            this.comboBoxDrives.Name = "comboBoxDrives";
            this.comboBoxDrives.Size = new System.Drawing.Size(45, 21);
            this.comboBoxDrives.Sorted = true;
            this.comboBoxDrives.TabIndex = 1;
            this.comboBoxDrives.DropDown += new System.EventHandler(this.comboBoxDrives_DropDown);
            this.comboBoxDrives.SelectedIndexChanged += new System.EventHandler(this.comboBoxDrives_SelectedIndexChanged);
            // 
            // listBoxContainer
            // 
            this.listBoxContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxContainer.FormattingEnabled = true;
            this.listBoxContainer.Location = new System.Drawing.Point(4, 57);
            this.listBoxContainer.Name = "listBoxContainer";
            this.listBoxContainer.Size = new System.Drawing.Size(143, 121);
            this.listBoxContainer.TabIndex = 2;
            // 
            // MiniTCView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.listBoxContainer);
            this.Controls.Add(this.comboBoxDrives);
            this.Controls.Add(this.textBoxPath);
            this.Name = "MiniTCView";
            this.Size = new System.Drawing.Size(150, 184);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.ComboBox comboBoxDrives;
        private System.Windows.Forms.ListBox listBoxContainer;
    }
}
