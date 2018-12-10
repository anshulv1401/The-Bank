using System;
using System.Collections.Generic;
using System.Text;

namespace The_Bank.Models
{
    public class Enumeration
    {
        public int enumerationID { get; set; }
        public string enumerationType { get; set; }
        public string enumerationName { get; set; }
        public string enumerationValue { get; set; }
        public int createdBy { get; set; }
        public int modifiedBy { get; set; }
        public DateTime createdDate { get; set; }
        public DateTime modifiedDate { get; set; }
    }
}
