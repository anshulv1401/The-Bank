using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using The_Bank.Views;
using The_Bank.Models;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace The_Bank
{
    public partial class App : Application
    {
        public static string DatabaseLocation = string.Empty;
        public static User user = new User();

        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new LoginPage());
        }
        
        public App(String databaseLocation)
        {
            InitializeComponent();
            MainPage = new NavigationPage(new LoginPage());

            DatabaseLocation = databaseLocation;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
