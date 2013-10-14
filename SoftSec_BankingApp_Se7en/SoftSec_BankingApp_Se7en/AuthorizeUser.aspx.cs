using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SoftSec_BankingApp_Se7en
{
    public partial class AuthorizeUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SiteKey.ImageUrl = "./Images/SiteKeys/SiteKey1.jpg";
        }

        protected void Btn_SignIn_Click(object sender, EventArgs e)
        {

        }

        protected void Btn_ForgotPassword_Click(object sender, EventArgs e)
        {
            Response.Redirect("ForgotPassword.aspx");
        }
    }
}