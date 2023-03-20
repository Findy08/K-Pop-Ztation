using KpopZtation_GroupB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation_GroupB.Factory
{
    public class ArtistFactory
    {
        public static Artist CreateArtist(String artistName, String artistImage)
        {
            Artist artist = new Artist();
            artist.ArtistName = artistName;
            artist.ArtistImage = artistImage;
            return artist;
        }
    }
}