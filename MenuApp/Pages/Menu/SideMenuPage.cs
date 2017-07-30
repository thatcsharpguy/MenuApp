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

        public event EventHandler<MenuListItem> MenuItemSelected;

        public SideMenuPage()
        {
            Title = "Pokémon";
            if(Device.RuntimePlatform == Device.iOS)
            {
                Icon = "menu.png";    
            }

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
            menuList.ItemSelected += InternalMenuItemSelected;

            containerGrid.Children.Add(titleLabel);
            containerGrid.Children.Add(menuList, 0, 1);

            Content = containerGrid;
        }

        private void InternalMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var menuItem = e.SelectedItem as MenuListItem;
            if (menuItem != null)
            {
                MenuItemSelected?.Invoke(this, menuItem);
                ((MenuListView) sender).SelectedItem = null;;
            }
        }
    }
}
