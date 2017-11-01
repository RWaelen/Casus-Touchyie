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
		public SearchResultPage ()
		{
			InitializeComponent ();
            
            SearchResults_ListView.ItemsSource = new List<SearchItem>
            {
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
            };

            

            //SearchResults_ListView.ItemSelected += SearchResults_ListView_ItemSelected;

        }

        //private async void SearchResults_ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        //{
        //    await Navigation.PushModalAsync(new PlayerPage());
        //}
    }
}