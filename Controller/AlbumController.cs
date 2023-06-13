using KpopZtation_GroupB.Handler;
using KpopZtation_GroupB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation_GroupB.Controller
{
    public class AlbumController
    {
        public static String validateAlbum(String name, String desc, int price, int stock, String imagePath, bool fileExists, int fileSize, String fileExt)
        {
            String response = "";
            // validasi name, desc, price, stock, img
            if(string.IsNullOrEmpty(name) || string.IsNullOrEmpty(desc) || price == 0 || stock == 0 || fileExists == false) {
                response = "All data must be filled";
            }
            else if(name.Length >= 50)
            {
                response = "Name length must be shorter than 50 characters";
            }
            else if(desc.Length >= 255)
            {
                response = "Description length must be shorter than 255 characters";
            }
            else if(price < 100000 || price > 1000000)
            {
                response = "Price must be between 100000 and 1000000";
            }
            else if(stock <= 0)
            {
                response = "Stock must be more than 0";
            }
            else if (fileExists == false)
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

        public static void doInsertAlbum(int artistId, String name, String desc, int price, int stock, String image)
        {
            Artist artist = ArtistHandler.GetArtistById(artistId);
            AlbumHandler.CreateAlbum(artist, name, desc, price, stock, image);
        }

        public static bool doUpdateAlbum()
        {
            return true;
        }

        public static List<Album> GetAlbumByArtistId(int artistId)
        {
            return AlbumHandler.GetAlbumByArtistId(artistId);
        }
        

        public static Album GetAlbumById(int albumId)
        {
            return AlbumHandler.GetAlbumById(albumId);
        }

        public static bool RemoveAlbum(int albumId)
        {
            return AlbumHandler.RemoveAlbum(albumId);
        }
    }
}