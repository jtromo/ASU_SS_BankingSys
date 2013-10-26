using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Core.Crypto;
using System.Net.Mail;
using SoftSec_BankingApp_Se7en.Models;
using log4net;
using System.IO;

namespace SoftSec_BankingApp_Se7en
{
    public partial class OTPPrelim : System.Web.UI.Page
    {
        Core.Crypto.OTP otpF = new OTP();
        static String otpStr = "";
        private static readonly ILog Elog = LogManager.GetLogger("ExceptionFileAppender");
        private static readonly ILog Tlog = LogManager.GetLogger("TransactionsFileAppender");
        protected void Page_Load(object sender, EventArgs e)
        {
            Elog.Error("ieieieie");
            Tlog.Debug("kasjhdksadkasdkasdsakdjsakjdklasjdsklajd Info");
            

            //GridView2.DataSource = accounts;
            GridView2.DataBind();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            Random RandomNumber = new Random();
            otpF.GetCurrentOTP();
            for (int i = 0; i < Convert.ToInt32(RandomNumber.Next(100)); i++)
            {
                otpF.GetNextOTP();
            }
            otpStr = otpF.GetCurrentOTP();
            MailMessage mMailMessage = new MailMessage();

            // Set the sender address of the mail message
            mMailMessage.From = new MailAddress("bankse7en@gmail.com");
            // Set the recepient address of the mail message
            mMailMessage.To.Add(new MailAddress("ushakanthkvp@gmail.com"));


            mMailMessage.Subject = "Your Bank account has been hacked!!!";
            // Set the body of the mail message
            mMailMessage.Body = ":P Your OTP is :" + otpStr;

            // Set the format of the mail message body as HTML
            mMailMessage.IsBodyHtml = true;
            // Set the priority of the mail message to normal
            mMailMessage.Priority = MailPriority.Normal;
            SmtpClient mSmtpClient = new SmtpClient();
            mSmtpClient.EnableSsl = true;
            mSmtpClient.Send(mMailMessage);
            Label1.Text = otpStr;
            Session["OTP"] = otpStr;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            
            String inStrOTP = TextBox1.Text;
            if (inStrOTP.Equals(Session["OTP"].ToString()))
            {
                Label2.Text = "Hurray!";
            }
            else
                Label2.Text = "Get Lost!";

        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            String xx;
            xx = "";
             try
            {
                using (StreamReader sr = new StreamReader("C:/Users/uk/Documents/ss_bankingsys/SoftSec_BankingApp_Se7en/SoftSec_BankingApp_Se7en/Logs/Exception.log"))
                {
                    xx += sr.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(ex.Message);
            }
             
            TextBox2.Text = xx;
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            if (PopulateDBInitial.AddAdmin() && PopulateDBInitial.AddDepartmentManager() && PopulateDBInitial.AddHigherManager() && PopulateDBInitial.AddRegularEmployee())
            {
                Label1.Text = "Your DB looks great!!";
            }
            else
            {
                Label1.Text = "You screwed it up :P";
            }
        }

        protected void addRegUserBT_Click(object sender, EventArgs e)
        {
            if (PopulateDBInitial.AddRegularUser()) {
                Label1.Text = "regular users added!!";
            }
            else
            {
                Label1.Text = "You screwed it up :P";
            }
        }
    }
}