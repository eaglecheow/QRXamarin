using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using ZXing.Net.Mobile.Forms;
using ZXing.QrCode;

namespace QRXamarin
{
	public partial class MainPage : ContentPage
	{
	    public QrCodeEncodingOptions QROptions { get; set; }

		public MainPage()
		{
			InitializeComponent();
		}

	    private async void Button_OnClicked(object sender, EventArgs e)
	    {
	        var scannerPage = new ZXingScannerPage();
	        await Navigation.PushAsync(scannerPage);

	        scannerPage.OnScanResult += (result) =>
	        {
	            scannerPage.IsScanning = false;
	            Device.BeginInvokeOnMainThread(async () =>
	            {
	                await Navigation.PopAsync();
	                await DisplayAlert("Scanned Detail", result.Text, "OK");
	            });
	        };

            QRCode.BarcodeOptions = new QrCodeEncodingOptions()
            {
                Height = 500,
                Width = 500
            };
	    }

	}
}
