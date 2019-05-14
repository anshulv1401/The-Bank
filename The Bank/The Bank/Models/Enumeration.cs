using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace The_Bank.Models
{
    public class Enumeration : INotifyPropertyChanged
    {
        private int enumerationID;
        private string enumerationType;
        private string enumerationName;
        private string enumerationValue;
        private int createdBy;
        private int modifiedBy;
        private DateTime createdDate;
        private DateTime modifiedDate;

        public int EnumerationID
        {
            get { return enumerationID; }
            set
            {
                enumerationID = value;
                OnPropertyChanged("EnumerationID");
            }
        }

        public string EnumerationType
        {
            get { return enumerationType; }
            set
            {
                enumerationType = value;
                OnPropertyChanged("EnumerationType");
            }
        }

        public string EnumerationName
        {
            get { return enumerationName; }
            set
            {
                enumerationName = value;
                OnPropertyChanged("EnumerationName");
            }
        }

        public string EnumerationValue
        {
            get { return enumerationValue; }
            set
            {
                enumerationValue = value;
                OnPropertyChanged("EnumerationValue");
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
