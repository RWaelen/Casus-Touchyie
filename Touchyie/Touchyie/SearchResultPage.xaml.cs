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
	public partial class SearchResultPage : ContentPage
	{
        public SearchResultPage()
        {
            InitializeComponent();

            // lijst aanmaken voor zoekresultaten
            ListView SRListView = Content.FindByName<ListView>("SearchResults_ListView");
            SRListView.ItemTapped += SRListView_ItemTapped;

            //--back button naar vorige pagina
            var tapBackButtonImage = new TapGestureRecognizer();
            tapBackButtonImage.Tapped += TapBackButtonImage_Tapped;
            BackButton.GestureRecognizers.Add(tapBackButtonImage);

            SearchResults_ListView.ItemsSource = new List<SearchItem>
            {
                //Items voor de listview toevoegen voor zoekresultaten
                new SearchItem
                {
                    VidThumbnail="playvideo.png",
                    FilmName="Film",
                    VideoDetail="Deze film gaat over..........",
                    TijdsDuur="6:23"
                },
                new SearchItem
                {
                    VidThumbnail="playvideo.png",
                    FilmName="Film 2",
                    VideoDetail="Deze film gaat over..........",
                    TijdsDuur="3:28"
                },
                new SearchItem
                {
                    VidThumbnail="playvideo.png",
                    FilmName="Film 3",
                    VideoDetail="Deze film gaat over..........",
                    TijdsDuur="8:45"
                },
                new SearchItem
                {
                    VidThumbnail="playvideo.png",
                    FilmName="Film 4",
                    VideoDetail="Deze film gaat over..........",
                    TijdsDuur="12:25"
                },
                new SearchItem
                {
                    VidThumbnail="playvideo.png",
                    FilmName="Film 5",
                    VideoDetail="Deze film gaat over..........",
                    TijdsDuur="3:33"
                },
                new SearchItem
                {
                    VidThumbnail="playvideo.png",
                    FilmName="Film 6",
                    VideoDetail="Deze film gaat over..........",
                    TijdsDuur="14:20"
                },
                new SearchItem
                {
                    VidThumbnail="playvideo.png",
                    FilmName="Film 7",
                    VideoDetail="Deze film gaat over..........",
                    TijdsDuur="7:30"
                },
                new SearchItem
                {
                    VidThumbnail="playvideo.png",
                    FilmName="Film 8",
                    VideoDetail="Deze film gaat over..........",
                    TijdsDuur="4:02"
                },
               
            };

        }


        private async void TapBackButtonImage_Tapped(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        private async void SRListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            await Navigation.PushModalAsync(new PlayerPage());
        }
    }
}