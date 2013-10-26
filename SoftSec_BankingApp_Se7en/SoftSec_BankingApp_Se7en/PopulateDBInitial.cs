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
            return userCreated;
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
    }
} 