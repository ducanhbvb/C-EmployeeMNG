using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataTest
{
    public partial class frmTestData : Form
    {
        public frmTestData()
        {
            InitializeComponent();
        }

        private void frmTestData_Load(object sender, EventArgs e)
        {
            grdDataList.DataSource = GetAllDataList();
            
        }

        private void splcMain_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splcMain_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //private void grdDataList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
            
        //}
        private DataTable GetAllDataList()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=DESKTOP-7R3NGKH;Initial Catalog=DataTest;Integrated Security=True";
            SqlCommand comman = new SqlCommand();
            comman.Connection = conn;
            comman.CommandText = "GetAllPeople";
            comman.CommandType = CommandType.StoredProcedure;
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(comman);
            adapter.Fill(data);
            return data;
        }
        private DataTable GetByIdBank()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=DESKTOP-7R3NGKH;Initial Catalog=DataTest;Integrated Security=True";
            SqlCommand comman = new SqlCommand();
            comman.Connection = conn;
            comman.CommandText = "GetByIdBank";
            comman.CommandType = CommandType.StoredProcedure;
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(comman);
            adapter.Fill(data);
            return data;
        }
        private DataSet GetID()
        {
            DataSet data = new DataSet();
            string query = @"SELECT Id
                                  , Code
                                  , Name
                                  , Branch
                              FROM AccountBank
                              WHERE IdPeople = @PeopleId;";
            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-7R3NGKH;Initial Catalog=DataTest;Integrated Security=True"))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);
                connection.Close();
                      }
            return data;
        }

        private void grdDataList_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {

        }

       

        private void txtBindingData_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void grdDataList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void grdDataList_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtBox2.Text = Convert.ToString(e.RowIndex);
            int idtxt = e.RowIndex;
            txtBox1.Text = Convert.ToString(grdDataList.Rows[idtxt].Cells[0].Value);
        }

        private void txtBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

     

        private void txtBox1_TextChanged_1(object sender, EventArgs e)
        {
            txtBox2.Text = txtBox1.Text;
        }

        private void txtBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Proceed code
                MessageBox.Show("Enter Key Pressed ");
            }
        }
    }
}
