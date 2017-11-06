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
        int counter = 0;
        public PlayerPage()
        {
            InitializeComponent();

            var tapBackbutton = new TapGestureRecognizer();
            tapBackbutton.Tapped += TapBackbutton_Tapped;
            BackButton.GestureRecognizers.Add(tapBackbutton);

            var tapPlaybutton = new TapGestureRecognizer();
            tapPlaybutton.Tapped += TapPlaybutton_Tapped;
            playButton.GestureRecognizers.Add(tapPlaybutton);

            var tapFavoriet = new TapGestureRecognizer();
            tapFavoriet.Tapped += TapFavoriet_Tapped;
            favorite.GestureRecognizers.Add(tapFavoriet);

        }

        private void TapFavoriet_Tapped(object sender, EventArgs e)
        {
            if (counter == 0)
            {
                favorite.Source = "sterVol.png";
                counter = 1;
            }
            else
            {
                favorite.Source = "sterLeeg.png";
                counter = 0;
            }
        }

        private void TapPlaybutton_Tapped(object sender, EventArgs e)
        {

            if (count == 0)
            {
                playButton.Source = "pauze.png";
                count = 1;
            }
            else
            {
                playButton.Source = "play.png";
                count = 0;
            }
        }

        private async void TapBackbutton_Tapped(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}