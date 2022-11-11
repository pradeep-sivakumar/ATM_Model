using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Net;

namespace ATM_Model
{
    public partial class Default31 : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection("Data Source=PRADEEP-SIVAKUM\\SQLEXPRESS;Initial Catalog=ATM;Integrated Security=True");
        public int pin;
        public int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(Request.Cookies["cook"].Value); 
            int old = Convert.ToInt32(TextBox1.Text);
            int newPass = Convert.ToInt32(TextBox2.Text);
            id = Convert.ToInt32(Request.Cookies["cook"].Value);
            conn.Open();
            SqlCommand cmd = new SqlCommand($"select pin from atm where id={id}", conn);
            pin = Convert.ToInt32(cmd.ExecuteScalar());

            if (pin!=old)
            {
                Label3.ForeColor = System.Drawing.Color.Red;
                Label3.Text = "Current PIN is Wrong!";
                TextBox1.Text = "";
                TextBox2.Text = "";
            }
            else if((newPass == pin))
            {
                Label3.ForeColor = System.Drawing.Color.Red;
                Label3.Text = "New PIN cannot be the old PIN!";
                TextBox1.Text = "";
                TextBox2.Text = "";
            }
            else
            {
                SqlCommand a = new SqlCommand($"update atm set pin = {newPass} where id={id}", conn);
                a.ExecuteNonQuery();
                Label3.ForeColor = System.Drawing.Color.Green;
                Label3.Text = "PIN has been changed!";
                TextBox1.Text = "";
                TextBox2.Text = "";
            }
            conn.Close();
        }
    }
}