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
	public partial class PlayerPage : ContentPage
	{
        int count = 0;
        public PlayerPage ()
		{
			InitializeComponent ();

            var tapBackbutton = new TapGestureRecognizer();
            tapBackbutton.Tapped += TapBackbutton_Tapped;
            BackButton.GestureRecognizers.Add(tapBackbutton);

            var tapPlaybutton = new TapGestureRecognizer();
            tapPlaybutton.Tapped += TapPlaybutton_Tapped;
            playButton.GestureRecognizers.Add(tapPlaybutton);
        }

        private async void TapPlaybutton_Tapped(object sender, EventArgs e)
        {

            if (count == 0)
            {
                playButton.Source = "pauseButton.png";
                count = 1;
            }
            else {
                playButton.Source = "playbutton.png";
                count = 0;
            }
        }

        private async void TapBackbutton_Tapped(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}