using PaymentUI.Views;
using Xamarin.Forms;

namespace PaymentUI
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new CreditCardPage();
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
