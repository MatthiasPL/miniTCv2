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
            this.buttonNewFolder = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonMove = new System.Windows.Forms.Button();
            this.buttonCopy = new System.Windows.Forms.Button();
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
            this.splitContainer1.Size = new System.Drawing.Size(558, 306);
            this.splitContainer1.SplitterDistance = 279;
            this.splitContainer1.TabIndex = 2;
            // 
            // userPanelLeft
            // 
            this.userPanelLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userPanelLeft.FolderName = null;
            this.userPanelLeft.FoldersToPrint = null;
            this.userPanelLeft.IDCurrentDrive = -1;
            this.userPanelLeft.Location = new System.Drawing.Point(3, 6);
            this.userPanelLeft.Name = "userPanelLeft";
            this.userPanelLeft.Path = "";
            this.userPanelLeft.Size = new System.Drawing.Size(279, 293);
            this.userPanelLeft.TabIndex = 0;
            this.userPanelLeft.Enter += new System.EventHandler(this.userPanelLeft_Enter);
            // 
            // userPanelRight
            // 
            this.userPanelRight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userPanelRight.FolderName = null;
            this.userPanelRight.FoldersToPrint = null;
            this.userPanelRight.IDCurrentDrive = -1;
            this.userPanelRight.Location = new System.Drawing.Point(3, 3);
            this.userPanelRight.Name = "userPanelRight";
            this.userPanelRight.Path = "";
            this.userPanelRight.Size = new System.Drawing.Size(272, 296);
            this.userPanelRight.TabIndex = 1;
            this.userPanelRight.Enter += new System.EventHandler(this.userPanelRight_Enter);
            // 
            // buttonNewFolder
            // 
            this.buttonNewFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNewFolder.AutoSize = true;
            this.buttonNewFolder.Location = new System.Drawing.Point(2, 324);
            this.buttonNewFolder.Name = "buttonNewFolder";
            this.buttonNewFolder.Size = new System.Drawing.Size(139, 23);
            this.buttonNewFolder.TabIndex = 3;
            this.buttonNewFolder.TabStop = false;
            this.buttonNewFolder.Text = "New Folder";
            this.buttonNewFolder.UseVisualStyleBackColor = true;
            this.buttonNewFolder.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRemove.AutoSize = true;
            this.buttonRemove.Location = new System.Drawing.Point(152, 324);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(139, 23);
            this.buttonRemove.TabIndex = 4;
            this.buttonRemove.TabStop = false;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonMove
            // 
            this.buttonMove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMove.AutoSize = true;
            this.buttonMove.Location = new System.Drawing.Point(439, 324);
            this.buttonMove.Name = "buttonMove";
            this.buttonMove.Size = new System.Drawing.Size(136, 23);
            this.buttonMove.TabIndex = 6;
            this.buttonMove.TabStop = false;
            this.buttonMove.Text = "Move";
            this.buttonMove.UseVisualStyleBackColor = true;
            // 
            // buttonCopy
            // 
            this.buttonCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCopy.AutoSize = true;
            this.buttonCopy.Location = new System.Drawing.Point(297, 324);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(136, 23);
            this.buttonCopy.TabIndex = 5;
            this.buttonCopy.TabStop = false;
            this.buttonCopy.Text = "Copy";
            this.buttonCopy.UseVisualStyleBackColor = true;
            // 
            // MiniTC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 359);
            this.Controls.Add(this.buttonMove);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.buttonNewFolder);
            this.MinimumSize = new System.Drawing.Size(300, 200);
            this.Name = "MiniTC";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public UserPanel userPanelLeft;
        public UserPanel userPanelRight;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button buttonNewFolder;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Button buttonMove;
    }
}

