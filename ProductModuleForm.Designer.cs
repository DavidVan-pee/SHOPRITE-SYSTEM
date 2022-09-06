using System;

namespace my_new_project
{
    partial class ProductModuleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductModuleForm));
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtpdescription = new System.Windows.Forms.TextBox();
            this.text4 = new System.Windows.Forms.Label();
            this.txtpprice = new System.Windows.Forms.TextBox();
            this.text3 = new System.Windows.Forms.Label();
            this.txtpqty = new System.Windows.Forms.TextBox();
            this.text2 = new System.Windows.Forms.Label();
            this.txtpname = new System.Windows.Forms.TextBox();
            this.text1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboCat = new System.Windows.Forms.ComboBox();
            this.lblPd = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(413, 343);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(78, 30);
            this.btnClear.TabIndex = 22;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Gold;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(332, 343);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 30);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DarkRed;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(246, 343);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 30);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtpdescription
            // 
            this.txtpdescription.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpdescription.Location = new System.Drawing.Point(197, 223);
            this.txtpdescription.Name = "txtpdescription";
            this.txtpdescription.Size = new System.Drawing.Size(284, 27);
            this.txtpdescription.TabIndex = 19;
            // 
            // text4
            // 
            this.text4.AutoSize = true;
            this.text4.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text4.Location = new System.Drawing.Point(67, 220);
            this.text4.Name = "text4";
            this.text4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.text4.Size = new System.Drawing.Size(88, 23);
            this.text4.TabIndex = 18;
            this.text4.Text = "Description:";
            // 
            // txtpprice
            // 
            this.txtpprice.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpprice.Location = new System.Drawing.Point(197, 176);
            this.txtpprice.Name = "txtpprice";
            this.txtpprice.Size = new System.Drawing.Size(284, 27);
            this.txtpprice.TabIndex = 17;
            // 
            // text3
            // 
            this.text3.AutoSize = true;
            this.text3.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text3.Location = new System.Drawing.Point(67, 176);
            this.text3.Name = "text3";
            this.text3.Size = new System.Drawing.Size(48, 23);
            this.text3.TabIndex = 16;
            this.text3.Text = "Price:";
            // 
            // txtpqty
            // 
            this.txtpqty.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpqty.Location = new System.Drawing.Point(197, 129);
            this.txtpqty.Name = "txtpqty";
            this.txtpqty.Size = new System.Drawing.Size(284, 27);
            this.txtpqty.TabIndex = 15;
            // 
            // text2
            // 
            this.text2.AutoSize = true;
            this.text2.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text2.Location = new System.Drawing.Point(67, 126);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(74, 23);
            this.text2.TabIndex = 14;
            this.text2.Text = "Quantity:";
            // 
            // txtpname
            // 
            this.txtpname.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpname.Location = new System.Drawing.Point(197, 82);
            this.txtpname.Name = "txtpname";
            this.txtpname.Size = new System.Drawing.Size(284, 27);
            this.txtpname.TabIndex = 13;
            // 
            // text1
            // 
            this.text1.AutoSize = true;
            this.text1.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text1.Location = new System.Drawing.Point(67, 79);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(110, 23);
            this.text1.TabIndex = 12;
            this.text1.Text = "Product Name:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Controls.Add(this.pictureBoxClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 35);
            this.panel1.TabIndex = 23;
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.BackgroundImage")));
            this.pictureBoxClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxClose.Location = new System.Drawing.Point(561, 0);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(39, 33);
            this.pictureBoxClose.TabIndex = 11;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product Module";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 267);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(73, 23);
            this.label2.TabIndex = 24;
            this.label2.Text = "Category:";
            // 
            // comboCat
            // 
            this.comboCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCat.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCat.FormattingEnabled = true;
            this.comboCat.Location = new System.Drawing.Point(197, 270);
            this.comboCat.Name = "comboCat";
            this.comboCat.Size = new System.Drawing.Size(284, 27);
            this.comboCat.TabIndex = 25;
            // 
            // lblPd
            // 
            this.lblPd.AutoSize = true;
            this.lblPd.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPd.Location = new System.Drawing.Point(68, 355);
            this.lblPd.Name = "lblPd";
            this.lblPd.Size = new System.Drawing.Size(89, 18);
            this.lblPd.TabIndex = 26;
            this.lblPd.Text = "Product id";
            this.lblPd.Visible = false;
            this.lblPd.Click += new System.EventHandler(this.lblPd_Click);
            // 
            // ProductModuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 391);
            this.Controls.Add(this.lblPd);
            this.Controls.Add(this.comboCat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtpdescription);
            this.Controls.Add(this.text4);
            this.Controls.Add(this.txtpprice);
            this.Controls.Add(this.text3);
            this.Controls.Add(this.txtpqty);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.txtpname);
            this.Controls.Add(this.text1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductModuleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductModuleForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.TextBox txtpdescription;
        public System.Windows.Forms.Label text4;
        public System.Windows.Forms.TextBox txtpprice;
        public System.Windows.Forms.Label text3;
        public System.Windows.Forms.Label text2;
        public System.Windows.Forms.TextBox txtpname;
        public System.Windows.Forms.Label text1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox comboCat;
        public System.Windows.Forms.TextBox txtpqty;
        public System.Windows.Forms.Label lblPd;
        private EventHandler lblPd_Click;
    }
}