using SoftSec_BankingApp_Se7en.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoftSec_BankingApp_Se7en.Models
{
    public class CardModel
    {
        public static User UserForCard(string cardNumber)
        {
            try
            {
                using (var db = new SSBankDBContext())
                {
                    List<Card> cards = db.Cards.SqlQuery("SELECT * FROM dbo.Cards WHERE cardNumber = @p0", cardNumber).ToList();

                    if (cards.Count() < 1)
                    {
                        return null;
                    }

                    Card card = cards.First();
                    Tables.Account account = card.Account;
                    User user = account.User;

                    return user;
                }
            }
            catch (Exception exp)
            {
                //Log exception here
                return null;
            }
        }
    }
}