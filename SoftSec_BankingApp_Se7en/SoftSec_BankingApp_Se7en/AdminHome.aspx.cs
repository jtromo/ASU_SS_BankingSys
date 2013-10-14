using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SoftSec_BankingApp_Se7en
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void modifyBT_Modify_Click(object sender, EventArgs e)
        {
            //Confirm this operation using a message box.
            //If YES then continue.
            //Clicking modify will alter the role in the DB and return the success/ failure. 
            //Depending on this the message is displayed and the fields are cleared.
        }

        protected void detailsBT_Modify_Click(object sender, EventArgs e)
        {
            //Populate the data in the label fields.
            firstNameTextLb_Modify.Text = "Uday Kumar";
            lastNameTextLb_Modify.Text = "Macherla";
            currentRoleTextLb_Modify.Text = "Admin";
        }

        protected void detailsBT_Remove_Click(object sender, EventArgs e)
        {
            //Populate the data in the label fields.
            firstNameTextLb_Remove.Text = "Uday Kumar";
            lastNameTextLb_Remove.Text = "Macherla";
            currentRoleTextLb_Remove.Text = "Admin";
        }

        protected void removeBt_Remove_Click(object sender, EventArgs e)
        {
            //Confirm this operation using a message box.
            //If YES then continue.
            //Clicking modify will remove the user in the DB and return the success/ failure. 
            //Depending on this the message is displayed and the user is deleted.
        }

        protected void Add_Click(object sender, EventArgs e)
        {
            firstNameTb_AddEmp.Text = "uday";
            //Note : If an user ( be it admin / managers / CEO ) is going to create a new user ( Employee of Bank - Any role ),
            //then we will set default username and password, and let the user reset his/her password later.
        }

        protected void tabAdmin_ActiveTabChanged(object sender, EventArgs e)
        {
            if (tabAdmin.ActiveTabIndex == 3)
            {
                sysLog_GridView.ShowHeader = true;
            }
        }
    }
}