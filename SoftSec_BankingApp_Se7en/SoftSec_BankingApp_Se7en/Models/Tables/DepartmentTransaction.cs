using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoftSec_BankingApp_Se7en.Models.Tables
{
    public class DepartmentTransaction
    {
        public int id { get; set; }
        public int type { get; set; }
        public string fromDepartmentId { get; set; }
        public string toDepartmentId { get; set; }
        public string usernameInitiated { get; set; }
        public string usernameEffected { get; set; }
        public int? roleOld { get; set; }
        public int? roleNew { get; set; }
        public string description { get; set; }
        public int status { get; set; }
        public int? isCritical { get; set; }
        public string mustBeAuthorizedByUserName { get; set; }
        public System.DateTimeOffset? processedTime { get; set; }
        public System.DateTimeOffset creationTime { get; set; }
    }
}