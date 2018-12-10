using System;
using System.Collections.Generic;
using System.Text;

namespace The_Bank.Models
{
    public class Transactions
    {
        public int transactionID { get; set; }
        public int groupID { get; set; }
        public int userID { get; set; }
        public int transactionTypeID { get; set; }
        public DateTime transactionDate { get; set; }
        public double amount { get; set; }
        public int createdBy { get; set; }
        public int modifiedBy { get; set; }
        public DateTime createdDate { get; set; }
        public DateTime modifiedDate { get; set; }
    }
}
