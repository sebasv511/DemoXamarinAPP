using DemoXamarinAPP.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace DemoXamarinAPP.Views
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