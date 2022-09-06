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
    public partial class CategoryModelForm : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\DAVID VANDERPUIJE\Documents\DBMS.mdf"";Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public CategoryModelForm()
        {
            InitializeComponent();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Are you sure you want to save in this category?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                {
                    cm = new SqlCommand("INSERT INTO tbCategory(catname)VALUES(@catname)", conn);
                    cm.Parameters.AddWithValue("@catname", txtCatName.Text);

                    conn.Open();
                    cm.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Category has been successfully saved");
                    Clear();


                }




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

         

            public void Clear()
            {
                txtCatName.Clear();
            }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
            btnSave.Enabled = true;
            btnUpdate.Enabled = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to update this Category?", "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("UPDATE tbCategory SET catname = @catname WHERE catid LIKE '" + lblcatid.Text + "'", conn);
                    cm.Parameters.AddWithValue("@catname", txtCatName.Text);
                    
                    conn.Open();
                    cm.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Category has been updated");
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CategoryModelForm_Load(object sender, EventArgs e)
        {

        }

        private void lblcatid_Click(object sender, EventArgs e)
        {

        }
    }
    }
   
        
        

