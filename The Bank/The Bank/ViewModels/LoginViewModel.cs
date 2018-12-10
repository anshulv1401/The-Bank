using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using The_Bank.Models;
using The_Bank.ViewModels.Commands;
using The_Bank.Views;

namespace The_Bank.ViewModels
{
    class LoginViewModel : INotifyPropertyChanged
    {

        public LoginCommand LoginCommand { get; set; }

        public RegisterNavigationCommand RegisterNavigationCommand { get; set; }

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

        private string email;

        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                User = new User()
                {
                    Email = this.Email,
                    Password = this.password
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
                    Email = this.Email,
                    Password = this.password
                };
                OnPropertyChanged("Password");
            }
        }

        public LoginViewModel()
        {
            User = new User();
            LoginCommand = new LoginCommand(this);
            RegisterNavigationCommand = new RegisterNavigationCommand(this);
        }

        public async void Login()
        {
            bool canLogin = await User.Login(User.Email, User.Password);

            if (canLogin)
                await App.Current.MainPage.Navigation.PushAsync(new MainPage());
            else
                await App.Current.MainPage.DisplayAlert("Error", "Email or Password is incorrect", "Ok");
        }

        public async void Navigate()
        {
            await App.Current.MainPage.Navigation.PushAsync(new RegisterPage());
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(String propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
