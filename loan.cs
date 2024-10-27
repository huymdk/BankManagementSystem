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
    public partial class loan : Form
    {
        public loan()
        {
            InitializeComponent();
        }

        private void loan_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\HUY-PC\\source\\repos\\BankManagement\\BankManagement\\SystemBank.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cnn = new SqlCommand("select * from loans", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dgvLoan.DataSource = table;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\HUY-PC\\source\\repos\\BankManagement\\BankManagement\\SystemBank.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cnn = new SqlCommand("insert into loans values(@loan_id,@loan_type, @amount,@interest_rate,@loan_date,@customer_name)", con);
            cnn.Parameters.AddWithValue("@Loan_ID", int.Parse(txtLoanID.Text));
            cnn.Parameters.AddWithValue("@Loan_Type", txtLoanType.Text);
            cnn.Parameters.AddWithValue("@Amount", txtAmount.Text);
            cnn.Parameters.AddWithValue("@Interest_rate", txtInterestRate.Text);
            cnn.Parameters.AddWithValue("@Loan_Date", dtpLoanDate.Value);
            cnn.Parameters.AddWithValue("@Customer_Name", txtCustomerName.Text);
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Saved Successfully!");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\HUY-PC\\source\\repos\\BankManagement\\BankManagement\\SystemBank.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cnn = new SqlCommand("select * from loans", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dgvLoan.DataSource = table;
        }

        private void dtpLoanDate_ValueChanged(object sender, EventArgs e)
        {
            dtpLoanDate.CustomFormat = "dd/mm/yy";
        }

        private void dtpLoanDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                dtpLoanDate.CustomFormat = "";
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\HUY-PC\\source\\repos\\BankManagement\\BankManagement\\SystemBank.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cnn = new SqlCommand("update loans set loan_id=@loan_id,loan_type=@loan_type, amount=@amount,interest_rate=@interest_rate,loan_date=@loan_date,customer_name=@customer_name", con);
            cnn.Parameters.AddWithValue("@Loan_ID", int.Parse(txtLoanID.Text));
            cnn.Parameters.AddWithValue("@Loan_Type", txtLoanType.Text);
            cnn.Parameters.AddWithValue("@Amount", txtAmount.Text);
            cnn.Parameters.AddWithValue("@Interest_rate", txtInterestRate.Text);
            cnn.Parameters.AddWithValue("@Loan_Date", dtpLoanDate.Value);
            cnn.Parameters.AddWithValue("@Customer_Name", txtCustomerName.Text);
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Update Successfully!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\HUY-PC\\source\\repos\\BankManagement\\BankManagement\\SystemBank.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cnn = new SqlCommand("delete loans where loan_id=@loan_id", con);
            cnn.Parameters.AddWithValue("@Loan_ID", int.Parse(txtLoanID.Text));
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Delete Successfully!");
        }

        private void txtLoanID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtLoanType_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtAmount_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtInterestRate_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtCustomerName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }
    }
}
