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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            Dashboardcustomers();
            Dashboardemployees();
            Dashboardloans();
        }
        private void Dashboardcustomers()
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\HUY-PC\\source\\repos\\BankManagement\\BankManagement\\SystemBank.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cnn = new SqlCommand("SELECT COUNT(*) FROM customers", con);
            Int32 count = Convert.ToInt32(cnn.ExecuteScalar());
            if (count > 0)
            {
                lblctm.Text= Convert.ToString(count);
            }
            else
            {
                lblctm.Text = "0";
            }
            con.Close();
        }
        private void Dashboardemployees()
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\HUY-PC\\source\\repos\\BankManagement\\BankManagement\\SystemBank.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cnn = new SqlCommand("SELECT COUNT(*) FROM employees", con);
            Int32 count = Convert.ToInt32(cnn.ExecuteScalar());
            if (count > 0)
            {
                lblemp.Text = Convert.ToString(count);
            }
            else
            {
                lblemp.Text = "0";
            }
            con.Close();
        }
        private void Dashboardloans()
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\HUY-PC\\source\\repos\\BankManagement\\BankManagement\\SystemBank.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cnn = new SqlCommand("SELECT COUNT(*) FROM loans", con);
            Int32 count = Convert.ToInt32(cnn.ExecuteScalar());
            if (count > 0)
            {
                lbll.Text = Convert.ToString(count);
            }
            else
            {
                lbll.Text = "0";
            }
            con.Close();
        }
    }
}
