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
namespace BankManagement
{
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\HUY-PC\\source\\repos\\BankManagement\\BankManagement\\SystemBank.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cnn = new SqlCommand("insert into accounts values(@account_id,@account_type, @balance,@date_opened,@customer_name)", con);
            cnn.Parameters.AddWithValue("@Account_ID", int.Parse(txtAccountID.Text));
            cnn.Parameters.AddWithValue("@Account_Type", txtAccountType.Text);
            cnn.Parameters.AddWithValue("@Balance", txtBalance.Text);
            cnn.Parameters.AddWithValue("@Date_Opened", dtpDateOpened.Value);
            cnn.Parameters.AddWithValue("@Customer_Name", txtCustomerName.Text);
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Saved Successfully!");
        }

        private void dtpDateOpened_ValueChanged(object sender, EventArgs e)
        {
            dtpDateOpened.CustomFormat = "dd/mm/yy";
        }

        private void dtpDateOpened_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back) 
            {
                dtpDateOpened.CustomFormat ="";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\HUY-PC\\source\\repos\\BankManagement\\BankManagement\\SystemBank.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cnn = new SqlCommand("select * from accounts", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dgvAccount.DataSource = table;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\HUY-PC\\source\\repos\\BankManagement\\BankManagement\\SystemBank.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cnn = new SqlCommand("update accounts set account_type=@account_type,balance=@balance,date_opened=@date_opened,customer_name=@customer_name where account_id=@account_id", con);
            cnn.Parameters.AddWithValue("@Account_ID", int.Parse(txtAccountID.Text));
            cnn.Parameters.AddWithValue("@Account_Type", txtAccountType.Text);
            cnn.Parameters.AddWithValue("@Balance", txtBalance.Text);
            cnn.Parameters.AddWithValue("@Date_Opened", dtpDateOpened.Value);
            cnn.Parameters.AddWithValue("@Customer_Name", txtCustomerName.Text);
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Updated Successfully!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\HUY-PC\\source\\repos\\BankManagement\\BankManagement\\SystemBank.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cnn = new SqlCommand("delete accounts where account_id=@account_id", con);
            cnn.Parameters.AddWithValue("@Account_ID", int.Parse(txtAccountID.Text));
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record delete Successfully!");
        }

        private void Account_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\HUY-PC\\source\\repos\\BankManagement\\BankManagement\\SystemBank.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cnn = new SqlCommand("select * from accounts", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dgvAccount.DataSource = table;
        }

        private void txtAccountID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtAccountType_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtBalance_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtCustomerName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

       

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\HUY-PC\\source\\repos\\BankManagement\\BankManagement\\SystemBank.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            // SqlCommand cnn = new SqlCommand("select * from accounts where customer_name=@customer_name", con);
            SqlCommand cnn = new SqlCommand("SELECT * FROM accounts WHERE LOWER(customer_name) LIKE '%' + LOWER(@customer_name) + '%'", con);
            cnn.Parameters.AddWithValue("@Customer_Name", txtCustomerName.Text);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            con.Close();
            dgvAccount.DataSource = table;
            


            /*
            try
            {
                // Kiểm tra xem textbox có rỗng hay không
                if (string.IsNullOrEmpty(txtAccountID.Text))
                {
                    MessageBox.Show("Vui lòng nhập ID tài khoản.");
                    return;
                }

                // Chuyển đổi giá trị trong textbox thành số nguyên
                int accountId;
                if (!int.TryParse(txtAccountID.Text, out accountId))
                {
                    MessageBox.Show("ID tài khoản phải là một số nguyên.");
                    return;
                }

                // Kết nối đến cơ sở dữ liệu
                using (SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\HUY-PC\\source\\repos\\BankManagement\\BankManagement\\SystemBank.mdf;Integrated Security=True;Connect Timeout=30"))
                {
                    con.Open();

                    // Tạo câu lệnh SQL
                    SqlCommand cmd = new SqlCommand("SELECT * FROM accounts WHERE account_id = @accountId", con);
                    cmd.Parameters.AddWithValue("@accountId", accountId);

                    // Thực thi câu lệnh SQL và lấy kết quả
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Hiển thị kết quả lên các textbox hoặc DataGridView
                            txtAccountType.Text = reader["account_type"].ToString();
                            txtBalance.Text = reader["balance"].ToString();
                            // ... các textbox khác
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy tài khoản có ID này.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra: " + ex.Message);
            }
            */
        }
    }
}
