using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace SoftSec_BankingApp_Se7en
{
    public class FieldValidator
    {
        /// <summary>
        /// Validates the email field (Max Length - 40)
        /// </summary>
        /// <param name="email">The value to be validated</param>
        /// <returns>true : if the email passes the validation else false</returns>
        public bool validate_Email(string email)
        {
            try
            {
                //Regular expression for email validation
                Regex emailregex = new Regex(@"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*"
                                            + "@"
                                            + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$");
                Match emailMatch = emailregex.Match(email);
                if (emailMatch.Success)
                {
                    if (email.Length <= 40)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception exp)
            {
                //Log the exception exp
                return false;
            }
        }

        /// <summary>
        /// Validates a given username (only alphanumeric values are allowed. Max Length - 20.First character has to be alphabet)
        /// </summary>
        /// <param name="userName">User name of the user.</param>
        /// <returns>Returns true if the validation passes, else returns false.</returns>
        public bool validate_UserName(string userName)
        {
            try
            {
                Regex usernameRegex = new Regex("^[a-zA-Z][a-zA-Z0-9]*$");
                Match usernameMatch = usernameRegex.Match(userName);
                if (usernameMatch.Success)
                {
                    if (userName.Length <= 20)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception exp)
            {
                //Log Exception exp
                return false;
            }
        }

        /// <summary>
        /// Validates the Password field and displays strength
        /// </summary>
        /// <param name="password">The password to validate and identify the strength</param>
        /// <returns>If valid password, then returns the strength along with TRUE, else returns FALSE.</returns>
        public string validate_password(string password)
        {
            try
            {
                int score = 1;
                //Password - 8 characters long, 1 uppercase character, 1 special character and alphanumeric characters  
                if (password.Length < 8 || !Regex.IsMatch(password, @"((?=.*\d)(?=.*[A-Z])(?=.*\W).{8,20})", RegexOptions.ECMAScript))
                    return "0_FALSE";
                else
                {
                    if (password.Length >= 9)
                        score++;
                    if (password.Length >= 12)
                        score++;
                    if (Regex.IsMatch(password, @"^\d+$", RegexOptions.ECMAScript))
                        score++;
                    if (Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z]).+$", RegexOptions.ECMAScript))
                        score++;
                    if (Regex.IsMatch(password, @"^[!,@,#,$,%]", RegexOptions.ECMAScript)) //^,&,*,?,_,~,-,L,(,) can add these special characters if we want to include it.
                        score++;
                }
                return (score + "_TRUE");
            }
            catch (Exception exp)
            {
                //Log exception exp
                return "0_ FALSE";
            }
        }


        /// <summary>
        /// Validates the first name, last name and the middle names - Only aplhabets allowed
        /// </summary>
        /// <param name="name">Name to be validated</param>
        /// <returns>True if the criteria is Met, else false</returns>
        public bool validate_Names(string name)
        {
            try
            {
                if (name.Length < 30)
                {
                    if (Regex.IsMatch(name, @"^[a-zA-Z]+$"))
                        return true;
                    else
                        return false;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception exp)
            {
                //Log Exception exp
                return false;
            }
        }

        /// <summary>
        /// Validates the Zip Code, Account Number and Card Number and Phone Number
        /// </summary>
        /// <param name="strValue">The fields to be validated</param>
        /// <param name="numofDigits">The number of digits the field can have</param>
        /// <returns>True if the field value is true, false otherwise</returns>
        public bool validate_ZipAccCrdPhn(string strValue, int numofDigits)
        {
            try
            {
                Regex numCodeRegex = new Regex(@"^\d{" + numofDigits + "}$");
                Match numCodeMatch = numCodeRegex.Match(strValue);
                if (numCodeMatch.Success)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception exp)
            {
                //Log Exception exp
                return false;
            }
        }


        /// <summary>
        /// Validates the amount entered by the user with precision of 2.
        /// </summary>
        /// <param name="amt">The amount to be validated</param>
        /// <returns>True if the amount is valid, else false</returns>
        public bool validate_Amount(string amt)
        {
            try
            {
                Regex amountRegex = new Regex(@"^\d+(\.\d{1,2})?$");
                Match amountMatch = amountRegex.Match(amt);
                if (amountMatch.Success)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception exp)
            {
                //Log exception exp
                return false;
            }
        }

        /// <summary>
        /// Transaction description will be validated and only alphanumeric, spaces and commas will be allowed.
        /// </summary>
        /// <param name="desc">The description which has to be validated</param>
        /// <returns>True if the description passes the test.</returns>
        public bool validate_TransactionDesc(string desc)
        {
            try
            {
                Regex descriptionRegex = new Regex(@"^[a-zA-Z0-9_. ,]+$");
                Match descriptionMatch = descriptionRegex.Match(desc);
                if (descriptionMatch.Success)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception exp)
            {
                //Log exception exp
                return false;
            }
        }

        /// <summary>
        /// Validate the given street address and allow alphanumeric, spaces, #, - / _
        /// </summary>
        /// <param name="address">The street address that has to be verified</param>
        /// <returns>True if the street address is valid</returns>
        public bool validate_streetAddress(string streetAddress)
        {
            try
            {

                Regex descriptionRegex = new Regex(@"^[a-zA-Z0-9_.#/- ,]+$");
                Match descriptionMatch = descriptionRegex.Match(streetAddress);
                if (descriptionMatch.Success)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception exp)
            {
                //Log Exception exp
                return false;
            }
        }
    }
}
