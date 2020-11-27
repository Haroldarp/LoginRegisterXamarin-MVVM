using LoginRegisterXamarin.MVVM.Models;
using LoginRegisterXamarin.MVVM.Views;
using System;
using System.Windows.Input;
using Xamarin.Forms;
namespace LoginRegisterXamarin.MVVM.ViewModels
{
    class LoginViewModel
    {
        public ICommand OnSingUpLinkClick => new Command(async () =>
        {
            await App.Current.MainPage.Navigation.PushAsync(new SingUpPage());
        });

        public User User { get; set; }

        public ICommand OnLoginClick => new Command(async () =>
        {
            if (string.IsNullOrEmpty(User.Email) || string.IsNullOrEmpty(User.Password))
            {
                await App.Current.MainPage.DisplayAlert("Error", "Campo Email y/o contraseña no puede estar vacío", "Ok");
            }
            else
            {
                await App.Current.MainPage.Navigation.PushAsync(new HomePage());
            }
            //App.Current.MainPage.Navigation.InsertPageBefore(new HomePage(),new LoginPage());
            //await App.Current.MainPage.Navigation.PopAsync();
        });

        public LoginViewModel()
        {
            User = new User();
        }
    }
}
