using Newtonsoft.Json;
using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using The_Bank.Views;

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
            get { return confirmPassword; }
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
            HttpClient client;
            client = new HttpClient();

            /*
        try {
            string uri = Constants.RestUrl +
                String.Format
                (
                    "register?name={0}&email={1}&password={2}",
                    user.userName,
                    user.email,
                    user.password
                );

            var request = HttpWebRequest.Create(uri);
            request.Method = "POST";
            request.ContentType = "application/json";
            HttpWebResponse requestResponse = (HttpWebResponse)await request.GetResponseAsync();
            StreamReader sr = new StreamReader(requestResponse.GetResponseStream(), Encoding.UTF8);
            string pageContent = sr.ReadToEnd();
            sr.Close();
            requestResponse.Close();
            if (pageContent.Contains("You are successfully registered"))
            {
                await App.Current.MainPage.DisplayAlert("Success", "Registration Successfull", "Ok");
            }
            else
            {
                await App.Current.MainPage.DisplayAlert("Failure", "Registration failed", "Ok");
            }

            //var uri = new Uri(Constants.RestUrl + "register");

            //StringContent content = new StringContent(String.Format
            //(
            //    "name={0}&email={1}&password={2}",
            //    user.userName,
            //    user.email,
            //    user.password
            //));

            //HttpResponseMessage response = null;
            //response = await client.PostAsync(uri, content);

        } catch (Exception ex) {
            await App.Current.MainPage.DisplayAlert("Failure", "Registration failed", "Ok");
        }
        */

            using (SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
            {
                conn.CreateTable<User>();
                int rows = conn.Insert(user);

                if (rows > 0)
                {
                    await App.Current.MainPage.DisplayAlert("Success", "User registered", "Ok");
                    await App.Current.MainPage.Navigation.PushAsync(new LoginPage());
                }
                else
                    await App.Current.MainPage.DisplayAlert("Failure", "Registration failed, please try again later", "Ok");
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
