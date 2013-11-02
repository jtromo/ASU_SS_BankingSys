using log4net;
using SoftSec_BankingApp_Se7en.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoftSec_BankingApp_Se7en.Models
{
    public class PkiModel
    {
        private static readonly ILog Elog = LogManager.GetLogger("ExceptionFileAppender");
        private static readonly ILog Tlog = LogManager.GetLogger("TransactionsFileAppender");

        public static string GetCertificateNameForUsername(string username)
        {
            try
            {
                using (var db = new SSBankDBContext())
                {
                    List<PkiCertificate> certificates = db.PkiCertificates.SqlQuery("SELECT * FROM dbo.PkiCertificates WHERE username = @p0", username).ToList();

                    if (certificates.Count() < 1)
                    {
                        return null;
                    }

                    PkiCertificate certificate = certificates.First();

                    return certificate.certificateName;
                }
            }
            catch (Exception exp)
            {
                Elog.Error("Exception occurred: " + exp.Message);
                return null;
            }
        }

        public static List<PkiCertificate> GetAvailableCertificateNames()
        {
            try
            {
                using (var db = new SSBankDBContext())
                {
                    List<PkiCertificate> certificates = db.PkiCertificates.SqlQuery("SELECT * FROM dbo.PkiCertificates WHERE username IS NULL").ToList();

                    return certificates;
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