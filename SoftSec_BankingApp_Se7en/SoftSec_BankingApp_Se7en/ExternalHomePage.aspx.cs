using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SoftSec_BankingApp_Se7en
{
    public partial class ExternalHomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TB_UserName.Text = "";
            TB_ZipCode.Text = "";
        }

        protected void Btn_Reset_Click(object sender, EventArgs e)
        {
            TB_UserName.Text = "";
            TB_ZipCode.Text = "";
        }

        protected void Btn_SignIn_Click(object sender, EventArgs e)
        {
            
        }
    }
}