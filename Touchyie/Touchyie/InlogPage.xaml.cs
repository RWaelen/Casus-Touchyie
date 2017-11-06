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
	public partial class InlogPage : ContentPage
	{
		public InlogPage ()
		{
			InitializeComponent ();

            //hier maak je mogelijk om de label wachtwoord vergeten te klikken
            var tapwachtwoord = new TapGestureRecognizer();
            tapwachtwoord.Tapped += Tapwachtwoord_Tapped;
            wachtwoord.GestureRecognizers.Add(tapwachtwoord);

            //Hier maak je mogelijk om de label registreren te klikken
            var tapregistreren = new TapGestureRecognizer();
            tapregistreren.Tapped += Tapregistreren_Tapped;
            registreren.GestureRecognizers.Add(tapregistreren);

            //hier maak je mogelijk om een event gebeuren als je klikt op de loginbutton
            Button loginbuttontest = Content.FindByName<Button>("loginButton");
       loginbuttontest.Clicked += Loginbutton_Clicked;
		}

        //Hier kies je wat de event zal zijn als je de registreren label klikt
        private async void Tapregistreren_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new RegistratiePage());
        }
        //Hier kies je wat de event zal zijn als je de 'wachtwoord vergeten' label klikt
        private async void Tapwachtwoord_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MainPage());
        }
        //Hier kies je wat de event zal zijn als je de login button klikt
        private async void Loginbutton_Clicked(object sender, EventArgs e)
        {
          await Navigation.PushModalAsync(new MainPage());
        }
       
    }
}