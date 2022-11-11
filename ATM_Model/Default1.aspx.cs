using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;


namespace ATM_Model
{
    public partial class Default1 : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection("Data Source=PRADEEP-SIVAKUM\\SQLEXPRESS;Initial Catalog=ATM;Integrated Security=True");
        public int id;
        public int pin;
        public double balance;
        protected void Page_Load(object sender, EventArgs e)
        {
            
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
            if (pin==Convert.ToInt32(TextBox2.Text))
            {
                Label3.ForeColor = System.Drawing.Color.Green;
                Label3.Text = $"Current Available Balance is {balance}.";
                TextBox2.Text = "";
            }
            else
            {
                Label3.ForeColor = System.Drawing.Color.Red;
                Label3.Text = "Wrong PIN! Try Again.";
                TextBox2.Text = "";
            }
        }
    }
}