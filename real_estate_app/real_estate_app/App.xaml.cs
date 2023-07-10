using real_estate_app.Services;
using real_estate_app.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace real_estate_app
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new main_page();
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
