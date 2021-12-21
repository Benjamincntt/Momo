using Momo.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Momo.Views
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