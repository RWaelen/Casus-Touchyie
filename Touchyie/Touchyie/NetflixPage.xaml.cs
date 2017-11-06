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
            //Dit is de backbbutton waar de gebruiker op kan klikken
            var TapBackButton = new TapGestureRecognizer();
            TapBackButton.Tapped += TapBackButton_Tapped;
            NFBackButton.GestureRecognizers.Add(TapBackButton);
            //Dit zijn alle verschillende video's waar de gebruiker op kan klikken
            var TapVideoButton = new TapGestureRecognizer();
            TapVideoButton.Tapped += TapVideoButton_Tapped;
            Video1.GestureRecognizers.Add(TapVideoButton);
            Video2.GestureRecognizers.Add(TapVideoButton);
            Video3.GestureRecognizers.Add(TapVideoButton);
            Video4.GestureRecognizers.Add(TapVideoButton);
            Video5.GestureRecognizers.Add(TapVideoButton);
            Video6.GestureRecognizers.Add(TapVideoButton);
            //Dit is de bladerbbutton waar de gebruiker op kan klikken
            Button bladeren = Content.FindByName<Button>("bladerButton");
            bladeren.Clicked += Bladeren_Clicked;
            //Dit is de zoekbutton waar de gebruiker op kan klikken
            Button zoeken = Content.FindByName<Button>("zoekButton");
            zoeken.Clicked += Zoeken_Clicked;
        }
        //Deze  actie verwijst de gebruiker naar de zoekpagina
        private async void Zoeken_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new SearchResultPage());
        }
        //Deze  actie verwijst de gebruiker naar de bladerpagina
        private async void Bladeren_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new BladePage());
        }


        //Deze  actie verwijst de gebruiker naar de videoplayerpagina
        private async void TapVideoButton_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new PlayerPage());
        }
        //Deze actie verwijst de gebruiker terug naar de vorige pagina
        private async void TapBackButton_Tapped(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}