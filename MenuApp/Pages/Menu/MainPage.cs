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
        private Dictionary<Type, MenuNavigationPage> _pages;

        public MainPage()
        {
            _pages = new Dictionary<Type, MenuNavigationPage>();

            var sideMenuPage = new SideMenuPage();
            sideMenuPage.MenuItemSelected += SideMenuPage_MenuItemSelected;
            Master = sideMenuPage;

            var elite4Page = new MenuNavigationPage(new EliteFourPage());
            elite4Page.InitialPageAppearing += Page_InitialPageAppearing;
            elite4Page.InitialPageDisappearing += Page_InitialPageDisappearing;

            _pages.Add(typeof(EliteFourPage), elite4Page);

            Detail = elite4Page;
        }

        private void SideMenuPage_MenuItemSelected(object sender, Controls.MenuListItem e)
        {
            MenuNavigationPage page;
            if (!_pages.TryGetValue(e.Page, out page))
            {
                var actualContentPage = (Page)Activator.CreateInstance(e.Page);
                page = new MenuNavigationPage(actualContentPage);
                page.InitialPageAppearing += Page_InitialPageAppearing;
                page.InitialPageDisappearing += Page_InitialPageDisappearing;
                _pages.Add(e.Page, page);
            }
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
