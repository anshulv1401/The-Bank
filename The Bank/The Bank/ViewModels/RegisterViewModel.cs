using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using The_Bank.Models;

namespace The_Bank.ViewModels
{
    public class RegisterViewModel : INotifyPropertyChanged
    {
        User user;
        string password;
        string confirmPassword;
        string email;

        public RegisterCommand RegisterCommand { get; set; }

        public User User
        {
            get { return user; }
            set
            {
                user = value;
                OnPropertyChanged("User");
            }
        }
        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                User = new User()
                {
                    Email = this.Email,
                    Password = this.Password,
                    ConfirmPassword = this.ConfirmPassword
                };
                OnPropertyChanged("Email");
            }
        }
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                User = new User()
                {
                    Email = this.Email,
                    Password = this.Password,
                    ConfirmPassword = this.ConfirmPassword
                };
                OnPropertyChanged("Password");
            }
        }
        public string ConfirmPassword
        {
            get { return confirmPassword; }
            set
            {
                confirmPassword = value;
                User = new User()
                {
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
