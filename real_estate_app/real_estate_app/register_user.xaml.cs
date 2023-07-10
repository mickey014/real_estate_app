using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace real_estate_app
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class register_user : ContentPage
    {
        public register_user()
        {
            InitializeComponent();
        }

        private async void LoginTap_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new main_page());
        }
    }
}