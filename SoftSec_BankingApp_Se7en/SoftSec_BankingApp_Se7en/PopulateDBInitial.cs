using SoftSec_BankingApp_Se7en.Models;
using SoftSec_BankingApp_Se7en.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoftSec_BankingApp_Se7en
{
    public class PopulateDBInitial
    {
        public static bool AddAdmin()
        {
            User userToCreate = new User();
            userToCreate.firstName = "Bat";
            userToCreate.middleName = "";
            userToCreate.lastName = "Man";
            userToCreate.email = "bankse7en@gmail.com";
            userToCreate.roleId = 7;
            Address addressForUser = new Address();
            addressForUser.firstName = "Bat";
            addressForUser.lastName = "Man";
            addressForUser.street1 = "The Batcave";
            addressForUser.city = "Gotham";
            addressForUser.state = "NY";
            addressForUser.country = "US";
            addressForUser.zip = 70007;
            userToCreate.phone = "4803268372";
            userToCreate.username = "darkknight";
            userToCreate.siteKeyVal = 7;
            userToCreate.siteKeyString = "Rise";
            string userDOB = "07" + "/" + "07" + "/" + "07";
            bool userCreated = UserModel.CreateEmployee(userToCreate, "Catwoman143!", "875487544", userDOB, addressForUser, null);
            return userCreated;              
                            
        }

        public static bool AddRegularEmployee()
        {
            User userToCreate = new User();
            userToCreate.firstName = "Petr";
            userToCreate.middleName = "";
            userToCreate.lastName = "Cech";
            userToCreate.email = "petrcech@gmail.com";
            userToCreate.roleId = 4;
            userToCreate.departmentId = 4;
            Address addressForUser = new Address();
            addressForUser.firstName = "Petr";
            addressForUser.lastName = "Cech";
            addressForUser.street1 = "The Batcave";
            addressForUser.city = "Gotham";
            addressForUser.state = "NY";
            addressForUser.country = "US";
            addressForUser.zip = 70007;
            userToCreate.phone = "4803268372";
            userToCreate.username = "petrcech";
            userToCreate.siteKeyVal = 15;
            userToCreate.siteKeyString = "Save";
            string userDOB = "07" + "/" + "07" + "/" + "07";
            bool userCreated = UserModel.CreateEmployee(userToCreate, "Catwoman143!", "875487544", userDOB, addressForUser, null);
            
            User userToCreate1 = new User();
            userToCreate1.firstName = "Iker";
            userToCreate1.middleName = "";
            userToCreate1.lastName = "Casillas";
            userToCreate1.email = "petrcech@gmail.com";
            userToCreate1.roleId = 4;
            userToCreate1.departmentId = 2;
            Address addressForUser1 = new Address();
            addressForUser1.firstName = "Iker";
            addressForUser1.lastName = "Casillas";
            addressForUser1.street1 = "The Batcave";
            addressForUser1.city = "Gotham";
            addressForUser1.state = "NY";
            addressForUser1.country = "US";
            addressForUser1.zip = 70007;
            userToCreate1.phone = "4803268372";
            userToCreate1.username = "iker";
            userToCreate1.siteKeyVal = 15;
            userToCreate1.siteKeyString = "Save";
            string userDOB1 = "07" + "/" + "07" + "/" + "07";
            bool userCreated1 = UserModel.CreateEmployee(userToCreate1, "Catwoman143!", "875487544", userDOB1, addressForUser1, null);
            return (userCreated && userCreated1);
        }

        public static bool AddDepartmentManager()
        {
            User userToCreate = new User();
            userToCreate.firstName = "Marco";
            userToCreate.middleName = "";
            userToCreate.lastName = "Polo";
            userToCreate.email = "marcopolo@gmail.com";
            userToCreate.roleId = 5;
            userToCreate.departmentId = 4;
            Address addressForUser = new Address();
            addressForUser.firstName = "Marco";
            addressForUser.lastName = "Polo";
            addressForUser.street1 = "The Batcave";
            addressForUser.city = "Gotham";
            addressForUser.state = "NY";
            addressForUser.country = "US";
            addressForUser.zip = 70007;
            userToCreate.phone = "4803268372";
            userToCreate.username = "marcopolo";
            userToCreate.siteKeyVal = 7;
            userToCreate.siteKeyString = "Rise";
            string userDOB = "07" + "/" + "07" + "/" + "07";
            bool userCreated = UserModel.CreateEmployee(userToCreate, "Catwoman143!", "875487544", userDOB, addressForUser, null);

            User userToCreate1 = new User();
            userToCreate1.firstName = "Eden";
            userToCreate1.middleName = "";
            userToCreate1.lastName = "Hazard";
            userToCreate1.email = "eden1@gmail.com";
            userToCreate1.roleId = 5;
            userToCreate1.departmentId = 4;
            Address addressForUser1 = new Address();
            addressForUser1.firstName = "Eden";
            addressForUser1.lastName = "Hazard";
            addressForUser1.street1 = "The Batcave";
            addressForUser1.city = "Gotham";
            addressForUser1.state = "NY";
            addressForUser1.country = "US";
            addressForUser1.zip = 70007;
            userToCreate1.phone = "4803268372";
            userToCreate1.username = "hazard";
            userToCreate1.siteKeyVal = 18;
            userToCreate1.siteKeyString = "Score";
            string userDOB1 = "07" + "/" + "07" + "/" + "07";
            bool userCreated1 = UserModel.CreateEmployee(userToCreate1, "Catwoman143!", "875487544", userDOB1, addressForUser1, null);

            User userToCreate2 = new User();
            userToCreate2.firstName = "Fernando";
            userToCreate2.middleName = "";
            userToCreate2.lastName = "Torres";
            userToCreate2.email = "nando9@gmail.com";
            userToCreate2.roleId = 5;
            userToCreate2.departmentId = 2;
            Address addressForUser2 = new Address();
            addressForUser2.firstName = "Fernando";
            addressForUser2.lastName = "Torres";
            addressForUser2.street1 = "The Batcave";
            addressForUser2.city = "Gotham";
            addressForUser2.state = "NY";
            addressForUser2.country = "US";
            addressForUser2.zip = 70007;
            userToCreate2.phone = "4803268372";
            userToCreate2.username = "torres";
            userToCreate2.siteKeyVal = 16;
            userToCreate2.siteKeyString = "Score";
            string userDOB2 = "07" + "/" + "07" + "/" + "07";
            bool userCreated2 = UserModel.CreateEmployee(userToCreate2, "Catwoman143!", "875487544", userDOB2, addressForUser2, null);
            return (userCreated && userCreated1 && userCreated2);
        }
        public static bool AddHigherManager()
        {
            User userToCreate = new User();
            userToCreate.firstName = "Robert";
            userToCreate.middleName = "";
            userToCreate.lastName = "Lewandowski";
            userToCreate.email = "robert1@gmail.com";
            userToCreate.roleId = 6;
            userToCreate.departmentId = 2;
            Address addressForUser = new Address();
            addressForUser.firstName = "Robert";
            addressForUser.lastName = "Lewandowski";
            addressForUser.street1 = "The Batcave";
            addressForUser.city = "Gotham";
            addressForUser.state = "NY";
            addressForUser.country = "US";
            addressForUser.zip = 70007;
            userToCreate.phone = "4803268372";
            userToCreate.username = "robert";
            userToCreate.siteKeyVal = 12;
            userToCreate.siteKeyString = "Rise";
            string userDOB = "07" + "/" + "07" + "/" + "07";
            bool userCreated = UserModel.CreateEmployee(userToCreate, "Catwoman143!", "875487544", userDOB, addressForUser, null);
            
            User userToCreate1 = new User();
            userToCreate1.firstName = "Karim";
            userToCreate1.middleName = "";
            userToCreate1.lastName = "Benzema";
            userToCreate1.email = "karim1@gmail.com";
            userToCreate1.roleId = 6;
            userToCreate1.departmentId = 4;
            Address addressForUser1 = new Address();
            addressForUser1.firstName = "Karim";
            addressForUser1.lastName = "Benzema";
            addressForUser1.street1 = "The Batcave";
            addressForUser1.city = "Gotham";
            addressForUser1.state = "NY";
            addressForUser1.country = "US";
            addressForUser1.zip = 70007;
            userToCreate1.phone = "4803268372";
            userToCreate1.username = "benzema";
            userToCreate1.siteKeyVal = 9;
            userToCreate1.siteKeyString = "Rise";
            string userDOB1 = "07" + "/" + "07" + "/" + "07";
            bool userCreated1 = UserModel.CreateEmployee(userToCreate1, "Catwoman143!", "875487544", userDOB1, addressForUser1, null);
            return (userCreated && userCreated1);
        }
        public static bool addCerts()
        {
            string cert1 = "BC74214";
            string cert2 = "BC44820";
            string cert3 = "BC45052";
            string cert4 = "BC93825";
            string cert5 = "BC35756";
            string cert6 = "BC25324";
            string cert7 = "BC11590";
            string cert8 = "BC50337";
            string cert9 = "BC63288";
            string cert10 = "BC82631";
            string cert11 = "BC17408";
            string cert12 = "BC52168";
            string cert13 = "BC67994";
            string cert14 = "BC82688";
            string cert15 = "BC26511";
            string cert16 = "BC16111";
            string cert17 = "BC51564";
            string cert18 = "BC84825";
            string cert19 = "BC59000";
            string cert20 = "BC88800";
            string cert21 = "BC72915";
            string cert22 = "BC48421";
            string cert23 = "BC68902";
            string cert24 = "BC67606";
            string cert25 = "BC13866";
            string cert26 = "BC82984";
            string cert27 = "BC26818";
            string cert28 = "BC48177";
            string cert29 = "BC90849";
            string cert30 = "BC59461";

            var db = new SSBankDBContext();
            SoftSec_BankingApp_Se7en.Models.Tables.PkiCertificate pkicert1 = new SoftSec_BankingApp_Se7en.Models.Tables.PkiCertificate { certificateName = cert1 };
            SoftSec_BankingApp_Se7en.Models.Tables.PkiCertificate pkicert2 = new SoftSec_BankingApp_Se7en.Models.Tables.PkiCertificate { certificateName = cert2 };
            SoftSec_BankingApp_Se7en.Models.Tables.PkiCertificate pkicert3 = new SoftSec_BankingApp_Se7en.Models.Tables.PkiCertificate { certificateName = cert3 };
            SoftSec_BankingApp_Se7en.Models.Tables.PkiCertificate pkicert4 = new SoftSec_BankingApp_Se7en.Models.Tables.PkiCertificate { certificateName = cert4 };
            SoftSec_BankingApp_Se7en.Models.Tables.PkiCertificate pkicert5 = new SoftSec_BankingApp_Se7en.Models.Tables.PkiCertificate { certificateName = cert5 };
            SoftSec_BankingApp_Se7en.Models.Tables.PkiCertificate pkicert6 = new SoftSec_BankingApp_Se7en.Models.Tables.PkiCertificate { certificateName = cert6 };
            SoftSec_BankingApp_Se7en.Models.Tables.PkiCertificate pkicert7 = new SoftSec_BankingApp_Se7en.Models.Tables.PkiCertificate { certificateName = cert7 };
            SoftSec_BankingApp_Se7en.Models.Tables.PkiCertificate pkicert8 = new SoftSec_BankingApp_Se7en.Models.Tables.PkiCertificate { certificateName = cert8 };
            SoftSec_BankingApp_Se7en.Models.Tables.PkiCertificate pkicert9 = new SoftSec_BankingApp_Se7en.Models.Tables.PkiCertificate { certificateName = cert9 };
            SoftSec_BankingApp_Se7en.Models.Tables.PkiCertificate pkicert10 = new SoftSec_BankingApp_Se7en.Models.Tables.PkiCertificate { certificateName = cert10 };
            SoftSec_BankingApp_Se7en.Models.Tables.PkiCertificate pkicert11 = new SoftSec_BankingApp_Se7en.Models.Tables.PkiCertificate { certificateName = cert11 };
            SoftSec_BankingApp_Se7en.Models.Tables.PkiCertificate pkicert12 = new SoftSec_BankingApp_Se7en.Models.Tables.PkiCertificate { certificateName = cert12 };
            SoftSec_BankingApp_Se7en.Models.Tables.PkiCertificate pkicert13 = new SoftSec_BankingApp_Se7en.Models.Tables.PkiCertificate { certificateName = cert13 };
            SoftSec_BankingApp_Se7en.Models.Tables.PkiCertificate pkicert14 = new SoftSec_BankingApp_Se7en.Models.Tables.PkiCertificate { certificateName = cert14 };
            SoftSec_BankingApp_Se7en.Models.Tables.PkiCertificate pkicert15 = new SoftSec_BankingApp_Se7en.Models.Tables.PkiCertificate { certificateName = cert15 };
            SoftSec_BankingApp_Se7en.Models.Tables.PkiCertificate pkicert16 = new SoftSec_BankingApp_Se7en.Models.Tables.PkiCertificate { certificateName = cert16 };
            SoftSec_BankingApp_Se7en.Models.Tables.PkiCertificate pkicert17 = new SoftSec_BankingApp_Se7en.Models.Tables.PkiCertificate { certificateName = cert17 };
            SoftSec_BankingApp_Se7en.Models.Tables.PkiCertificate pkicert18 = new SoftSec_BankingApp_Se7en.Models.Tables.PkiCertificate { certificateName = cert18 };
            SoftSec_BankingApp_Se7en.Models.Tables.PkiCertificate pkicert19 = new SoftSec_BankingApp_Se7en.Models.Tables.PkiCertificate { certificateName = cert19 };
            SoftSec_BankingApp_Se7en.Models.Tables.PkiCertificate pkicert20 = new SoftSec_BankingApp_Se7en.Models.Tables.PkiCertificate { certificateName = cert20 };
            SoftSec_BankingApp_Se7en.Models.Tables.PkiCertificate pkicert21 = new SoftSec_BankingApp_Se7en.Models.Tables.PkiCertificate { certificateName = cert21 };
            SoftSec_BankingApp_Se7en.Models.Tables.PkiCertificate pkicert22 = new SoftSec_BankingApp_Se7en.Models.Tables.PkiCertificate { certificateName = cert22 };
            SoftSec_BankingApp_Se7en.Models.Tables.PkiCertificate pkicert23 = new SoftSec_BankingApp_Se7en.Models.Tables.PkiCertificate { certificateName = cert23 };
            SoftSec_BankingApp_Se7en.Models.Tables.PkiCertificate pkicert24 = new SoftSec_BankingApp_Se7en.Models.Tables.PkiCertificate { certificateName = cert24 };
            SoftSec_BankingApp_Se7en.Models.Tables.PkiCertificate pkicert25 = new SoftSec_BankingApp_Se7en.Models.Tables.PkiCertificate { certificateName = cert25 };
            SoftSec_BankingApp_Se7en.Models.Tables.PkiCertificate pkicert26 = new SoftSec_BankingApp_Se7en.Models.Tables.PkiCertificate { certificateName = cert26 };
            SoftSec_BankingApp_Se7en.Models.Tables.PkiCertificate pkicert27 = new SoftSec_BankingApp_Se7en.Models.Tables.PkiCertificate { certificateName = cert27 };
            SoftSec_BankingApp_Se7en.Models.Tables.PkiCertificate pkicert28 = new SoftSec_BankingApp_Se7en.Models.Tables.PkiCertificate { certificateName = cert28 };
            SoftSec_BankingApp_Se7en.Models.Tables.PkiCertificate pkicert29 = new SoftSec_BankingApp_Se7en.Models.Tables.PkiCertificate { certificateName = cert29 };
            SoftSec_BankingApp_Se7en.Models.Tables.PkiCertificate pkicert30 = new SoftSec_BankingApp_Se7en.Models.Tables.PkiCertificate { certificateName = cert30 };
            db.PkiCertificates.Add(pkicert1);
            db.PkiCertificates.Add(pkicert2);
            db.PkiCertificates.Add(pkicert3);
            db.PkiCertificates.Add(pkicert4);
            db.PkiCertificates.Add(pkicert5);
            db.PkiCertificates.Add(pkicert6);
            db.PkiCertificates.Add(pkicert7);
            db.PkiCertificates.Add(pkicert8);
            db.PkiCertificates.Add(pkicert9);
            db.PkiCertificates.Add(pkicert10);
            db.PkiCertificates.Add(pkicert11);
            db.PkiCertificates.Add(pkicert12);
            db.PkiCertificates.Add(pkicert13);
            db.PkiCertificates.Add(pkicert14);
            db.PkiCertificates.Add(pkicert15);
            db.PkiCertificates.Add(pkicert16);
            db.PkiCertificates.Add(pkicert17);
            db.PkiCertificates.Add(pkicert18);
            db.PkiCertificates.Add(pkicert19);
            db.PkiCertificates.Add(pkicert20); 
            db.PkiCertificates.Add(pkicert21);
            db.PkiCertificates.Add(pkicert22);
            db.PkiCertificates.Add(pkicert23);
            db.PkiCertificates.Add(pkicert24);
            db.PkiCertificates.Add(pkicert25);
            db.PkiCertificates.Add(pkicert26);
            db.PkiCertificates.Add(pkicert27);
            db.PkiCertificates.Add(pkicert28);
            db.PkiCertificates.Add(pkicert29);
            db.PkiCertificates.Add(pkicert30);
            db.SaveChanges();
            return true;

        }
    }
} 