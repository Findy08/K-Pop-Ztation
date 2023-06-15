using KpopZtation_GroupB.Factory;
using KpopZtation_GroupB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation_GroupB.Repository
{
    public class AlbumRepository
    {
        private static KpopDatabaseEntities db = DatabaseSingleton.GetInstance();
        // view album by artist id
        public static List<Album> GetAlbumByArtistId(int artistId)
        {
            return (from al in db.Albums where al.ArtistID == artistId select al).ToList();
        }

        // insert, delete, update
        public static void CreateAlbum(Artist artist, String name, String desc, int price, int stock, String image)
        {
            Album album = AlbumFactory.CreateAlbum(artist, name, image, price, stock, desc);
            db.Albums.Add(album);
            db.SaveChanges();
        }

        public static Album GetAlbumById(int albumId)
        {
            return (from al in db.Albums where al.AlbumID == albumId select al).FirstOrDefault();
        }

        public static bool UpdateAlbum(int albumId, String name, String desc, int price, int stock, String image)
        {
            Album album = GetAlbumById(albumId);
            if(album != null)
            {
                album.AlbumName = name;
                album.AlbumDescription = desc;
                album.AlbumPrice = price;
                album.AlbumStock = stock;
                album.AlbumImage = image;
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public static bool UpdateAlbumStock(int albumId, int qtyBought)
        {
            Album album = GetAlbumById(albumId);
            if(album != null)
            {
                album.AlbumStock = album.AlbumStock - qtyBought;
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public static bool RemoveAlbum(int albumId)
        {
            Album album = GetAlbumById(albumId);
            if(album != null)
            {
                db.Albums.Remove(album);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public static bool RemoveAlbumByArtist(List<Album> album)
        {
            if(album != null)
            {
                db.Albums.RemoveRange(album);
                db.SaveChanges();
                return true;
            }
            return false;
            
            
        }
    }
}