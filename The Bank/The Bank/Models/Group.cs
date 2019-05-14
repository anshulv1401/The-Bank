using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace The_Bank.Models
{
    public class Group : INotifyPropertyChanged
    {
        private int groupID;
        private string groupName;
        private string groupCode;
        private double interest;
        private double bankInterest;
        private int groupType;
        private string groupKey;
        private double groupAmount;
        private int createdBy;
        private int modifiedBy;
        private DateTime createdDate;
        private DateTime modifiedDate;

        public int GroupID
        {
            get { return groupID; }
            set
            {
                groupID = value;
                OnPropertyChanged("GroupID");
            }
        }

        public string GroupName
        {
            get { return groupName; }
            set
            {
                groupName = value;
                OnPropertyChanged("GroupName");
            }
        }

        public string GroupCode
        {
            get { return groupCode; }
            set
            {
                groupCode = value;
                OnPropertyChanged("GroupCode");
            }
        }

        public double Interest
        {
            get { return interest; }
            set
            {
                interest = value;
                OnPropertyChanged("Interest");
            }
        }

        public double BankInterest
        {
            get { return bankInterest; }
            set
            {
                bankInterest = value;
                OnPropertyChanged("BankInterest");
            }
        }

        public int GroupType
        {
            get { return groupType; }
            set
            {
                groupType = value;
                OnPropertyChanged("GroupType");
            }
        }

        public string GroupKey
        {
            get { return groupKey; }
            set
            {
                groupKey = value;
                OnPropertyChanged("GroupKey");
            }
        }

        public double GroupAmount
        {
            get { return groupAmount; }
            set
            {
                groupAmount = value;
                OnPropertyChanged("GroupAmount");
            }
        }

        public int CreatedBy
        {
            get { return createdBy; }
            set
            {
                createdBy = value;
                OnPropertyChanged("CreatedBy");
            }
        }

        public int ModifiedBy
        {
            get { return modifiedBy; }
            set
            {
                modifiedBy = value;
                OnPropertyChanged("ModifiedBy");
            }
        }

        public DateTime CreatedDate
        {
            get { return createdDate; }
            set
            {
                createdDate = value;
                OnPropertyChanged("CreatedDate");
            }
        }

        public DateTime ModifiedDate
        {
            get { return modifiedDate; }
            set
            {
                modifiedDate = value;
                OnPropertyChanged("ModifiedDate");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(String propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
