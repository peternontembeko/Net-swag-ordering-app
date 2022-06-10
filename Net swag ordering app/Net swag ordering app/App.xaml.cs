using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Net_swag_ordering_app
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var page = new NavigationPage(new SwaggPage());
            page.BarTextColor = Color.White;
            page.BarBackgroundColor = Color.Lightblue;
            //(Color)App.Current.Resources[primaryblue];
            MainPage = page;

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }


        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
