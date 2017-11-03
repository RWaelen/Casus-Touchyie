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
    public partial class NetflixPage : ContentPage
	{
		public NetflixPage ()
		{
			InitializeComponent ();
            var TapBackButton = new TapGestureRecognizer();
            TapBackButton.Tapped += TapBackButton_Tapped;
            NFBackButton.GestureRecognizers.Add(TapBackButton);

            var TapVideoButton = new TapGestureRecognizer();
            TapVideoButton.Tapped += TapVideoButton_Tapped;
            Video1.GestureRecognizers.Add(TapVideoButton);
            Video2.GestureRecognizers.Add(TapVideoButton);
            Video3.GestureRecognizers.Add(TapVideoButton);
            Video4.GestureRecognizers.Add(TapVideoButton);
            Video5.GestureRecognizers.Add(TapVideoButton);
            Video.GestureRecognizers.Add(TapVideoButton);
        }

        private async void TapVideoButton_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new PlayerPage());
        }

        private async void TapBackButton_Tapped(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}