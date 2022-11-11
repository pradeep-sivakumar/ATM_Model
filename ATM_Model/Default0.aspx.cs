using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;


namespace ATM_Model
{
    public partial class Default : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection("Data Source=PRADEEP-SIVAKUM\\SQLEXPRESS;Initial Catalog=ATM;Integrated Security=True");
        public int pin;
        public double balance;
        public int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
            }
        }
        public void empty()
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(Request.Cookies["cook"].Value);
            conn.Open();
            SqlCommand cmd = new SqlCommand($"select pin from atm where id={id}", conn);
            SqlCommand cmd1 = new SqlCommand($"select balance from atm where id={id}", conn);
            pin = Convert.ToInt32(cmd.ExecuteScalar());
            balance = Convert.ToDouble(cmd1.ExecuteScalar());
            conn.Close();
            double amount = Convert.ToDouble(TextBox1.Text);
            int enteredPin = Convert.ToInt32(TextBox2.Text);
           
            if (pin==enteredPin)
            {
                balance += amount;
                conn.Open();
                SqlCommand a = new SqlCommand($"update atm set balance = {balance} where id={id}",conn);
                a.ExecuteNonQuery();
                Label3.ForeColor = System.Drawing.Color.Green;
                Label3.Text = "Amount Deposited Successfully!";
                empty();
                
            }
            else
            {
                Label3.ForeColor = System.Drawing.Color.Red;
                Label3.Text = "Entered PIN is wrong!";
                empty();           
            }
        }

        
    }
}