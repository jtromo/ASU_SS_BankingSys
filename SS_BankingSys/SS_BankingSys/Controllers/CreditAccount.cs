//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SS_BankingSys.Controllers
{
    using System;
    using System.Collections.Generic;
    
    public partial class CreditAccount
    {
        public int id { get; set; }
        public int accountNumber { get; set; }
        public double creditLimit { get; set; }
        public int paymentDueDay { get; set; }
        public double interestRate { get; set; }
    
        public virtual Account Account { get; set; }
    }
}
