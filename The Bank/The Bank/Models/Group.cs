using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace The_Bank.Models
{
    public class Group : INotifyPropertyChanged
    {
        private int groupID;

        public int GroupID
        {
            get { return groupID; }
            set
            {
                groupID = value;
                OnPropertyChanged("GroupID");
            }
        }

        private string groupName;

        public string GroupName
        {
            get { return groupName; }
            set
            {
                groupName = value;
                OnPropertyChanged("GroupName");
            }
        }

        private string groupCode;

        public string GroupCode
        {
            get { return groupCode; }
            set
            {
                groupCode = value;
                OnPropertyChanged("GroupCode");
            }
        }

        private double interest;

        public double Interest
        {
            get { return interest; }
            set
            {
                interest = value;
                OnPropertyChanged("Interest");
            }
        }
        
        private double bankInterest;

        public double BankInterest
        {
            get { return bankInterest; }
            set
            {
                bankInterest = value;
                OnPropertyChanged("BankInterest");
            }
        }

        private int groupType;

        public int GroupType
        {
            get { return groupType; }
            set
            {
                groupType = value;
                OnPropertyChanged("GroupType");
            }
        }

        private string groupKey;

        public string GroupKey
        {
            get { return groupKey; }
            set
            {
                groupKey = value;
                OnPropertyChanged("GroupKey");
            }
        }

        private double groupAmount;

        public double GroupAmount
        {
            get { return groupAmount; }
            set
            {
                groupAmount = value;
                OnPropertyChanged("GroupAmount");
            }
        }

        private int createdBy;

        public int CreatedBy
        {
            get { return createdBy; }
            set
            {
                createdBy = value;
                OnPropertyChanged("CreatedBy");
            }
        }

        private int modifiedBy;

        public int ModifiedBy
        {
            get { return modifiedBy; }
            set
            {
                modifiedBy = value;
                OnPropertyChanged("ModifiedBy");
            }
        }


        private DateTime createdDate;

        public DateTime CreatedDate
        {
            get { return createdDate; }
            set
            {
                createdDate = value;
                OnPropertyChanged("CreatedDate");
            }
        }

        private DateTime modifiedDate;

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
