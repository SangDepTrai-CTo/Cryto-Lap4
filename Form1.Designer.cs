namespace WindowsFormsApp1
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
            this.MD5text = new System.Windows.Forms.TextBox();
            this.SHA1text = new System.Windows.Forms.TextBox();
            this.SHA256text = new System.Windows.Forms.TextBox();
            this.SHA384text = new System.Windows.Forms.TextBox();
            this.SHA512text = new System.Windows.Forms.TextBox();
            this.InPuttext = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SHA3512text = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ListBoxtire = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // MD5text
            // 
            this.MD5text.Location = new System.Drawing.Point(201, 112);
            this.MD5text.Name = "MD5text";
            this.MD5text.Size = new System.Drawing.Size(561, 20);
            this.MD5text.TabIndex = 0;
            // 
            // SHA1text
            // 
            this.SHA1text.Location = new System.Drawing.Point(201, 159);
            this.SHA1text.Name = "SHA1text";
            this.SHA1text.Size = new System.Drawing.Size(561, 20);
            this.SHA1text.TabIndex = 0;
            // 
            // SHA256text
            // 
            this.SHA256text.Location = new System.Drawing.Point(201, 207);
            this.SHA256text.Name = "SHA256text";
            this.SHA256text.Size = new System.Drawing.Size(561, 20);
            this.SHA256text.TabIndex = 0;
            // 
            // SHA384text
            // 
            this.SHA384text.Location = new System.Drawing.Point(201, 263);
            this.SHA384text.Name = "SHA384text";
            this.SHA384text.Size = new System.Drawing.Size(561, 20);
            this.SHA384text.TabIndex = 0;
            // 
            // SHA512text
            // 
            this.SHA512text.Location = new System.Drawing.Point(201, 314);
            this.SHA512text.Name = "SHA512text";
            this.SHA512text.Size = new System.Drawing.Size(561, 20);
            this.SHA512text.TabIndex = 0;
            // 
            // InPuttext
            // 
            this.InPuttext.Location = new System.Drawing.Point(326, 57);
            this.InPuttext.Name = "InPuttext";
            this.InPuttext.Size = new System.Drawing.Size(317, 20);
            this.InPuttext.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(666, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "MD5";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "SHA1";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "SHA-256";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "SHA-384";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "SHA-512";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // SHA3512text
            // 
            this.SHA3512text.Location = new System.Drawing.Point(201, 367);
            this.SHA3512text.Name = "SHA3512text";
            this.SHA3512text.Size = new System.Drawing.Size(561, 20);
            this.SHA3512text.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(89, 370);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "SHA3-512";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // ListBoxtire
            // 
            this.ListBoxtire.FormattingEnabled = true;
            this.ListBoxtire.Items.AddRange(new object[] {
            "TEXT String",
            "HEX String",
            "FILE"});
            this.ListBoxtire.Location = new System.Drawing.Point(84, 52);
            this.ListBoxtire.Name = "ListBoxtire";
            this.ListBoxtire.Size = new System.Drawing.Size(138, 17);
            this.ListBoxtire.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListBoxtire);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SHA3512text);
            this.Controls.Add(this.SHA512text);
            this.Controls.Add(this.SHA384text);
            this.Controls.Add(this.SHA256text);
            this.Controls.Add(this.SHA1text);
            this.Controls.Add(this.InPuttext);
            this.Controls.Add(this.MD5text);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MD5text;
        private System.Windows.Forms.TextBox SHA1text;
        private System.Windows.Forms.TextBox SHA256text;
        private System.Windows.Forms.TextBox SHA384text;
        private System.Windows.Forms.TextBox SHA512text;
        private System.Windows.Forms.TextBox InPuttext;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SHA3512text;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox ListBoxtire;
    }
}

