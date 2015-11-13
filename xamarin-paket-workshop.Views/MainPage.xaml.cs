using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Prism.Mvvm;

namespace xamarinpaketworkshop.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();
        }
    }
}

