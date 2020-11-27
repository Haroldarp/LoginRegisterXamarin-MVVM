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
            ImageUrl = "beer.png",
            PlacesNum = 42
        };

        public Topic Topic2 => new Topic()
        {
            Title = "Fine Dining",
            ImageUrl = "dining.png",
            PlacesNum = 15
        };

        public Topic Topic3 => new Topic()
        {
            Title = "Cafes",
            ImageUrl = "cafe.png",
            PlacesNum = 28
        };

        public Topic Topic4 => new Topic()
        {
            Title = "Nearby",
            ImageUrl = "nearby.png",
            PlacesNum = 34
        };
        public Topic Topic5 => new Topic()
        {
            Title = "Fast Foods",
            ImageUrl = "fastfood.png",
            PlacesNum = 29
        };

        public Topic Topic6 => new Topic()
        {
            Title = "Featured Foods",
            ImageUrl = "pizza.png",
            PlacesNum = 21
        };

        public HomeViewModel()
        {

        }
    }
}
