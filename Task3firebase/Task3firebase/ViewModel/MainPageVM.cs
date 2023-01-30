using System;
using System.ComponentModel;
using Task3firebase.View;
using Xamarin.Forms;

namespace Task3firebase.ViewModel
{
    public class MainPageVM : INotifyPropertyChanged
    {
          private string _username;
            public string username
            {
                get
                {
                    return _username;
                }
                set
                {
                    _username = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("username"));
                }
            }
            private string _password;
            public string password
            {
                get
                {
                    return _password;
                }
                set
                {
                    _password = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("password"));
                }
            }
            public MainPageVM()
            {
            }
            public Command MainPageLoginCommand
            {
                get
                {
                    return new Command(MainPageLogin);
                }
            }
            public Command SignUpCommand
        {
            get
            {
                return new Command(SignUp);
            }
        }
            private void MainPageLogin()
            {
                if (username.Length.Equals(8) && password.Length.Equals(8))
                {
                    foreach (char c in password)
                    {
                        if (c >= 48 && c <= 58)
                        {
                            foreach (char d in password)
                            {
                                if (d >= 65 && d <= 90)
                                {
                                    foreach (char e in password)
                                    {
                                        if (e >= 97 && e <= 122)
                                        {
                                            foreach (char f in password)
                                            {
                                                if (f == '@' || f == '#' || f == '$' || f == '&' || f == '*')
                                                {
                                                    App.Current.MainPage.Navigation.PushAsync(new LoginPage());
                                                    return;
                                                }
                                            }
                                            App.Current.MainPage.DisplayAlert("Failed", "password should have spl character", "Ok");
                                            return;
                                        }
                                    }
                                    App.Current.MainPage.DisplayAlert("Failed", "password should have lowercase letter", "Ok");
                                    return;
                                }
                            }
                            App.Current.MainPage.DisplayAlert("Failed", "password should have uppercase letters", "Ok");
                            return;
                        }
                    }
                    App.Current.MainPage.DisplayAlert("Failed", "password should have numbers", "Ok");
                    return;

                }

                else
                    App.Current.MainPage.DisplayAlert("Failed", "Username and password length should be 8", "Ok");

            }
            private void SignUp()
            {
                App.Current.MainPage.Navigation.PushAsync(new View.SignUpPage());
            }
            public event PropertyChangedEventHandler PropertyChanged;
        }
    }
