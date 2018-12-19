using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Bank.Models
{
    public class User : INotifyPropertyChanged
    {
        private int userId;

        public int UserId
        {
            get { return userId;}
            set
            {
                userId = value;
                OnPropertyChanged("UserId");
            }
        }

        private string userName;

        public string UserName
        {
            get { return userName; }
            set
            {
                userName = value;
                OnPropertyChanged("UserName");
            }
        }

        private string email;

        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                OnPropertyChanged("Email");
            }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                OnPropertyChanged("Password");
            }
        }

        private string confirmPassword;

        public string ConfirmPassword
        {
            get { return ConfirmPassword; }
            set
            {
                confirmPassword = value;
                OnPropertyChanged("ConfirmPassword");
            }
        }

        private string api_key;

        public string Api_key
        {
            get { return api_key; }
            set
            {
                api_key = value;
                OnPropertyChanged("Api_key");
            }
        }

        private bool isActive;

        public bool IsActive
        {
            get { return isActive; }
            set
            {
                isActive = value;
                OnPropertyChanged("IsActive");
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

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName)); 
        }

        public static async void Register(User user)
        {
            using (SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
            {
                conn.CreateTable<User>();
                int rows = conn.Insert(user);

                if (rows > 0)
                    await App.Current.MainPage.DisplayAlert("Success", "User registered", "Ok");
                else
                    await App.Current.MainPage.DisplayAlert("Failure", "Registration failed", "Ok");
                conn.Close();
            }
        }

        public static async Task<bool> Login(string email, string password)
        {
            bool isEmailEmpty = string.IsNullOrEmpty(email);
            bool isPasswordEmpty = string.IsNullOrEmpty(password);

            if (isEmailEmpty || isPasswordEmpty)
            {
                return false;
            }
            else
            {
                using (SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
                {
                    var userTable = conn.Table<User>().ToList();

                    User us = (from u in userTable
                                where u.Email == email && u.Password == password
                                      select u).FirstOrDefault();
                    if(us != null)
                    {
                        App.user = us;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
    }
}
