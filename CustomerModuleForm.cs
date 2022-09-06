using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace my_new_project
{
    public partial class CustomerModuleForm : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\DAVID VANDERPUIJE\Documents\DBMS.mdf"";Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        public CustomerModuleForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Are you sure you want to save this customer?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                {
                    cm = new SqlCommand("INSERT INTO tbCustomer(cname,cphone)VALUES(@cname,@cphone)", conn);
                    cm.Parameters.AddWithValue("@cname",txtCName.Text);
                    cm.Parameters.AddWithValue("@cphone",txtCphone.Text);
                    conn.Open();
                    cm.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("User has been successfully saved");

                }




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Clear()
        {
            txtCName.Clear();
            txtCphone.Clear();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }

        private void CustomerModuleForm_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtusername_Click(object sender, EventArgs e)
        {

        }

        private void txtCName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtphone_Click(object sender, EventArgs e)
        {

        }

        private void txtCphone_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblcld_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to update this Customer?", "Update Record", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("UPDATE tbCustomer SET cname = @cname,cphone=@cphone WHERE cid LIKE '" + lblcld.Text + "'",conn);
                    cm.Parameters.AddWithValue("@cname",txtCName.Text);
                    cm.Parameters.AddWithValue("@cphone", txtCphone.Text);
                    conn.Open();
                    cm.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Customer has been updated");
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
