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
            this.userPanelLeft = new miniTCMVP.UserPanel();
            this.userPanelRight = new miniTCMVP.UserPanel();
            this.SuspendLayout();
            // 
            // userPanelLeft
            // 
            this.userPanelLeft.Location = new System.Drawing.Point(12, 12);
            this.userPanelLeft.Name = "userPanelLeft";
            this.userPanelLeft.Size = new System.Drawing.Size(202, 234);
            this.userPanelLeft.TabIndex = 0;
            // 
            // userPanelRight
            // 
            this.userPanelRight.Location = new System.Drawing.Point(260, 12);
            this.userPanelRight.Name = "userPanelRight";
            this.userPanelRight.Size = new System.Drawing.Size(202, 234);
            this.userPanelRight.TabIndex = 1;
            // 
            // MiniTC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 255);
            this.Controls.Add(this.userPanelRight);
            this.Controls.Add(this.userPanelLeft);
            this.Name = "MiniTC";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private UserPanel userPanelLeft;
        private UserPanel userPanelRight;
    }
}

