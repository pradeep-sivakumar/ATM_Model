using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace ATM_Model
{
    public partial class Default3 : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("cook");
            cookie.Value = TextBox1.Text;
            Response.Cookies.Add(cookie);

            SqlConnection conn = new SqlConnection("Data Source=PRADEEP-SIVAKUM\\SQLEXPRESS;Initial Catalog=ATM;Integrated Security=True");
            SqlCommand cmd = new SqlCommand($"select pin from atm where id={Convert.ToInt32(TextBox1.Text)}", conn);
            conn.Open();
            try
            {
                int pin = Convert.ToInt32(cmd.ExecuteScalar());
                int enteredPin = Convert.ToInt32(TextBox2.Text);
                if (enteredPin == pin)
                {
                    Response.Redirect("Default0.aspx");
                }
                else
                {
                    Label1.Text = "Invalid PIN...";
                    Label1.ForeColor = System.Drawing.Color.Red;
                }
                conn.Close();
            }
            catch(Exception ex)
            {
                Label1.ForeColor = System.Drawing.Color.Red;
                Label1.Text = "Invalid ID...";
            }
            

        }
    }
}