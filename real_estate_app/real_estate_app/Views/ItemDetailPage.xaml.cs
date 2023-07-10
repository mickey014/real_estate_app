using real_estate_app.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace real_estate_app.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}