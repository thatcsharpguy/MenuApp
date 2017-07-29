using System;
using Xamarin.Forms;

namespace MenuApp.Pages
{
    public class MenuNavigationPage : NavigationPage
    {
        private readonly Page _landingPage;

        public MenuNavigationPage(Page root) : base(root)
        {
            _landingPage = root;
            _landingPage.Appearing += PageAppearing;
            _landingPage.Disappearing += PageDisappearing;
        }

        public event EventHandler InitialPageAppearing;
        public event EventHandler InitialPageDisappearing;

        private void PageDisappearing(object sender, EventArgs e)
        {
            InitialPageDisappearing?.Invoke(sender, e);
        }

        private void PageAppearing(object sender, EventArgs e)
        {
            InitialPageAppearing?.Invoke(sender, e);
        }
    }
}
