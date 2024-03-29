﻿using Readed_Book_Lister.Methods.Helpers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Readed_Book_Lister.App_Logics
{
    public class ImageOperations
    {
        public static void SaveImage(string guidedImageName, TextBox tbxImage) // double check ok bool a gerek yok
        {
            if (!string.IsNullOrEmpty(StringUtilityHelper.TrimStartAndFinish(tbxImage.Text)))
            {
                Image loadedImage = Image.FromFile(tbxImage.Text); //Bitmap.FromFile dan değiştirdim.
                Image imageToSave = ResizeImage(loadedImage);
                imageToSave.Save(guidedImageName);
                //imageToSave.Save(guidedImageName,ImageFormat.Jpeg); => uzantı belirlemek istersen bunu kullanabilirsin.
                //File.Copy(tbxImage.Text, guidedImageName, false); => eski kayıt, resmi resize yapmadan olduğu gibi kaydeden. (çalışıyor)
            }
        }

        public static void DeleteOldImageIfNotDefault(string oldImage) // double check ok bool a gerek yok
        {
            var defaultImage = @".\images\default.png";

            if (oldImage != defaultImage)
            {
                File.Delete(oldImage);
            }
        }

        //public static void DeleteOldImageIfNotDefault(string oldImage) // folder ile filename i combine alternatifi ama split iyileştirilmeli.
        //{
        //    var defaultImage = @".\images\default.png";
        //    var folderPath = @".\images";
        //    var justFileName = oldImage.Split('\\', oldImage.Length - 1)[2];
        //    var fileToDel = Path.Combine(folderPath, justFileName);

        //    if (oldImage != defaultImage)
        //    {
        //        File.Delete(fileToDel);
        //    }
        //}

        public static string GenerateGuidForImageIfImageSelected(string imageFileName)
        {
            if (string.IsNullOrEmpty(StringUtilityHelper.TrimStartAndFinish(imageFileName)))
            {
                return @".\images\default.png";
            }
            var extension = Path.GetExtension(imageFileName);
            var guidedNameWithExtension = @".\images\" + Guid.NewGuid() + extension;
            return guidedNameWithExtension;
        }

        private static Image ResizeImage(Image imgToResize)
        {
            return new Bitmap(imgToResize, new Size(220, 343));
        }
    }
}
