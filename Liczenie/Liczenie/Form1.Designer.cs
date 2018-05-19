namespace Liczenie
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxLiczby = new System.Windows.Forms.TextBox();
            this.textBoxKwota = new System.Windows.Forms.TextBox();
            this.buttonLicz = new System.Windows.Forms.Button();
            this.labelKwoty = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxIle = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxLiczby
            // 
            this.textBoxLiczby.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLiczby.Location = new System.Drawing.Point(9, 52);
            this.textBoxLiczby.MaxLength = 214748364;
            this.textBoxLiczby.Multiline = true;
            this.textBoxLiczby.Name = "textBoxLiczby";
            this.textBoxLiczby.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxLiczby.Size = new System.Drawing.Size(218, 199);
            this.textBoxLiczby.TabIndex = 2;
            // 
            // textBoxKwota
            // 
            this.textBoxKwota.Location = new System.Drawing.Point(52, 13);
            this.textBoxKwota.Name = "textBoxKwota";
            this.textBoxKwota.Size = new System.Drawing.Size(121, 20);
            this.textBoxKwota.TabIndex = 3;
            // 
            // buttonLicz
            // 
            this.buttonLicz.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLicz.Location = new System.Drawing.Point(9, 257);
            this.buttonLicz.Name = "buttonLicz";
            this.buttonLicz.Size = new System.Drawing.Size(218, 23);
            this.buttonLicz.TabIndex = 4;
            this.buttonLicz.Text = "Licz";
            this.buttonLicz.UseVisualStyleBackColor = true;
            this.buttonLicz.Click += new System.EventHandler(this.buttonLicz_Click);
            // 
            // labelKwoty
            // 
            this.labelKwoty.AutoSize = true;
            this.labelKwoty.Location = new System.Drawing.Point(6, 0);
            this.labelKwoty.Name = "labelKwoty";
            this.labelKwoty.Size = new System.Drawing.Size(39, 13);
            this.labelKwoty.TabIndex = 5;
            this.labelKwoty.Text = "Kwoty:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Suma:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Kwoty na sumę:";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(6, 16);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(166, 270);
            this.textBox1.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.labelKwoty);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 289);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.comboBoxIle);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.buttonLicz);
            this.groupBox2.Controls.Add(this.textBoxLiczby);
            this.groupBox2.Controls.Add(this.textBoxKwota);
            this.groupBox2.Location = new System.Drawing.Point(196, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(233, 286);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // comboBoxIle
            // 
            this.comboBoxIle.AllowDrop = true;
            this.comboBoxIle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIle.FormattingEnabled = true;
            this.comboBoxIle.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.comboBoxIle.Location = new System.Drawing.Point(179, 13);
            this.comboBoxIle.Name = "comboBoxIle";
            this.comboBoxIle.Size = new System.Drawing.Size(48, 21);
            this.comboBoxIle.Sorted = true;
            this.comboBoxIle.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 308);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(408, 207);
            this.Name = "Form1";
            this.Text = "Suma";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxLiczby;
        private System.Windows.Forms.TextBox textBoxKwota;
        private System.Windows.Forms.Button buttonLicz;
        private System.Windows.Forms.Label labelKwoty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxIle;
    }
}

