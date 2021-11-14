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
    public partial class OrdersForm : Form
    {
        public OrdersForm()
        {
            InitializeComponent();
        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {
            LoadBills();
        }

        private void LoadBills()
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=RestaurantManagement;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Bills WHERE CheckoutDate = @checkoutDate";

            cmd.Parameters.Add("@checkoutDate", SqlDbType.SmallDateTime);
            cmd.Parameters["@checkoutDate"].Value = DateTime.Parse(dtpDate.Value.ToString("MM/dd/yyyy"));

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable BillsTable = new DataTable();

            conn.Open();
            adapter.Fill(BillsTable);
            conn.Close();
            conn.Dispose();

            dgv_bills.DataSource = BillsTable;
            SetTitles();

        }

        private void SetTitles()
        {
            dgv_bills.Columns[0].HeaderText = "Mã hóa đơn";
            dgv_bills.Columns[1].HeaderText = "Tên hóa đơn";
            dgv_bills.Columns[2].HeaderText = "Mã bàn";
            dgv_bills.Columns[3].HeaderText = "Trị giá hóa đơn";
            dgv_bills.Columns[4].HeaderText = "Giảm giá %";
            dgv_bills.Columns[5].HeaderText = "Thuế";
            dgv_bills.Columns[6].HeaderText = "Đã thanh toán";
            dgv_bills.Columns[7].HeaderText = "Ngày thanh toán";
            dgv_bills.Columns[8].HeaderText = "Tên tài khoản";
        }

            private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            LoadBills();
            CalAmountSummary();
        }

        private void dgv_bills_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_bills.SelectedRows.Count > 0)
            {
                BillDetailForm billDetail = new BillDetailForm();
                billDetail.Show();
                billDetail.LoadFoods(int.Parse(dgv_bills.SelectedRows[0].Cells[0].Value.ToString()));
            }
        }

        private void CalAmountSummary()
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=RestaurantManagement;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT @numSummary = SUM(Amount) FROM Bills WHERE " +
                " CheckoutDate=@checkoutDate";

            cmd.Parameters.Add("@numSummary", SqlDbType.Int);
            cmd.Parameters["@numSummary"].Direction = ParameterDirection.Output;

            cmd.Parameters.Add("@checkoutDate", SqlDbType.SmallDateTime);
            cmd.Parameters["@checkoutDate"].Value = DateTime.Parse(dtpDate.Value.ToString("MM/dd/yyyy"));


            conn.Open();
            cmd.ExecuteNonQuery();
            int summary = 0;
            for(int i = 0; i < dgv_bills.Rows.Count-1; i++)
            {
                summary += int.Parse(dgv_bills.Rows[i].Cells["Amount"].Value.ToString());
            }
            if (string.IsNullOrWhiteSpace(summary.ToString()))
                summary = 0;
            tsrSummary.Text = "Tổng doanh thu trong ngày là: " + summary + "VNĐ";
            conn.Close();
            conn.Dispose();
        }

        private void tsrSummary_Click(object sender, EventArgs e)
        {

        }
    }
}
