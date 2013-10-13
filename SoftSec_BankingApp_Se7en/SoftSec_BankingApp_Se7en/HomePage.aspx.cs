using SoftSec_BankingApp_Se7en.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SoftSec_BankingApp_Se7en
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoginModel login = new LoginModel();
            Response.Write("Returned id: ");
            Response.Write(login.LoginUser("Username", "Password"));
        }
    }
}