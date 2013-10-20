using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SoftSec_BankingApp_Se7en.Models.Tables
{
    public class Department
    {
        public Department()
        {
            this.DepartmentTransactions = new HashSet<DepartmentTransaction>();
        }

        public int id { get; set; }
        public string title { get; set; }

        private ICollection<DepartmentTransaction> _departmentTransactions;
        [NotMapped]
        public virtual ICollection<DepartmentTransaction> DepartmentTransactions
        {
            get
            {
                using (var db = new SSBankDBContext())
                {
                    ICollection<DepartmentTransaction> departmentTransactions = db.DepartmentTransactions.SqlQuery("SELECT * FROM dbo.DepartmentTransactions WHERE fromDepartmentId = @p0 OR toDepartmentId = @p0", id).ToList();
                    return departmentTransactions;
                }
            }
            set
            {
                _departmentTransactions = value;
            }
        }
    }
}