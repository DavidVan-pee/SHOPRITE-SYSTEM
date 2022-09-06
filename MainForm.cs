using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace my_new_project
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            openChildForm(new UserForm());
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            openChildForm(new Customer_Form());
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            openChildForm(new Categoryform());
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            openChildForm(new Productform());
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            openChildForm(new OrderForm());
        }
    }
}
