using SoftSec_BankingApp_Se7en.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoftSec_BankingApp_Se7en.Models
{

    public class LoginModel
    {
        // Returns: True false if the user information exists
        public bool UserExists(string username, int zip)
        {
            try
            {
                using (var db = new SSBankDBContext())
                {
                    List<User> users = db.Users.SqlQuery("SELECT * FROM dbo.Users WHERE username = @p0", username).ToList();

                    if (users.Count() < 1)
                    {
                        return false;
                    }

                    User user = users.First();
                    Address address = user.Address;
                    if (address == null)
                    {
                        return false;
                    }

                    if (address.zip != zip)
                    {
                        return false;
                    }

                    return true;
                }
            }
            catch (Exception exp)
            {
                //Log exception here
                return false;
            }
        }

        // Returns:
        // -1 if login fails
        // the row id if login success (UserId)
        public int LoginUser(string username, string password, int zip)
        {
            try
            {
                using (var db = new SSBankDBContext())
                {
                    List<User> users = db.Users.SqlQuery("SELECT * FROM dbo.Users WHERE username = @p0", username).ToList();

                    if (users.Count() < 1)
                    {
                        return -1;
                    }

                    User user = users.First();
                    Address address = user.Address;
                    if (address == null)
                    {
                        return -1;
                    }

                    if (address.zip != zip)
                    {
                        return -1;
                    }

                    if (!user.VerifyPassword(password))
                    {
                        return -1;
                    }

                    return user.id;
                }
            }
            catch (Exception exp)
            {
                //Log exception here
                return -1;
            }
        }
    }
}