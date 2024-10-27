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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.Remoting.Contexts;
namespace BankManagement
{
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\HUY-PC\\source\\repos\\BankManagement\\BankManagement\\SystemBank.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            
            SqlCommand cnn = new SqlCommand("insert into customers values(@customer_id,@customer_name,@phone,@email,@address)", con);
            cnn.Parameters.AddWithValue("@Customer_ID", int.Parse(txtCustomerID.Text));
            cnn.Parameters.AddWithValue("@Customer_Name", txtCustomerName.Text);
            cnn.Parameters.AddWithValue("@Phone", txtPhone.Text);
            cnn.Parameters.AddWithValue("@Email", txtEmail.Text);
            cnn.Parameters.AddWithValue("@Address", txtAddress.Text);
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Saved Successfully!");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\HUY-PC\\source\\repos\\BankManagement\\BankManagement\\SystemBank.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cnn = new SqlCommand("select * from customers", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dgvCustomer.DataSource = table;

        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\HUY-PC\\source\\repos\\BankManagement\\BankManagement\\SystemBank.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cnn = new SqlCommand("update customers set customer_name=@customer_name,phone=@phone,email=@email,address=@address where customer_id=@customer_id", con);
            cnn.Parameters.AddWithValue("@Customer_ID", int.Parse(txtCustomerID.Text));
            cnn.Parameters.AddWithValue("@Customer_Name", txtCustomerName.Text);
            cnn.Parameters.AddWithValue("@Phone", txtPhone.Text);
            cnn.Parameters.AddWithValue("@Email", txtEmail.Text);
            cnn.Parameters.AddWithValue("@Address", txtAddress.Text);
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Updated Successfully!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\HUY-PC\\source\\repos\\BankManagement\\BankManagement\\SystemBank.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cnn = new SqlCommand("delete customers where customer_id=@customer_id", con);
            cnn.Parameters.AddWithValue("@Customer_ID", int.Parse(txtCustomerID.Text));
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Deleted Successfully!");
        }
        
        private void frmCustomer_Load(object sender, EventArgs e)
        {
            try
            {
                // Khởi tạo kết nối đến cơ sở dữ liệu
                SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\HUY-PC\\source\\repos\\BankManagement\\BankManagement\\SystemBank.mdf;Integrated Security=True;Connect Timeout=30");

                // Mở kết nối
                con.Open();

                // Tạo lệnh SQL để lấy dữ liệu từ bảng 'customers'
                SqlCommand cnn = new SqlCommand("SELECT * FROM customers", con);

                // Sử dụng SqlDataAdapter để điền dữ liệu vào DataTable
                SqlDataAdapter da = new SqlDataAdapter(cnn);
                DataTable table = new DataTable();
                da.Fill(table);

                // Gán DataTable cho DataGridView
                dgvCustomer.DataSource = table;

                // Đóng kết nối
                con.Close();
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        
        private void txtCustomerID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtCustomerName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtPhone_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtEmail_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtAddress_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }
    }
}
