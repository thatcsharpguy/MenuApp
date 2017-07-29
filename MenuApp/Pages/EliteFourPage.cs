using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenuApp.PokeLogic;
using Xamarin.Forms;

namespace MenuApp.Pages
{
    public class EliteFourPage : ContentPage
    {
        public EliteFourPage()
        {
            Title = "Elite 4";

            var list = new ListView {ItemTemplate = new DataTemplate(typeof(TextCell))};
            list.ItemTemplate.SetBinding(TextCell.TextProperty, nameof(Trainer.Name));
            list.ItemTemplate.SetBinding(TextCell.DetailProperty, nameof(Trainer.PokemonTypes));
            list.ItemsSource = Data.EliteTrainers;

            Content = list;
        }
    }
}
