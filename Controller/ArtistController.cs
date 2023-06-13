using KpopZtation_GroupB.Handler;
using KpopZtation_GroupB.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace KpopZtation_GroupB.Controller
{
    public class ArtistController
    {
        public static String validateArtist(String name, String imagePath, bool fileExists, int fileSize, String fileExt)
        {
            String response = "";
            // validasi name, img
            if(string.IsNullOrWhiteSpace(name))
            {
                response = "Artist name must be filled";
            }
            else if(ArtistHandler.CheckArtistNameUnique(name) == false)
            {
                response = "Artist name must be unique";
            }
            else if(fileExists == false)
            {
                response = "File must be chosen";
            }
            else 
            {
                bool isValid = false;
                String[] validExt = { ".png", ".jpg", ".jpeg", ".jfif", ".PNG", ".JPG", ".JPEG", ".JFIF" };
                for (int i = 0; i < fileExt.Length; i++)
                {
                    if (fileExt.Equals(validExt[i]))
                    {
                        isValid = true;
                    }
                }

                if (isValid == false)
                {
                    response = "File extention must be .png, .jpg, .jpeg, .jfif";
                }
                else if (fileSize > 2048000)
                {
                    response = "File size must be lower than 2MB";
                }


            }
            
            return response;
        }

        public static void doInsertArtist(String name, String image)
        {
            ArtistHandler.CreateArtist(name, image);
        }

        public static void doUpdateArtist(int id, String name, String image)
        {
            ArtistHandler.UpdateArtist(id, name, image);
        }

        public static List<Artist> GetAllArtist()
        {
            return ArtistHandler.GetAllArtist();
        }

        public static bool RemoveArtist(int id)
        {
            return ArtistHandler.RemoveArtist(id);
        }

        public static Artist GetArtistById(int id)
        {
            return ArtistHandler.GetArtistById(id);
        }
    }
}