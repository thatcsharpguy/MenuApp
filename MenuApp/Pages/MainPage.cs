using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MenuApp.Pages
{
    public class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            Master = new ContentPage
            {
                Title= "Master page",
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label{ Text = "Master page" }
                    }
                }
            };

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
    }
}
