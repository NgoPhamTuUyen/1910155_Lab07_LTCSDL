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

namespace Lab7_Advanced_Command
{
    public partial class BillDetailForm : Form
    {
        public BillDetailForm()
        {
            InitializeComponent();
        }

        private void BillDetailForm_Load(object sender, EventArgs e)
        {

        }
        public void LoadFoods(int billID)
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=RestaurantManagement;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            string query = "exec GetFoodFromBill @BillID";
            sqlCommand.CommandText = query;

            sqlCommand.Parameters.Add("@BillID", SqlDbType.Int).Value = billID;
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            dgvBillDetails.DataSource = dt;

            dgvBillDetails.Columns[0].HeaderText = "Mã số";
            dgvBillDetails.Columns[1].HeaderText = "Tên món ăn";
            dgvBillDetails.Columns[2].HeaderText = "Đơn vị";
            dgvBillDetails.Columns[3].HeaderText = "Mô tả";
            dgvBillDetails.Columns[4].HeaderText = "Đơn giá";
            dgvBillDetails.Columns[5].HeaderText = "Số lượng";

            sqlConnection.Close();
            sqlConnection.Dispose();
            this.Text = "Danh Sách món ăn của bill số: " + billID;
        }
    }
}
