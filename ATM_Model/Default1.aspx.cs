using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ATM_Model
{
    public partial class Default1 : System.Web.UI.Page
    {
        public static string pin;
        public static int balance;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ViewState["d"] = Cache["pin1"];

                balance = Convert.ToInt32(Cache["bala"]);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           

            if (ViewState["d"].Equals(TextBox2.Text))
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