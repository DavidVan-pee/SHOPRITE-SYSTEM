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
    public partial class ProductModuleForm : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\DAVID VANDERPUIJE\Documents\DBMS.mdf"";Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public ProductModuleForm()
        {
            InitializeComponent();
            LoadCategory();
        }

        public void LoadCategory()
        {
            comboCat.Items.Clear();
            cm = new SqlCommand("SELECT catname FROM tbCategory", conn);
            conn.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                comboCat.Items.Add(dr[0].ToString());
            }
            dr.Close();
            conn.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Are you sure you want to save this product?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                {
                    cm = new SqlCommand("INSERT INTO tbProduct(pname,pqty,pprice,pdescription,pcategory)VALUES(@pname, @pqty, @pprice, @pdescription, @pcategory)", conn);
                    cm.Parameters.AddWithValue("@pname", txtpname.Text);
                    cm.Parameters.AddWithValue("@pqty",Convert .ToInt16 (txtpqty.Text));
                    cm.Parameters.AddWithValue("@pprice",Convert.ToInt16 (txtpprice.Text));
                    cm.Parameters.AddWithValue("@pdescription", txtpdescription.Text);
                    cm.Parameters.AddWithValue("@pcategory", comboCat.Text);
                    conn.Open();
                    cm.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Product has been successfully saved");
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
            txtpname.Clear();
            txtpqty.Clear();
            txtpprice.Clear();
            txtpdescription.Clear();
            comboCat.Text = "";
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to update this product?", "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                {
                    cm = new SqlCommand("UPDATE tbProduct SET pname=@pname,pqty=@pqty,phone=@pprice,pdescription=@pdescription,pcategory@=pcategory WHERE pid LIKE '" + lblPd.Text + "' ", conn);
                    cm.Parameters.AddWithValue("@pname", txtpname.Text);
                    cm.Parameters.AddWithValue("@pqty", Convert.ToInt16(txtpqty.Text));
                    cm.Parameters.AddWithValue("@pprice", Convert.ToInt16(txtpprice.Text));
                    cm.Parameters.AddWithValue("@pdescription", txtpdescription.Text);
                    cm.Parameters.AddWithValue("@pcategory", comboCat.Text);

                    conn.Open();
                    cm.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Product has been successfully updated!");
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
