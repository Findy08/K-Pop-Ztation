using KpopZtation_GroupB.Model;
using KpopZtation_GroupB.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation_GroupB.Handler
{
    public class AlbumHandler
    {
        public static List<Album> GetAlbumByArtistId(int artistId)
        {
            return AlbumRepository.GetAlbumByArtistId(artistId);
        }

        // insert, delete, update
        public static void CreateAlbum(Artist artist, String name, String desc, int price, int stock, String image)
        {
            AlbumRepository.CreateAlbum(artist, name, desc, price, stock, image);
        }

        public static Album GetAlbumById(int albumId)
        {
            return AlbumRepository.GetAlbumById(albumId);
        }

        public static bool UpdateAlbum(int albumId, String name, String desc, int price, int stock, String image)
        {
            return AlbumRepository.UpdateAlbum(albumId, name, desc, price, stock, image);
        }

        public static bool RemoveAlbum(int albumId)
        {
            return AlbumRepository.RemoveAlbum(albumId);
        }
    }
}