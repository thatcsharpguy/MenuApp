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

            var trainerList = new ListView {ItemTemplate = new DataTemplate(typeof(TextCell))};
            trainerList.ItemTemplate.SetBinding(TextCell.TextProperty, nameof(Trainer.Name));
            trainerList.ItemTemplate.SetBinding(TextCell.DetailProperty, nameof(Trainer.PokemonTypes));
            trainerList.ItemsSource = Data.EliteTrainers;

            trainerList.ItemSelected += TrainerList_ItemSelected;

            Content = trainerList;
        }

        private async void TrainerList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var trainer = e.SelectedItem as Trainer;
            if(trainer != null)
            {
                ((ListView)sender).SelectedItem = null;
                await Navigation.PushAsync(new TrainerPage(trainer));
                ((ListView) sender).SelectedItem = null;
            }
        }
    }
}
