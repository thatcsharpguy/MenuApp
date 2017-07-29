using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenuApp.Controls;
using Xamarin.Forms;

namespace MenuApp.Pages.Menu
{
    public class SideMenuPage : ContentPage
    {
        public SideMenuPage()
        {
            Title = "Pokémon";

            var containerGrid = new Grid
            {
                RowDefinitions =
                {
                    new RowDefinition {Height = new GridLength(1, GridUnitType.Auto)},
                    new RowDefinition {Height = new GridLength(1, GridUnitType.Star)}
                }
            };

            var titleLabel = new Label()
            {
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                Text = Title,
                HorizontalTextAlignment = TextAlignment.Center,
                Margin = 10
            };

            var menuList = new MenuListView();

            containerGrid.Children.Add(titleLabel);
            containerGrid.Children.Add(menuList, 0, 1);

            Content = containerGrid;
        }
    }
}
