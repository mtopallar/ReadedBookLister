using Newtonsoft.Json;
using Readed_Book_Lister.Constants;
using Readed_Book_Lister.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Readed_Book_Lister.Methods.Helpers
{
    public class JsonOperations
    {
        // Checked.

        const string userFileName = "users.json";
        const string userBooksFileName = "userBooks.json";
        const string assetsFolderName = "assets";
        const string imagesFolderName = "images";

        public static void CreateDbFilesIfNot()
        {
            if (!File.Exists(userFileName))
            {
                //File.SetAttributes(userFileName, FileAttributes.Hidden);
                //File.SetAttributes(path, File.GetAttributes(path) | FileAttributes.Hidden);
                var userDbFile = File.Create(userFileName);
                userDbFile.Close();
                var emptyUserList = new List<User>();
                var convertNewListToJson = JsonConvert.SerializeObject(emptyUserList, Formatting.Indented);
                File.WriteAllText(userFileName, convertNewListToJson);

            }
            if (!File.Exists(userBooksFileName))
            {
                var userBooksDbFile = File.Create(userBooksFileName);
                userBooksDbFile.Close();
                var emptyUserBooksList = new List<UserBook>();
                var convertNewListToJson = JsonConvert.SerializeObject(emptyUserBooksList, Formatting.Indented);
                File.WriteAllText(userBooksFileName, convertNewListToJson);
            }
        }

        public static void HideSystemFoldersAndDbFiles()
        {
            HideAssetsFolder();
            HideImagessFolder();   
            // users ve userbooks json dosyalarını gizli yaptığım zaman file stream yaratarak okuma ve yazma erişimi vermem gerekiyor. direk dosyadan okuma / dosyaya yazma yetkisi olmuyor.
        }

        private static void HideAssetsFolder()
        {
            if (Directory.Exists(assetsFolderName))
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(assetsFolderName);
                directoryInfo.Attributes = FileAttributes.Hidden;
            }
        }

        private static void HideImagessFolder()
        {
            if (Directory.Exists(imagesFolderName))
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(imagesFolderName);
                directoryInfo.Attributes = FileAttributes.Hidden;
            }
        }
        

        //Aşağıdaki metodlar users ve userbooks json dosyalarını eğer içleri boşsa siliyorlar. Çalışan metodlar (denendi) ancak kullanmadım.

        //public static bool DeleteUserFile() // double check ok
        //{
        //    var jsonUserList = File.ReadAllText(userFileName);
        //    var userList = JsonConvert.DeserializeObject<List<User>>(jsonUserList);
        //    if (userList != null)
        //    {
        //        if (userList.Count == 0)
        //        {
        //            File.Delete(userFileName);
        //            return true;
        //        }
        //        return true;
        //    }
        //    System.Windows.Forms.MessageBox.Show(Messages.UsersFileNotExist);
        //    return false; //defensive
        //}

        //public static bool DeleteUserBooksFile()  // double check ok
        //{
        //    var jsonUserBookList = File.ReadAllText(userBooksFileName);
        //    var userBooksList = JsonConvert.DeserializeObject<List<User>>(jsonUserBookList);
        //    if (userBooksList != null)
        //    {
        //        if (userBooksList.Count == 0)
        //        {
        //            File.Delete(userBooksFileName);
        //            return true;
        //        }
        //        return true;
        //    }
        //    System.Windows.Forms.MessageBox.Show(Messages.UserBooksFileNotExist);
        //    return false; //defensive
        //}

    }
}
