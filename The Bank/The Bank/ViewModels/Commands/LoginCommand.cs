using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using The_Bank.Models;

namespace The_Bank.ViewModels.Commands
{
    class LoginCommand : ICommand
    {
        public LoginViewModel ViewModel { get; set; }

        public LoginCommand(LoginViewModel loginViewModel)
        {
            ViewModel = loginViewModel;
        }
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            var user = (User)parameter;

            if (user == null)
                return false;
            if (string.IsNullOrEmpty(user.Email) || string.IsNullOrEmpty(user.Password))
                return false;

            return true;
        }

        public void Execute(object parameter)
        {
            ViewModel.Login();
        }
    }
}
