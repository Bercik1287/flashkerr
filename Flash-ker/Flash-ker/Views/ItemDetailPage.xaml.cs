using Flash_ker.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Flash_ker.Views
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