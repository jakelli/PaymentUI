using System;
using System.Collections.Generic;
using PaymentUI.ViewModels;
using Xamarin.Forms;

namespace PaymentUI.Views
{
    public partial class CreditCardDisplayView : StackLayout
    {
        public CreditCardDisplayView()
        {
            InitializeComponent();
            this.BindingContext = new CreditCardPageViewModel();
        }
    }
}
