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
	public partial class RegistratiePage : ContentPage
	{
		public RegistratiePage ()
		{
			InitializeComponent ();
            var tapRegtBackButton = new TapGestureRecognizer();
            tapRegtBackButton.Tapped += TapRegtBackButton_Tapped;
            RegtBackButton.GestureRecognizers.Add(tapRegtBackButton);

            Button regtButton = Content.FindByName<Button>("registratieButton");
            regtButton.Clicked += RegtButton_Clicked;
		}

        private async void TapRegtBackButton_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new InlogPage());
        }

        private async void RegtButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new InlogPage());
        }
    }
}