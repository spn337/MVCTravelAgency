using System;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;

namespace MVCTravelAgency.Helpers
{
    public static class ImageHelper
    {
        //Отримати повний шлях фото
        public static string GetImagePath(IHostingEnvironment host, string imgName)
        {
            return Path.Combine(host.WebRootPath, "img", imgName);
        }

        //Збереження фото
        public static string SaveImage(IHostingEnvironment host, IFormFile img)
        {
            string uniqImgName = null;

            if (img != null)
            {
                //генеруємо нове імя
                uniqImgName = Guid.NewGuid().ToString() + "_" + img.FileName;
                //дістаємо повний шлях фото
                string filePath = GetImagePath(host, uniqImgName);
                //зберігаємо фото
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    img.CopyTo(fileStream);
                }
            }
            return uniqImgName;
        }

        //Видалення фото
        public static void DeleteImage(IHostingEnvironment host, string imgName)
        {
            string filePath = GetImagePath(host, imgName);
            File.Delete(filePath);
        }     
    }
}
