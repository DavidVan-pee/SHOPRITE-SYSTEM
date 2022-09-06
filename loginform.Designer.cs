namespace my_new_project
{
    partial class loginform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginform));
            this.panel1 = new System.Windows.Forms.Panel();
            this.textspace = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textpass2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBoxpass = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.clearpass = new System.Windows.Forms.Label();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(86, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(193, 82);
            this.panel1.TabIndex = 0;
            // 
            // textspace
            // 
            this.textspace.Location = new System.Drawing.Point(114, 228);
            this.textspace.Name = "textspace";
            this.textspace.Size = new System.Drawing.Size(215, 20);
            this.textspace.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(2, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "User Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password :";
            // 
            // textpass2
            // 
            this.textpass2.Location = new System.Drawing.Point(114, 313);
            this.textpass2.Name = "textpass2";
            this.textpass2.Size = new System.Drawing.Size(215, 20);
            this.textpass2.TabIndex = 3;
            this.textpass2.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Firebrick;
            this.button1.Location = new System.Drawing.Point(37, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(278, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "LOGIN";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // checkBoxpass
            // 
            this.checkBoxpass.AutoSize = true;
            this.checkBoxpass.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxpass.ForeColor = System.Drawing.Color.Transparent;
            this.checkBoxpass.Location = new System.Drawing.Point(222, 458);
            this.checkBoxpass.Name = "checkBoxpass";
            this.checkBoxpass.Size = new System.Drawing.Size(131, 27);
            this.checkBoxpass.TabIndex = 6;
            this.checkBoxpass.Text = "Show Password";
            this.checkBoxpass.UseVisualStyleBackColor = true;
            this.checkBoxpass.CheckedChanged += new System.EventHandler(this.checkBoxpass_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(4, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(349, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "Welcome to Shoprite Management System";
            // 
            // clearpass
            // 
            this.clearpass.AutoSize = true;
            this.clearpass.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearpass.ForeColor = System.Drawing.Color.Transparent;
            this.clearpass.Location = new System.Drawing.Point(12, 458);
            this.clearpass.Name = "clearpass";
            this.clearpass.Size = new System.Drawing.Size(51, 26);
            this.clearpass.TabIndex = 8;
            this.clearpass.Text = "Clear";
            this.clearpass.Click += new System.EventHandler(this.clearpass_Click);
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.BackgroundImage")));
            this.pictureBoxClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxClose.Location = new System.Drawing.Point(311, -2);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(51, 50);
            this.pictureBoxClose.TabIndex = 9;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // loginform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(362, 528);
            this.Controls.Add(this.pictureBoxClose);
            this.Controls.Add(this.clearpass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBoxpass);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textpass2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textspace);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "loginform";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textspace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textpass2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBoxpass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label clearpass;
        private System.Windows.Forms.PictureBox pictureBoxClose;
    }
}

