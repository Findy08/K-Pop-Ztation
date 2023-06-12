using KpopZtation_GroupB.Factory;
using KpopZtation_GroupB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation_GroupB.Repository
{
    public class ArtistRepository
    {
        private static KpopZtationDatabaseEntities db = DatabaseSingleton.GetInstance();
        public static List<Artist> GetAllArtist()
        {
            return (from a in db.Artists select a).ToList();
        }

        public static void CreateArtist(String name, String image)
        {
            Artist a = ArtistFactory.CreateArtist(name, image);
            db.Artists.Add(a);
            db.SaveChanges();
        }

        public static Artist GetArtistById(int id)
        {
            return (from a in db.Artists where a.ArtistID == id select a).FirstOrDefault();
        }

        public static bool RemoveArtist(int id)
        {
            Artist a = GetArtistById(id);
            if(a != null)
            {
                db.Artists.Remove(a);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public static bool UpdateArtist(int id, String name, String image)
        {
            Artist a = GetArtistById(id);
            if(a != null)
            {
                a.ArtistName = name;
                a.ArtistImage = image;
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public static bool CheckArtistNameUnique(String name)
        {
            Artist artist = (from a in db.Artists where a.ArtistName == name select a).FirstOrDefault();
            if(artist == null)
            {
                return true;
            }
            return false;
        }
    }
}