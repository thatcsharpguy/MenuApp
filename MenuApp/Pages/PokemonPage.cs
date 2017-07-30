using MenuApp.PokeLogic;
using Xamarin.Forms;

namespace MenuApp.Pages
{
    public class PokemonPage : ContentPage
    {
        public PokemonPage(Pokemon pokemon)
        {
            Title = pokemon.Name;

            var list = new ListView();
            list.ItemsSource = pokemon.Attacks;

            Content = list;
        }
    }
}