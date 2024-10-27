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
namespace BankManagement
{
    public partial class transcaction : Form
    {
        public transcaction()
        {
            InitializeComponent();
        }

        private void transcaction_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\HUY-PC\\source\\repos\\BankManagement\\BankManagement\\SystemBank.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cnn = new SqlCommand("select * from transactions", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dgvTransaction.DataSource = table;
        }

        private void dtpTransactionDate_ValueChanged(object sender, EventArgs e)
        {
            dtpTransactionDate.CustomFormat = "dd/mm/yy";
        }

        private void dtpTransactionDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                dtpTransactionDate.CustomFormat = "";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\HUY-PC\\source\\repos\\BankManagement\\BankManagement\\SystemBank.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cnn = new SqlCommand("insert into transactions values(@tid,@transaction_type, @amount,@transaction_date,@account_id)", con);
            cnn.Parameters.AddWithValue("@TID", int.Parse(txtTID.Text));
            cnn.Parameters.AddWithValue("@Transaction_Type", txtTransactionType.Text);
            cnn.Parameters.AddWithValue("@Amount", txtAmount.Text);
            cnn.Parameters.AddWithValue("@Transaction_Date", dtpTransactionDate.Value);
            cnn.Parameters.AddWithValue("@Account_Id", txtAccountId.Text);
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Saved Successfully!");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\HUY-PC\\source\\repos\\BankManagement\\BankManagement\\SystemBank.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cnn = new SqlCommand("select * from transactions", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dgvTransaction.DataSource = table;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\HUY-PC\\source\\repos\\BankManagement\\BankManagement\\SystemBank.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cnn = new SqlCommand("update transactions set transaction_type=@transaction_type,amount=@amount, transaction_date=@transaction_date,account_id=@account_id where tid=@tid", con);
            cnn.Parameters.AddWithValue("@TID", int.Parse(txtTID.Text));
            cnn.Parameters.AddWithValue("@Transaction_Type", txtTransactionType.Text);
            cnn.Parameters.AddWithValue("@Amount", txtAmount.Text);
            cnn.Parameters.AddWithValue("@Transaction_Date", dtpTransactionDate.Value);
            cnn.Parameters.AddWithValue("@Account_Id", txtAccountId.Text);
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Updated Successfully!");
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\HUY-PC\\source\\repos\\BankManagement\\BankManagement\\SystemBank.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cnn = new SqlCommand("delete transactions where tid=@tid", con);
            cnn.Parameters.AddWithValue("@TID", int.Parse(txtTID.Text));
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Delete Successfully!");
        }

        private void txtTID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtTransactionType_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtAmount_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtAccountId_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }
    }
}
