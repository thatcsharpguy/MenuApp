using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenuApp.Pages;
using Xamarin.Forms;

namespace MenuApp.Controls
{
    public class MenuListView : ListView
    {
        public MenuListView()
        {
            // TODO: Setup menus
            var menus = new List<MenuListItem>
            {
                new MenuListItem
                {
                    Title = "Gimnasios",
                    Icon = "gym.png",
                    Page = typeof(GymsPage)
                },
                new MenuListItem
                {
                    Title = "Elite 4",
                    Icon = "elite.png",
                    Page = typeof(EliteFourPage)
                },
                new MenuListItem
                {
                    Title = "Tipos pokemon",
                    Icon = "types.png",
                    Page = typeof(PokemonTypesPage)
                }
            };

            ItemsSource = menus;


            var cellTemplate = new DataTemplate(typeof(MenuListItemCell));
            cellTemplate.SetBinding(TextCell.TextProperty, nameof(MenuListItem.Title));
            cellTemplate.SetBinding(ImageCell.ImageSourceProperty, nameof(MenuListItem.Icon));

            ItemTemplate = cellTemplate;
        }
    }
}
