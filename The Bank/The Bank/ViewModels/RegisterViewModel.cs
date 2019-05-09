using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using The_Bank.Models;

namespace The_Bank.ViewModels
{
    public class RegisterViewModel : INotifyPropertyChanged
    {
        public RegisterCommand RegisterCommand { get; set; }

        private User user;

        public User User
        {
            get { return user; }
            set
            {
                user = value;
                OnPropertyChanged("User");
            }
        }

        private string userName;

        public string UserName
        {
            get { return userName; }
            set
            {
                userName = value;
                User = new User()
                {
                    UserName = this.UserName,
                    Email = this.Email,
                    Password = this.Password,
                    ConfirmPassword = this.ConfirmPassword
                };
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
                User = new User()
                {
                    UserName = this.UserName,
                    Email = this.Email,
                    Password = this.Password,
                    ConfirmPassword = this.ConfirmPassword
                };
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
                User = new User()
                {
                    UserName = this.UserName,
                    Email = this.Email,
                    Password = this.Password,
                    ConfirmPassword = this.ConfirmPassword
                };
                OnPropertyChanged("Password");
            }
        }

        private string confirmPassword;

        public string ConfirmPassword
        {
            get { return confirmPassword; }
            set
            {
                confirmPassword = value;
                User = new User()
                {
                    UserName = this.UserName,
                    Email = this.Email,
                    Password = this.Password,
                    ConfirmPassword = this.ConfirmPassword
                };
                OnPropertyChanged("ConfirmPassword");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public RegisterViewModel()
        {
            RegisterCommand = new RegisterCommand(this);
        }

        public async void Register(User user)
        {
            User.Register(user);
        }
    }
}
