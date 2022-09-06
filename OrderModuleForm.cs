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
    public partial class OrderModuleForm : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\DAVID VANDERPUIJE\Documents\DBMS.mdf"";Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public OrderModuleForm()
        {
            InitializeComponent();
            LoadCustomer();
            LoadProduct();
        }

        private void text2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
            
        }
        public void LoadCustomer()
        {
            int i = 0;
            dataGridViewCustomer.Rows.Clear();
            cm = new SqlCommand("SELECT cid,cname FROM tbCustomer WHERE CONCAT(cid,cname) LIKE'%"+txtSearchCus.Text+"%'", conn);
            conn.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridViewCustomer.Rows.Add(i, dr[0].ToString(), dr[1].ToString());

            }
            dr.Close();
            conn.Close();

        }

        public void LoadProduct()
        {
            int i = 0;
            dataGridViewProduct.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM tbProduct WHERE CONCAT(pid,pname,pprice,pdescription,pcategory) LIKE'%"+txtSearchProd.Text+"%'", conn);
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
        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            LoadProduct();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtSearchCus_TextChanged(object sender, EventArgs e)
        {
            LoadCustomer();
        }
    }
}
