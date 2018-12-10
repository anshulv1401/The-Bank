using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using The_Bank.Models;

namespace The_Bank.ViewModels.Commands
{
    class RegisterNavigationCommand : ICommand
    {
        public LoginViewModel ViewModel { get; set; }

        public RegisterNavigationCommand(LoginViewModel loginViewModel)
        {
            ViewModel = loginViewModel;
        }
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            ViewModel.Navigate();
        }
    }
}
