using log4net;
using SoftSec_BankingApp_Se7en.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoftSec_BankingApp_Se7en.Models
{
    public class OTPLogModel
    {
        private static readonly ILog Elog = LogManager.GetLogger("ExceptionFileAppender");
        private static readonly ILog Tlog = LogManager.GetLogger("TransactionsFileAppender");

        public static bool CreateOTPLog(string username, string otp)
        {
            try
            {
                using (var db = new SSBankDBContext())
                {
                    List<OTPLog> otpLogs = db.OTPLogs.SqlQuery("SELECT * FROM dbo.OTPLogs WHERE username = @p0", username).ToList();

                    if (otpLogs.Count() < 1)
                    {
                        DateTimeOffset timestamp = new DateTimeOffset(DateTime.Now);
                        OTPLog otpLog = new OTPLog();
                        otpLog.username = username;
                        otpLog.otp = otp;
                        otpLog.timestamp = timestamp;

                        db.OTPLogs.Add(otpLog);
                        db.SaveChanges();
                    }
                    else
                    {
                        OTPLog otplogging = otpLogs.First();
                        otplogging.otp = otp;
                        otplogging.timestamp = new DateTimeOffset(DateTime.Now);
                        db.OTPLogs.Attach(otplogging);
                        var otpVar = db.Entry(otplogging);
                        otpVar.Property(e => e.otp).IsModified = true;
                        var timeVar = db.Entry(otplogging);
                        timeVar.Property(e => e.timestamp).IsModified = true;
                        db.SaveChanges();                    
                    }
                    return true;
                }
            }
            catch (Exception exp)
            {
                Console.WriteLine("Exception occurred: " + exp.Message);
                Elog.Error("Exception occurred: " + exp.Message);
                return false;
            }
        }

        public static List<OTPLog> GetOTPLog(string username)
        {
            try
            {
                using (var db = new SSBankDBContext())
                {
                    List<OTPLog> otpLogs = db.OTPLogs.SqlQuery("SELECT * FROM dbo.OTPLogs WHERE username = @p0", username).ToList();

                    if (otpLogs.Count() < 1)
                    {
                        return null;
                    }

                    return otpLogs;
                }
            }
            catch (Exception exp)
            {
                Elog.Error("Exception occurred: " + exp.Message);
                return null;
            }
        }
    }
}