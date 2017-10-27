using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Touchyie
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            
            //--Make image buttons--//
            var tapTvImage = new TapGestureRecognizer();
            tapTvImage.Tapped += tapTvImage_Tapped;
            tvButton.GestureRecognizers.Add(tapTvImage);

            var tapNetflixImage = new TapGestureRecognizer();
            tapNetflixImage.Tapped += TapNetflixImage_Tapped;            
            netflixButton.GestureRecognizers.Add(tapNetflixImage);

            var tapYoutubeImage = new TapGestureRecognizer();
            tapYoutubeImage.Tapped += TapYoutubeImage_Tapped; ;
            youtubeButton.GestureRecognizers.Add(tapYoutubeImage);

            var tapProfileImage = new TapGestureRecognizer();
            tapProfileImage.Tapped += TapProfileImage_Tapped;
            profiel_foto.GestureRecognizers.Add(tapProfileImage);

            var tapBackButtonImage = new TapGestureRecognizer();
            tapBackButtonImage.Tapped += TapBackButtonImage_Tapped;
            BackButton.GestureRecognizers.Add(tapBackButtonImage);

        }

        private async void TapBackButtonImage_Tapped(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        private async void TapProfileImage_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ProfilePage());
        }

        private async void TapYoutubeImage_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new YoutubePage());
        }

        private async void TapNetflixImage_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NetflixPage());
        }

        private async void tapTvImage_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new TvPage());
        }
    }
}
