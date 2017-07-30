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

        private void SideMenuPage_MenuItemSelected(object sender, Controls.MenuListItem e)
        {
            MenuNavigationPage page;
            var actualContentPage = (Page)Activator.CreateInstance(e.Page);
            page = new MenuNavigationPage(actualContentPage);
            page.InitialPageAppearing += Page_InitialPageAppearing;
            page.InitialPageDisappearing += Page_InitialPageDisappearing;
            Detail = page;
            IsPresented = false;
        }

        private void Page_InitialPageDisappearing(object sender, EventArgs e)
        {
            IsGestureEnabled = false;
        }

        private void Page_InitialPageAppearing(object sender, EventArgs e)
        {
            IsGestureEnabled = true;
        }
    }
}
