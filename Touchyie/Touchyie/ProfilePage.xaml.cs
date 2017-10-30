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
	public partial class ProfilePage : ContentPage
	{
		public ProfilePage ()
		{
			InitializeComponent ();

            var tapBackButtonImage = new TapGestureRecognizer();
            tapBackButtonImage.Tapped += TapBackButtonImage_Tapped;
            BackButton.GestureRecognizers.Add(tapBackButtonImage);

            Button uitlogbutton = Content.FindByName<Button>("uitlogButton");
            uitlogButton.Clicked += UitlogButton_Clicked;
        }

        private async void UitlogButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new InlogPage());
        }

        private async void TapBackButtonImage_Tapped(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}