using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SoftSec_BankingApp_Se7en.Models.Tables
{
    public class User
    {
        public User()
        {
            this.Accounts = new HashSet<Account>();
            this.SecurityQuestions = new HashSet<SecurityQuestion>();
        }

        public bool SetHashandSaltForPII(string password, string socialSecurity, string birthdate) 
        {
            this.salt = HashController.CreateSalt();
            this.hash = HashController.CreateHash(password, this.salt);
            this.socialSecurityNumber = HashController.CreateHash(socialSecurity, this.salt);
            this.dateOfBirth = HashController.CreateHash(birthdate, this.salt);

            return true;
        }

        // Salt does not change
        public bool SetHashForPassword(string password)
        {
            this.hash = HashController.CreateHash(password, this.salt);

            return true;
        }

        public bool VerifyPassword(string password)
        {
            if (hash == null)
                return false;
            if (password == null)
                return false;

            string hashedPassword = HashController.CreateHash(password, salt);
            return hashedPassword.Equals(hash);
        }

        public bool VerifySocialSecurity(string socialSecurity)
        {
            if (hash == null)
                return false;
            if (socialSecurity == null)
                return false;

            string hashedSocialSecurity = HashController.CreateHash(socialSecurity, salt);
            return socialSecurity.Equals(socialSecurityNumber);
        }

        public bool VerifyDoB(string dob)
        {
            if (hash == null)
                return false;
            if (dob == null)
                return false;

            string hashedDoB = HashController.CreateHash(dob, salt);
            return hashedDoB.Equals(dateOfBirth);
        }

        public int id { get; set; }
        public int? roleId { get; set; }
        public int? addressId { get; set; }
        public int? departmentId { get; set; }
        public string firstName { get; set; }
        public string middleName { get; set; }
        public string lastName { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string sessionId { get; set; }
        public string salt { get; set; }
        public string hash { get; set; }
        public string phone { get; set; }
        public string organization { get; set; }
        public string socialSecurityNumber { get; set; }
        public string dateOfBirth { get; set; }
        public int siteKeyVal { get; set; }
        [MaxLength(30)]
        public string siteKeyString { get; set; }
        public bool isActive { get; set; }
        [Required]
        public System.DateTimeOffset creationTime { get; set; }
        public System.DateTimeOffset? modificationTime { get; set; }
        public System.DateTimeOffset? deletionTime { get; set; }
        public System.DateTimeOffset? lockoutTime { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }
        public virtual Role Role { get; set; }
        public virtual ICollection<SecurityQuestion> SecurityQuestions { get; set; }
        public virtual Department department { get; set; }
        
        public virtual Address Address { get; set; }
    }
}