namespace my_new_project
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCategories = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUser = new my_new_project.CustomerButton();
            this.btnOrder = new my_new_project.CustomerButton();
            this.btnCustomer = new my_new_project.CustomerButton();
            this.btnProduct = new my_new_project.CustomerButton();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnCategories);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnUser);
            this.panel1.Controls.Add(this.btnOrder);
            this.panel1.Controls.Add(this.btnCustomer);
            this.panel1.Controls.Add(this.btnProduct);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(976, 87);
            this.panel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(677, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 21);
            this.label6.TabIndex = 17;
            this.label6.Text = "Categories";
            // 
            // btnCategories
            // 
            this.btnCategories.Image = ((System.Drawing.Image)(resources.GetObject("btnCategories.Image")));
            this.btnCategories.Location = new System.Drawing.Point(754, 56);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Size = new System.Drawing.Size(67, 31);
            this.btnCategories.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCategories.TabIndex = 16;
            this.btnCategories.TabStop = false;
            this.btnCategories.Click += new System.EventHandler(this.btnCategories_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(561, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 23);
            this.label5.TabIndex = 15;
            this.label5.Text = "Users";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(425, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 23);
            this.label4.TabIndex = 14;
            this.label4.Text = "Orders";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(257, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Customers";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(118, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Products";
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnUser.Image = ((System.Drawing.Image)(resources.GetObject("btnUser.Image")));
            this.btnUser.ImageHover = null;
            this.btnUser.ImageNormal = null;
            this.btnUser.Location = new System.Drawing.Point(613, 59);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(43, 28);
            this.btnUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnUser.TabIndex = 11;
            this.btnUser.TabStop = false;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnOrder.Image = ((System.Drawing.Image)(resources.GetObject("btnOrder.Image")));
            this.btnOrder.ImageHover = null;
            this.btnOrder.ImageNormal = null;
            this.btnOrder.Location = new System.Drawing.Point(477, 59);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(43, 28);
            this.btnOrder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnOrder.TabIndex = 10;
            this.btnOrder.TabStop = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomer.Image")));
            this.btnCustomer.ImageHover = null;
            this.btnCustomer.ImageNormal = null;
            this.btnCustomer.Location = new System.Drawing.Point(342, 56);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(43, 28);
            this.btnCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCustomer.TabIndex = 9;
            this.btnCustomer.TabStop = false;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.BackColor = System.Drawing.Color.DimGray;
            this.btnProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnProduct.Image")));
            this.btnProduct.ImageHover = null;
            this.btnProduct.ImageNormal = null;
            this.btnProduct.Location = new System.Drawing.Point(190, 56);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(43, 28);
            this.btnProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnProduct.TabIndex = 0;
            this.btnProduct.TabStop = false;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(229, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(409, 28);
            this.label3.TabIndex = 8;
            this.label3.Text = "SHOPRITE INVENTORY MANAGEMENT SYSTEM";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 413);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(976, 54);
            this.panel2.TabIndex = 1;
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 87);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(976, 326);
            this.panelMain.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 467);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label label3;
        private CustomerButton btnProduct;
        private System.Windows.Forms.Label label1;
        private CustomerButton btnUser;
        private CustomerButton btnOrder;
        private CustomerButton btnCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox btnCategories;
    }
}