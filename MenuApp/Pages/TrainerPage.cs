using System;
using MenuApp.PokeLogic;
using Xamarin.Forms;

namespace MenuApp.Pages
{
    public  class TrainerPage : ContentPage
    {
        public TrainerPage(Trainer trainer)
        {
            Title = trainer.Name;

            var trainerSection = new TableSection("Entrenador") { //TableSection constructor takes title as an optional parameter
                new TextCell {Text = trainer.Name, Detail = "Nombre"},
                new TextCell {Text = trainer.PokemonTypes, Detail = "Tipo"}
            };

            var pokemonSection = new TableSection("Poémon");
            foreach (var pokemon in trainer.Pokemon)
            {
                var cell = new TextCell();
                cell.SetBinding(TextCell.TextProperty, nameof(Pokemon.Name));
                cell.SetBinding(TextCell.DetailProperty, nameof(Pokemon.Type));
                cell.BindingContext = pokemon;
                cell.Tapped += PokemonCell_Tapped;
                pokemonSection.Add(cell);
            }

            var table = new TableView
            {
                Root = new TableRoot {
                    trainerSection,
                    pokemonSection
                },
                Intent = TableIntent.Data
            };

            
            Content = table;
        }

        private async void PokemonCell_Tapped(object sender, EventArgs e)
        {
            var pokemon = ((TextCell) sender).BindingContext as Pokemon;
            if (pokemon != null)
            {
                await Navigation.PushAsync(new PokemonPage(pokemon));
            }
        }
    }
}