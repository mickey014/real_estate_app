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
    public partial class main_page : ContentPage
    {
        public main_page()
        {
            InitializeComponent();
        }

        private async void RegisterTap_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new register_user());
        }
    }
}