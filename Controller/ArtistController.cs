using KpopZtation_GroupB.Handler;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace KpopZtation_GroupB.Controller
{
    public class ArtistController
    {
        public static String validateInsertArtist(String name, String imagePath)
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
            else if(!File.Exists(imagePath))
            {
                response = "Image must be chosen";
            }
            else
            {
                bool isValid = false;
                String[] fileExt = { ".png", ".jpg", ".jpeg", ".jfif", ".PNG", ".JPG", ".JPEG", ".JFIF" };
                for (int i = 0; i < fileExt.Length; i++)
                {
                    if (imagePath.Contains(fileExt[i]))
                    {
                        isValid = true;
                    }
                }

                FileInfo imgInfo = new FileInfo(imagePath);

                if (isValid == false)
                {
                    response = "File extention must be .png, .jpg, .jpeg, .jfif";
                }
                else if (imgInfo.Length > 2048000)
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

        public static bool doUpdateArtist(String name, String image)
        {
            return true;
        }
    }
}