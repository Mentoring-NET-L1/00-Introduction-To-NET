using System;
using Hello.Library;
using Xamarin.Forms;

namespace Hello.Xamarin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void HelloButton_OnClicked(object sender, EventArgs e)
        {
            DisplayAlert("Hello!", HelloHelper.SayHello(TxbInput.Text), "OK");
        }
    }
}
