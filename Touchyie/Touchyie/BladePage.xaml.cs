using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Touchyie
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class BladePage : ContentPage
	{
		public BladePage ()
		{
			InitializeComponent ();

            //tap gesture variable en event maken
            var tapPlayVideoImage = new TapGestureRecognizer();
            tapPlayVideoImage.Tapped += TapPlayVideoImage_Tapped;
            //alle video thumbnails worden clackable en leiden naar de playerpage
            playvideo1.GestureRecognizers.Add(tapPlayVideoImage);
            playvideo2.GestureRecognizers.Add(tapPlayVideoImage);
            playvideo3.GestureRecognizers.Add(tapPlayVideoImage);
            playvideo4.GestureRecognizers.Add(tapPlayVideoImage);
            playvideo5.GestureRecognizers.Add(tapPlayVideoImage);
            playvideo6.GestureRecognizers.Add(tapPlayVideoImage);
            playvideo7.GestureRecognizers.Add(tapPlayVideoImage);
            playvideo8.GestureRecognizers.Add(tapPlayVideoImage);
            playvideo9.GestureRecognizers.Add(tapPlayVideoImage);
            playvideo10.GestureRecognizers.Add(tapPlayVideoImage);
            playvideo11.GestureRecognizers.Add(tapPlayVideoImage);
            playvideo12.GestureRecognizers.Add(tapPlayVideoImage);
            playvideo13.GestureRecognizers.Add(tapPlayVideoImage);
            playvideo14.GestureRecognizers.Add(tapPlayVideoImage);
            playvideo15.GestureRecognizers.Add(tapPlayVideoImage);

            //Backbutton image is clickable en leid naar de vorige pagina
            var tapBladerBackButton = new TapGestureRecognizer();
            tapBladerBackButton.Tapped += TapBladerBackButton_Tapped;
            bladerBackButton.GestureRecognizers.Add(tapBladerBackButton);
        }

        private async void TapBladerBackButton_Tapped(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        private async void TapPlayVideoImage_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new PlayerPage());
        }
    }
}