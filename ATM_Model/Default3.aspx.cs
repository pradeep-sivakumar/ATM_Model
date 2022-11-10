using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ATM_Model
{
    public partial class Default31 : System.Web.UI.Page
    {
        public static string pin;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ViewState["d"] = Cache["pin1"];

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string old = TextBox1.Text;
            string newPass = TextBox2.Text;

            if (!(old.Equals(ViewState["d"])))
            {
                Label3.ForeColor = System.Drawing.Color.Red;
                Label3.Text = "Current password is Wrong!";
                TextBox1.Text = "";
                TextBox2.Text = "";
            }
            else if((newPass == old) && (old.Equals(ViewState["d"])))
            {
                Label3.ForeColor = System.Drawing.Color.Red;
                Label3.Text = "New password cannot be the old Password!";
                TextBox1.Text = "";
                TextBox2.Text = "";
            }
            else
            {
                Cache["pin1"] = newPass;
                Label3.ForeColor = System.Drawing.Color.Green;
                Label3.Text = "Password is changed!";
                TextBox1.Text = "";
                TextBox2.Text = "";
            }
        }
    }
}