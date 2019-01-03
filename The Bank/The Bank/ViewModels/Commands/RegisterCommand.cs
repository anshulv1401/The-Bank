using System;
using System.Windows.Input;
using The_Bank.Models;

namespace The_Bank.ViewModels
{
    public class RegisterCommand : ICommand
    {
        public RegisterViewModel ViewModel { get; set; }

        public event EventHandler CanExecuteChanged;

        public RegisterCommand(RegisterViewModel registerViewModel)
        {
            ViewModel = registerViewModel;
        }
        public bool CanExecute(object parameter)
        {
            var user = (User)parameter;
            
            if (user != null)
            {
                if (user.Password == user.ConfirmPassword)
                {
                    if (string.IsNullOrEmpty(user.Email) || string.IsNullOrEmpty(user.Password))
                        return false;
                    return true;
                }
                return false;
            }
            return false;
        }

        public void Execute(object parameter)
        {
            User user = (User)parameter;
            ViewModel.Register(user);
        }
    }
}