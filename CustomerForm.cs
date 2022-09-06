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
    public partial class Customer_Form : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\DAVID VANDERPUIJE\Documents\DBMS.mdf"";Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public Customer_Form()
        {
            InitializeComponent();
            LoadCustomer();
        }

        public void LoadCustomer()
        {
            int i = 0;
            dataGridViewCustomer.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM tbCustomer", conn);
            conn.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridViewCustomer.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString());

            }
            dr.Close();
            conn.Close();

        }

        private void customerButton1_Click(object sender, EventArgs e)
        {
            CustomerModuleForm moduleForm = new CustomerModuleForm();
            moduleForm.btnSave.Enabled = true;
            moduleForm.btnUpdate.Enabled = false;
            moduleForm.ShowDialog();
            LoadCustomer();
        }
        private void dataGridViewCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridViewCustomer.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")

            {
                CustomerModuleForm formModule = new CustomerModuleForm();
                formModule.lblcld.Text = dataGridViewCustomer.Rows[e.RowIndex].Cells[1].Value.ToString();
                formModule.txtCName.Text = dataGridViewCustomer.Rows[e.RowIndex].Cells[2].Value.ToString();
                formModule.txtCphone.Text = dataGridViewCustomer.Rows[e.RowIndex].Cells[3].Value.ToString();

                formModule.btnSave.Enabled = false;
                formModule.btnUpdate.Enabled = true;
                formModule.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this customer?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    conn.Open();
                    cm = new SqlCommand("DELETE FROM tbCategory WHERE cid LIKE '" + dataGridViewCustomer.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", conn);
                    cm.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Record is deleted successfully");
                }
            }
            LoadCustomer();
        }
    }
}

        

