using KpopZtation_GroupB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation_GroupB.Factory
{
    public class AlbumFactory
    {
        public static Album CreateAlbum(Artist artist, String albumName, String albumImage, int albumPrice, int albumStock, String albumDescription)
        {
            Album album = new Album();
            album.Artist = artist;
            album.AlbumName = albumName;
            album.AlbumImage = albumImage;
            album.AlbumPrice = albumPrice;
            album.AlbumStock = albumStock;
            album.AlbumDescription = albumDescription;
            return album;
        }
    }
}