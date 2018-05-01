namespace miniTCMVP
{
    partial class MiniTC
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.userPanelLeft = new miniTCMVP.UserPanel();
            this.userPanelRight = new miniTCMVP.UserPanel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.userPanelLeft);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.userPanelRight);
            this.splitContainer1.Size = new System.Drawing.Size(560, 337);
            this.splitContainer1.SplitterDistance = 272;
            this.splitContainer1.TabIndex = 2;
            // 
            // userPanelLeft
            // 
            this.userPanelLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userPanelLeft.IDCurrentDrive = -1;
            this.userPanelLeft.Location = new System.Drawing.Point(3, 3);
            this.userPanelLeft.Name = "userPanelLeft";
            this.userPanelLeft.Path = "";
            this.userPanelLeft.Size = new System.Drawing.Size(266, 334);
            this.userPanelLeft.TabIndex = 0;
            // 
            // userPanelRight
            // 
            this.userPanelRight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userPanelRight.IDCurrentDrive = -1;
            this.userPanelRight.Location = new System.Drawing.Point(3, 3);
            this.userPanelRight.Name = "userPanelRight";
            this.userPanelRight.Path = "";
            this.userPanelRight.Size = new System.Drawing.Size(278, 331);
            this.userPanelRight.TabIndex = 1;
            // 
            // MiniTC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(300, 200);
            this.Name = "MiniTC";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UserPanel userPanelLeft;
        private UserPanel userPanelRight;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}

