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
    public partial class UserForm : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\DAVID VANDERPUIJE\Documents\DBMS.mdf"";Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public UserForm()
        {
            InitializeComponent();
            LoadUser();

        }
        public void LoadUser()
        {
            int i = 0;
            dataGridViewUser.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM tbUser", conn);
            conn.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridViewUser.Rows.Add(i,dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString());

            }
            dr.Close();
            conn.Close();
          

        }

        private void UserForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridViewUser.Columns[e.ColumnIndex].Name;
            if(colName == "Edit")
            {
                UserModuleForm userModule = new UserModuleForm();
                userModule.text1.Text = dataGridViewUser.Rows[e.RowIndex].Cells[1].Value.ToString();
                userModule.text2.Text = dataGridViewUser.Rows[e.RowIndex].Cells[2].Value.ToString();
                userModule.text3.Text = dataGridViewUser.Rows[e.RowIndex].Cells[3].Value.ToString();
                userModule.text4.Text = dataGridViewUser.Rows[e.RowIndex].Cells[4].Value.ToString();

                userModule.btnSave.Enabled = false;
                userModule.btnUpdate.Enabled = true;
                userModule.text1.Enabled = false;
                userModule.ShowDialog();
            }
            
            else if (colName =="Delete")
            {
                if (MessageBox.Show("Are you sure you wan to delete this user?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    conn.Open();
                    cm = new SqlCommand("DELETE FROM tbUser WHERE username LIKE '" + dataGridViewUser.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", conn);
                    cm.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Record has been deleted successfully !");
                    

                }
            }
            LoadUser();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            UserModuleForm userModule = new UserModuleForm();
            userModule.btnSave.Enabled = true;
            userModule.btnUpdate.Enabled = false;
            userModule.ShowDialog();
            LoadUser();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
