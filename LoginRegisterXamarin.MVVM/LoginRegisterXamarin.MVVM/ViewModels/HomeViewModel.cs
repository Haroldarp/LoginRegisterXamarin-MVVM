using LoginRegisterXamarin.MVVM.Models;
using LoginRegisterXamarin.MVVM.Views;
using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace LoginRegisterXamarin.MVVM.ViewModels
{
    class HomeViewModel
    {
        public Topic Topic1 => new Topic()
        {
            Title = "Bars and Hotels",
            ImageUrl = "",
            PlacesNum = 42
        };

        public Topic Topic2 => new Topic()
        {
            Title = "Fine Dining",
            ImageUrl = "",
            PlacesNum = 15
        };

        public Topic Topic3 => new Topic()
        {
            Title = "Cafes",
            ImageUrl = "",
            PlacesNum = 28
        };

        public Topic Topic4 => new Topic()
        {
            Title = "Nearby",
            ImageUrl = "",
            PlacesNum = 34
        };
        public Topic Topic5 => new Topic()
        {
            Title = "Fast Foods",
            ImageUrl = "",
            PlacesNum = 29
        };

        public Topic Topic6 => new Topic()
        {
            Title = "Featured Foods",
            ImageUrl = "",
            PlacesNum = 21
        };

        public HomeViewModel()
        {

        }
    }
}
