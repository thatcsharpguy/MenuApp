using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenuApp.PokeLogic;
using Xamarin.Forms;

namespace MenuApp.Pages
{
    public class PokemonTypesPage : ContentPage
    {
        public PokemonTypesPage()
        {
            Title = "Tipos de pokemon";

            var list = new ListView { ItemTemplate = new DataTemplate(typeof(TextCell)) };
            list.ItemsSource = Data.PokemonTypes;

            Content = list;
        }
    }
}
