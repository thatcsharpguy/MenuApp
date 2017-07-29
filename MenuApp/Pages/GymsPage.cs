using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenuApp.PokeLogic;
using Xamarin.Forms;

namespace MenuApp.Pages
{
    public class GymsPage : ContentPage
    {
        public GymsPage()
        {
            Title = "Gimnasios";

            var list = new ListView { ItemTemplate = new DataTemplate(typeof(TextCell)) };
            list.ItemTemplate.SetBinding(TextCell.TextProperty, nameof(Gym.City));
            list.ItemTemplate.SetBinding(TextCell.DetailProperty, nameof(Gym.Type));
            list.ItemsSource = Data.Gyms;

            Content = list;
        }
    }
}
