using SoftSec_BankingApp_Se7en.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoftSec_BankingApp_Se7en.Models
{
    public class UserModel
    {
        public static bool CreateUser(User newUser, string password, string checkingAccountNumber, string savingsAccountNumber, string routingNumber, Card checkingCard, Address address, List<SecurityQuestion> securityQuestions)
        {
            try
            {
                using (var db = new SSBankDBContext())
                {
                    if (newUser == null)
                        return false;
                    if (address == null)
                        return false;

                    DateTimeOffset timestamp = new DateTimeOffset(DateTime.Now);
                    newUser.creationTime = timestamp;
                    newUser.Address = address;
                    newUser.SecurityQuestions = securityQuestions;

                    Tables.Account checkingAccount = new Tables.Account { accountNumber=checkingAccountNumber, routingNumber=routingNumber, balance=0.0, isActive=true, accountTypeId=2, creationTime=timestamp };
                    // Add Card
                    checkingCard.accountNumber = checkingAccountNumber;
                    checkingAccount.Card = checkingCard;

                    Tables.Account savingsAccount = new Tables.Account { accountNumber = savingsAccountNumber, routingNumber = routingNumber, balance = 0.0, isActive = true, accountTypeId = 1, creationTime = timestamp };

                    List<Tables.Account> accounts = new List<Tables.Account> { checkingAccount, savingsAccount };
                    newUser.Accounts = accounts;

                    // Hash generation
                    if (newUser.SetHashandSaltForPassword(password))
                    {
                        //Response.Write("Valid");
                    }
                    else
                    {
                        //Response.Write("Not Valid");
                    }

                    db.Users.Add(newUser);
                    db.SaveChanges();

                    return true;
                }
            }
            catch (Exception exp)
            {
                Console.WriteLine("Exception occurred: " + exp.Message);
                //Log exception here
                return false;
            }
        }

        public static bool CreateEmployee(User newUser, string password, Address address, List<SecurityQuestion> securityQuestions)
        {
            try
            {
                using (var db = new SSBankDBContext())
                {
                    if (newUser == null)
                        return false;
                    if (address == null)
                        return false;

                    DateTimeOffset timestamp = new DateTimeOffset(DateTime.Now);
                    newUser.creationTime = timestamp;
                    newUser.Address = address;
                    newUser.SecurityQuestions = securityQuestions;

                    // Hash generation
                    if (newUser.SetHashandSaltForPassword(password))
                    {
                        //Response.Write("Valid");
                    }
                    else
                    {
                        //Response.Write("Not Valid");
                    }


                    db.Users.Add(newUser);

                    db.SaveChanges();

                    return true;
                }
            }
            catch (Exception exp)
            {
                Console.WriteLine("Exception occurred: " + exp.Message);
                //Log exception here
                return false;
            }
        }

        public static User GetUser(string username)
        {
            try
            {
                using (var db = new SSBankDBContext())
                {
                    List<User> users = db.Users.SqlQuery("SELECT * FROM dbo.Users WHERE username = @p0", username).ToList();

                    if (users.Count() < 1)
                    {
                        return null;
                    }

                    User user = users.First();
                    Address address = user.Address;
                    ICollection<SecurityQuestion> securityQandA = user.SecurityQuestions;

                    return user;
                }
            }
            catch (Exception exp)
            {
                //Log exception here
                return null;
            }
        }

        /// <summary>
        /// Returns the user object, given the Row ID.
        /// </summary>
        /// <param name="iuserId">Row ID</param>
        /// <returns>User Object</returns>
        public static User GetUser(int iuserId)
        {
            try
            {
                using (var db = new SSBankDBContext())
                {
                    List<User> users = db.Users.SqlQuery("SELECT * FROM dbo.Users WHERE id = @p0", iuserId).ToList();

                    if (users.Count() < 1)
                    {
                        return null;
                    }

                    User user = users.First();
                    Address address = user.Address;
                    ICollection<SecurityQuestion> securityQandA = user.SecurityQuestions;

                    return user;
                }
            }
            catch (Exception exp)
            {
                //Log exception here
                return null;
            }
        }

        public static bool RemoveUser(string username)
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
                    ICollection<SecurityQuestion> securityQandA = user.SecurityQuestions;
                    db.Users.Remove(user);
                    db.SaveChanges();

                    return true;
                }
            }
            catch (Exception exp)
            {
                //Log exception here
                return false;
            }
        }

        public static bool CheckRegularAccess(string username, int departmentId)
        {
            try
            {
                using (var db = new SSBankDBContext())
                {
                    // id 1 is invalid
                    if (departmentId < 2)
                        return false;

                    List<User> users = db.Users.SqlQuery("SELECT * FROM dbo.Users WHERE username = @p0", username).ToList();

                    if (users.Count() < 1)
                    {
                        return false;
                    }

                    User user = users.First();

                    // Role 1 is invalid. 2/3 are external users. Must be at least 4 to have a department
                    if (user.roleId < 4)
                        return false;

                    if (user.departmentId == departmentId)
                        return true;
                    else
                        return false;
                }
            }
            catch (Exception exp)
            {
                //Log exception here
                return false;
            }
        }

        public static bool CheckSuperiorAccess(string username, int departmentId)
        {
            try
            {
                using (var db = new SSBankDBContext())
                {
                    // id 1 is invalid
                    if (departmentId < 2)
                        return false;
                    List<User> users = db.Users.SqlQuery("SELECT * FROM dbo.Users WHERE username = @p0", username).ToList();

                    if (users.Count() < 1)
                    {
                        return false;
                    }

                    User user = users.First();

                    // Must be role 5 or higher to have superior access
                    if (user.roleId < 5)
                        return false;

                    if (user.departmentId == departmentId)
                        return true;
                    else
                        return false;
                }
            }
            catch (Exception exp)
            {
                //Log exception here
                return false;
            }
        }

        public static bool UpdateUser(string userName, string email, string staddress, string city, string state, string zipCode, string phoneNo)
        {
            try
            {
                using (var db = new SSBankDBContext())
                {
                    List<User> users = db.Users.SqlQuery("SELECT * FROM dbo.Users WHERE username = @p0", userName).ToList();

                    if (users.Count() < 1)
                    {
                        return false;
                    }

                    User updatedUser = users.First();
                    Address address = updatedUser.Address;
                    address.city = city;
                    address.state = state;
                    address.street1 = staddress;
                    address.zip = Convert.ToInt32(zipCode);
                    updatedUser.phone = phoneNo;
                    updatedUser.email = email;

                    db.Users.Attach(updatedUser);
                    db.Addresses.Attach(address);

                    //User Model
                    var vemail = db.Entry(updatedUser);
                    vemail.Property(e => e.email).IsModified = true;
                    var vphoneNo = db.Entry(updatedUser);
                    vphoneNo.Property(e => e.phone).IsModified = true;
                    //Address Models
                    var vaddr_zip = db.Entry(address);
                    vaddr_zip.Property(e => e.zip).IsModified = true;
                    var vaddr_street1 = db.Entry(address);
                    vaddr_street1.Property(e => e.street1).IsModified = true;
                    var vaddr_street2 = db.Entry(address);
                    vaddr_street2.Property(e => e.street2).IsModified = true;
                    var vaddr_city = db.Entry(address);
                    vaddr_city.Property(e => e.city).IsModified = true;
                    var vaddr_state = db.Entry(address);
                    vaddr_state.Property(e => e.state).IsModified = true;
                    db.SaveChanges();

                    return true;
                }
            }
            catch (Exception exp)
            {
                //Log exception here
                return false;
            }
        }
        public static bool TransferToDept(string username, int ToDepartmentId)
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
                    user.departmentId = ToDepartmentId;
                    db.Users.Attach(user);
                    var vdeptId = db.Entry(user);
                    vdeptId.Property(e => e.departmentId).IsModified = true;
                    
                    db.SaveChanges();

                    return true;
                   
                }
            }
            catch (Exception exp)
            {
                //Log exception here
                return false;
            }
        }
    }
}