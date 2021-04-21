using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using ZXing.Net.Mobile.Forms;

namespace DemoQR
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnQR_Clicked(object sender, EventArgs e)
        {
            try
            {
                var scanner = new ZXing.Mobile.MobileBarcodeScanner();
                scanner.TopText = "ESCANEANDO";
                scanner.BottomText = "SE REDIRECCIONARA A UNA PAGINA";

                var resultado = await scanner.Scan();

                if (resultado != null)
                {
                    txtResul.Text = resultado.Text;
                }
            }
            catch (Exception ex)
            {

                await DisplayAlert("Error", ex.Message.ToString(), "Ok");
            }
        }
    }
}
