using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MenuApp.Pages.Menu
{
    public class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            var sideMenuPage = new SideMenuPage();
            sideMenuPage.MenuItemSelected += SideMenuPage_MenuItemSelected;
            Master = sideMenuPage;

            Detail = new ContentPage
            {
                Title = "Detail page",
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label{ Text = "Detail page" }
                    }
                }
            };
        }

        private async void SideMenuPage_MenuItemSelected(object sender, Controls.MenuListItem e)
        {
            await DisplayAlert(e.Title, "Menu seleccionado", "Aceptar");
        }
    }
}
