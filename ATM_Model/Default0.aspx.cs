using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ATM_Model
{
    public partial class Default : System.Web.UI.Page
    {
     public static string pin;
        public int balance;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                ViewState["d"] = Cache["pin1"];
                try
                {
                    balance = Convert.ToInt32(Cache["bala"]);
                }
                catch
                {
                    
                }
            }
        }
        public void empty()
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
        }
        public void remember(int balance)
        {
            Cache["bala"] = balance;
        }
        protected void Button1_Click(object sender, EventArgs e)
        {   
            int amount = Convert.ToInt32(TextBox1.Text);
            string enteredPin = TextBox2.Text;
            Label3.Text = pin;
            if (ViewState["d"].Equals(enteredPin))
            {
                balance += amount;
                Label3.ForeColor = System.Drawing.Color.Green;
                Label3.Text = "Amount Deposited Successfully!";
                empty();
                remember(balance);
            }
            else
            {
                Label3.ForeColor = System.Drawing.Color.Red;
                Label3.Text = "Entered PIN is wrong!";
                empty();
                remember(balance);
            }
        }
    }
}