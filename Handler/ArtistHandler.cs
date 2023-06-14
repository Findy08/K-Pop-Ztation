using KpopZtation_GroupB.Model;
using KpopZtation_GroupB.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation_GroupB.Handler
{

    public class ArtistHandler 
    {
        public static List<Artist> GetAllArtist()
        {
            List<Artist> artists = ArtistRepository.GetAllArtist();
            return artists;
        }

        public static void CreateArtist(String name, String image)
        {
            ArtistRepository.CreateArtist(name, image);
        }

        public static Artist GetArtistById(int id)
        {
            return ArtistRepository.GetArtistById(id);
        }

        public static bool RemoveArtist(int id)
        {
            // hapus album juga
            Artist a = GetArtistById(id);
            if(a.Albums.Count > 0)
            {
                AlbumRepository.RemoveAlbumByArtist(a.Albums.ToList());
            }
            return ArtistRepository.RemoveArtist(id);
        }

        public static bool UpdateArtist(int id, String name, String image)
        {
            return ArtistRepository.UpdateArtist(id, name, image);
        }

        public static bool CheckArtistNameUnique(String name)
        {
            return ArtistRepository.CheckArtistNameUnique(name);
        }

    }

    
}