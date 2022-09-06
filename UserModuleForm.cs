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
    public partial class UserModuleForm : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\DAVID VANDERPUIJE\Documents\DBMS.mdf"";Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        public UserModuleForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxClose_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (MessageBox.Show("Are you sure you want to save this user?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                {
                    cm = new SqlCommand("INSERT INTO tbUser(username,fullname,password,phone)VALUES(@username,@fullname,@password,@phone)", conn);
                    cm.Parameters.AddWithValue("@username", text1.Text);
                    cm.Parameters.AddWithValue("@fullname", text2.Text);
                    cm.Parameters.AddWithValue("@password", text3.Text);
                    cm.Parameters.AddWithValue("@phone", text4.Text);
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

        private void btnClear_Click(object sender, EventArgs e)
        {
           
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;

        }
        
      
        private void btnUpdate_Click(object sender, EventArgs e)
        {

            try
            {
                if (MessageBox.Show("Are you sure you want to update this user?", "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                {
                    cm = new SqlCommand("UPDATE tbUser SET fullname  =@fullname,password=@password,phone=@phone WHERE username LIKE '"+text1.Text+"' ", conn);
                    cm.Parameters.AddWithValue("@fullname", text2.Text);
                    cm.Parameters.AddWithValue("@password", text3.Text);
                    cm.Parameters.AddWithValue("@phone", text4.Text);
                    conn.Open();
                    cm.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("User has been successfully updated!");
                    this.Dispose();

                }




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserModuleForm_Load(object sender, EventArgs e)
        {

        }
    }
}
