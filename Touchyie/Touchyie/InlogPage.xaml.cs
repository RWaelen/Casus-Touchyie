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

            var tapwachtwoord = new TapGestureRecognizer();
            tapwachtwoord.Tapped += Tapwachtwoord_Tapped;
            wachtwoord.GestureRecognizers.Add(tapwachtwoord);

            var tapregistreren = new TapGestureRecognizer();
            tapregistreren.Tapped += Tapregistreren_Tapped;
            registreren.GestureRecognizers.Add(tapregistreren);

            Button loginbuttontest = Content.FindByName<Button>("loginButton");
       loginbuttontest.Clicked += Loginbutton_Clicked;
		}

        private async void Tapregistreren_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MainPage());
        }

        private async void Tapwachtwoord_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MainPage());
        }

        private async void Loginbutton_Clicked(object sender, EventArgs e)
        {
          await Navigation.PushModalAsync(new MainPage());
        }
       
    }
}