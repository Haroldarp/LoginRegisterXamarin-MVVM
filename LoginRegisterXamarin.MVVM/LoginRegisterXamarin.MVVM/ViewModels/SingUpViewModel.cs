using LoginRegisterXamarin.MVVM.Models;
using LoginRegisterXamarin.MVVM.Views;
using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace LoginRegisterXamarin.MVVM.ViewModels
{
    class SingUpViewModel
    {
        public SingUpUser User { get; set; }

        public SingUpViewModel()
        {
            User = new SingUpUser();
        }


        public ICommand OnRegisterClick => new Command(async () =>
        {
          
            if (string.IsNullOrEmpty(User.Name) || string.IsNullOrEmpty(User.Email) ||
                string.IsNullOrEmpty(User.Password) || string.IsNullOrEmpty(User.ConfirmPassword))
            {
                await App.Current.MainPage.DisplayAlert("Error", "No puede haber ningun campo vacio", "Ok");
            }
            else
            {
                if (User.Password != User.ConfirmPassword)
                {
                    await App.Current.MainPage.DisplayAlert("Error", "Las contraseñas no coinciden", "Ok");
                }
                else
                {
                    await App.Current.MainPage.DisplayAlert("Bienvenido", $"Hola {User.Name}!", "Ok");
                }
            }
        });
       
    }
}
