using SoftSec_BankingApp_Se7en.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoftSec_BankingApp_Se7en.Models
{
    public class UserModel
    {
        public bool CreatUser(User newUser, string password, Address address, SecurityQandA securityQandA)
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

                /*List<User> users = db.Users.SqlQuery("SELECT * FROM dbo.Users WHERE username = @p0", username).ToList();

                if (users.Count() < 1)
                {
                    return false;
                }

                User user = users.First();
                Address address = user.Address;
                ICollection<SecurityQuestion> securityQandA = user.SecurityQuestions;
                */
                return true;
            }
        }

        public User GetUser(string username)
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

        public bool updateUser(string userName, string email, string staddress, string city, string state, string zipCode,string phoneNo)
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
    }
}