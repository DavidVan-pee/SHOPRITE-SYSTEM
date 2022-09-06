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
    public partial class Productform : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\DAVID VANDERPUIJE\Documents\DBMS.mdf"";Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        private string colName;

        public Productform()
        {
            InitializeComponent();
            LoadProduct();
        }
        public void LoadProduct()
        {
            int i = 0;
            dataGridViewProduct.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM tbProduct", conn);
            conn.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridViewProduct.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());

            }
            dr.Close();
            conn.Close();


        }

        private void categorybutton1_Click(object sender, EventArgs e)
        {
            ProductModuleForm formModule = new ProductModuleForm();
            formModule.btnSave.Enabled = true;
            formModule.btnUpdate.Enabled = false;
            formModule.ShowDialog();
            LoadProduct();
            
        }

        private void  dataGridViewProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (colName == "Edit")

            {
                ProductModuleForm Productform = new ProductModuleForm();
                Productform.lblPd.Text = dataGridViewProduct.Rows[e.RowIndex].Cells[0].ToString();
                Productform.txtpname.Text = dataGridViewProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
                Productform.txtpqty.Text = dataGridViewProduct.Rows[e.RowIndex].Cells[2].Value.ToString();
                Productform.txtpprice.Text = dataGridViewProduct.Rows[e.RowIndex].Cells[3].Value.ToString();
                Productform.txtpdescription.Text = dataGridViewProduct.Rows[e.RowIndex].Cells[4].Value.ToString();
                Productform.comboCat.Text = dataGridViewProduct.Rows[e.RowIndex].Cells[5].Value.ToString();

                Productform.btnSave.Enabled = false;
                Productform.btnUpdate.Enabled = true;
                Productform.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this product?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    conn.Open();
                    cm = new SqlCommand("DELETE FROM tbProduct WHERE pid LIKE '" + dataGridViewProduct.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", conn);
                    conn.Close();
                    MessageBox.Show("Record has been successfully deleted");
                }
            }
            LoadProduct();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadProduct();
        }
    }
}
