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
    public partial class Categoryform : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\DAVID VANDERPUIJE\Documents\DBMS.mdf"";Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public Categoryform()
        {
            InitializeComponent();
            LoadCategory();
            
        }
        public void LoadCategory()
        {
            int i = 0;
            dataGridViewCategory.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM tbCategory", conn);
            conn.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridViewCategory.Rows.Add(i, dr[0].ToString(), dr[1].ToString());

            }
            dr.Close();
            conn.Close();

        }

        private void customerbutton1_Click(object sender, EventArgs e)
        {
            CategoryModelForm formModel = new CategoryModelForm();
            formModel.btnSave.Enabled = true;
            formModel.btnUpdate.Enabled = false;
            formModel.ShowDialog();
            LoadCategory();
            
        }

        private void dataGridViewCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridViewCategory.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")

            {
                CategoryModelForm formModel = new CategoryModelForm();
                formModel.lblcatid.Text= dataGridViewCategory.Rows[e.RowIndex].Cells[1].Value.ToString();
                formModel.txtCatName.Text = dataGridViewCategory.Rows[e.RowIndex].Cells[2].Value.ToString();

                formModel.btnSave.Enabled = false;
                formModel.btnUpdate.Enabled= true;
                formModel.ShowDialog();
            }
            else if (colName =="Delete")
            {
                if(MessageBox.Show("Are you sure you want to delete this category?","Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    conn.Open();
                    cm = new SqlCommand("DELETE FROM tbCategory WHERE catid LIKE '" + dataGridViewCategory.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", conn);
                    cm.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Record is deleted successfully");
                }
            }
            LoadCategory();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}


        

    

      

