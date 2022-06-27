using Flwr.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Flwr.Views
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