using System;
using System.Collections.Generic;
using System.Text;

namespace The_Bank.Models
{
    public class UserGroupMapping
    {
        public int userID { get; set; }
        public int groupID { get; set; }
        public int userGroupID { get; set; }
        public int userType { get; set; }
        public double userLoanAmount { get; set; }
        public double userAmount { get; set; }
        public int createdBy { get; set; }
        public int modifiedBy { get; set; }
        public DateTime createdDate { get; set; }
        public DateTime modifiedDate { get; set; }
    }
}
