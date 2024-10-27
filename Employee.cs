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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\HUY-PC\\source\\repos\\BankManagement\\BankManagement\\SystemBank.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cnn = new SqlCommand("select * from employees", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dgvEmployee.DataSource = table;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\HUY-PC\\source\\repos\\BankManagement\\BankManagement\\SystemBank.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cnn = new SqlCommand("insert into employees values(@eid,@name, @position,@salary)", con);
            cnn.Parameters.AddWithValue("@EID", int.Parse(txtEID.Text));
            cnn.Parameters.AddWithValue("@Name", txtName.Text);
            cnn.Parameters.AddWithValue("@Position", txtPosition.Text);
            cnn.Parameters.AddWithValue("@Salary", txtSalary.Text);
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Saved Successfully!");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\HUY-PC\\source\\repos\\BankManagement\\BankManagement\\SystemBank.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cnn = new SqlCommand("select * from employees", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dgvEmployee.DataSource = table;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\HUY-PC\\source\\repos\\BankManagement\\BankManagement\\SystemBank.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cnn = new SqlCommand("update employees set name=@name, position=@position,salary=@salary where eid=@eid", con);
            cnn.Parameters.AddWithValue("@EID", int.Parse(txtEID.Text));
            cnn.Parameters.AddWithValue("@Name", txtName.Text);
            cnn.Parameters.AddWithValue("@Position", txtPosition.Text);
            cnn.Parameters.AddWithValue("@Salary", txtSalary.Text);
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Update Successfully!");
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\HUY-PC\\source\\repos\\BankManagement\\BankManagement\\SystemBank.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cnn = new SqlCommand("delete employees where eid=@eid", con);
            cnn.Parameters.AddWithValue("@EID", int.Parse(txtEID.Text));
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Saved Successfully!");
        }

        private void txtEID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtPosition_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtSalary_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }
    }
}
