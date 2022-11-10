using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ATM_Model
{
    public partial class Default3 : System.Web.UI.Page
    {
        
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
      
        protected void Button1_Click(object sender, EventArgs e)
        {
             Details details = new Details();
             details.pin = TextBox1.Text;
             Cache["pin1"] = details.pin;
            
            Response.Redirect("Default0.aspx");
        }
    }
}