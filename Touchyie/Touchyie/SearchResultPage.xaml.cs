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
                    FilmName="Film"
                },
                new SearchItem
                {
                    VidThumbnail="playvideo.png",
                    FilmName="Film"
                },
                new SearchItem
                {
                    VidThumbnail="playvideo.png",
                    FilmName="Film"
                },
                new SearchItem
                {
                    VidThumbnail="playvideo.png",
                    FilmName="Film"
                },
                new SearchItem
                {
                    VidThumbnail="playvideo.png",
                    FilmName="Film"
                },
            };

        }
	}
}