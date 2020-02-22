using PaymentUI.ViewModels;
using Xamarin.Forms;

namespace PaymentUI.Views
{
    public partial class CreditCardPage : ContentPage
    {
        public CreditCardPage()
        {
            InitializeComponent();
            this.BindingContext = new CreditCardPageViewModel();
        }
    }
}
