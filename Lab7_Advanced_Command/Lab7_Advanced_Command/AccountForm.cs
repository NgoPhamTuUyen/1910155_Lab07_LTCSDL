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
    public partial class AccountForm : Form
    {
        string server = @"Data Source=.\SQLEXPRESS;Initial Catalog=RestaurantManagement;Integrated Security=True";
        SqlConnection conn;
        SqlCommand cmd;
        public AccountForm()
        {
            InitializeComponent();
            LoadAccount();
        }
        public void LoadAccount()
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=RestaurantManagement;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = connection.CreateCommand();

            command.CommandText = "SELECT * FROM Account";

            connection.Open();

            string categoryName = command.ExecuteScalar().ToString();
            this.Text = "Danh sách toàn bộ tài khoản";

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable("Food");
            adapter.Fill(table);

            dgvAccount.DataSource = table;

            // Prevent user to edit ID
            dgvAccount.Columns[0].ReadOnly = true;

            connection.Close();
        }

        private void loadform()
        {
            conn = new SqlConnection(server);
            cmd = conn.CreateCommand();
            cmd.CommandText = "select * from Account";
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("Account");
            adapter.Fill(dt);
            dgvAccount.DataSource = dt;
            conn.Close();
            conn.Dispose();
            adapter.Dispose();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            String connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=RestaurantManagement;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            var text = string.Format($"INSERT INTO Food (Name , Unit , FoodCategoryID , Price , Notes) VALUES (N'{txtAccount.Text}', N'{txtpassword.Text}', '{txthoten.Text}', '{txtemail.Text}', '{txtsdt.Text}','{dtpdatecreate.Text}')").ToString();
            sqlCommand.CommandText = text;

            sqlConnection.Open();
            int numOfRowsEffected = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            if (numOfRowsEffected != 1)
            {
                MessageBox.Show("Đã có lỗi xảy ra , vui lòng thử lại");
                return;
            }
            txtAccount.Text = "";
            txtpassword.Text = "";
            txthoten.Text = "";
            txtemail.Text = "";
            txtsdt.Text = "";
            dtpdatecreate.Text = "";
        }

        private void dgvAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvAccount.CurrentRow.Index;
            txtAccount.Text = dgvAccount.Rows[i].Cells[0].Value.ToString();
            txtpassword.Text = dgvAccount.Rows[i].Cells[1].Value.ToString();
            txthoten.Text = dgvAccount.Rows[i].Cells[2].Value.ToString();
            txtemail.Text = dgvAccount.Rows[i].Cells[3].Value.ToString();
            txtsdt.Text = dgvAccount.Rows[i].Cells[4].Value.ToString();
            if (dgvAccount.Rows[i].Cells[5].Value.ToString() == "")
            { dtpdatecreate.Value = DateTime.Now; }
            else { dtpdatecreate.Value = Convert.ToDateTime(dgvAccount.Rows[i].Cells[5].Value); }
        }

        private void AccountForm_Load(object sender, EventArgs e)
        {

        }

        private void tsmxemnhatky_Click(object sender, EventArgs e)
        {

        }

        private void tsmxemdanhsach_Click(object sender, EventArgs e)
        {
            
        }
    }
}
