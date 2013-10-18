using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Security;

namespace SoftSec_BankingApp_Se7en.Models
{
    public class HashController
    {
        private const int DEFAULT_SALT_SIZE = 5;

        public static string CreateSalt()
        {
            RNGCryptoServiceProvider rngCryptoServiceProvider = new RNGCryptoServiceProvider();
            byte[] buffer = new byte[DEFAULT_SALT_SIZE];
            rngCryptoServiceProvider.GetBytes(buffer);
            return Convert.ToBase64String(buffer);
        }

        public static string CreateHash(string password)
        {
            return CreateHash(password, CreateSalt());
        }

        public static string CreateHash(string password, string salt)
        {
            string saltAndPassword = String.Concat(password, salt);
            string hashedPassword = FormsAuthentication.HashPasswordForStoringInConfigFile(saltAndPassword, "SHA1");
            hashedPassword = string.Concat(hashedPassword, salt);
            return hashedPassword;
        }

        public static bool VerifyPassword(string userpassword, string password)
        {
            byte[] bytePassword = Convert.FromBase64String(userpassword);
            byte[] byteSalt = new byte[DEFAULT_SALT_SIZE];
            Array.Copy(bytePassword, bytePassword.Length - DEFAULT_SALT_SIZE, byteSalt, 0, DEFAULT_SALT_SIZE);
            string salt = Convert.ToBase64String(byteSalt);
            string hashedPassword = CreateHash(password, salt);
            return hashedPassword.Equals(userpassword);
        }
    }
}