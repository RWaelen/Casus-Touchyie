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
        //Twee fields gedefinieerd
        int count = 0;
        int counter = 0;
        public PlayerPage()
        {
            InitializeComponent();
            //Recognizers aangemaakt voor images voor click functie
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
        //if statement toegevoegd die zorgt voor het switchen van de ster zodat je iets kunt toevoegen aan favorieten
        //gebruikt field counter
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
        //if statement toegevoegd die zorgt voor het switchen van de playbutton zodat je de film kunt pauzeren
        //gebruikt field count
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
        //wanneer er op de backbutton geklikt wordt stuurt de applicatie je terug naar de vorige pagina
        private async void TapBackbutton_Tapped(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}