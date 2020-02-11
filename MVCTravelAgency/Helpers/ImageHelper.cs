using System;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;

namespace MVCTravelAgency.Helpers
{
    public static class ImageHelper
    {
        public static string Create(IHostingEnvironment host, IFormFile img)
        {
            string uniqImgName = null;
            string imageFolderName = "img";

            if (img != null)
            {
                string uploatsFolder = Path.Combine(host.WebRootPath, imageFolderName);
                uniqImgName = Guid.NewGuid().ToString() + "_" + img.FileName;
                string filePath = Path.Combine(uploatsFolder, uniqImgName);
                img.CopyTo(new FileStream(filePath, FileMode.Create));
            }
            return Path.Combine(imageFolderName, uniqImgName);
        }
    }
}
