using Newtonsoft.Json;
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
        // Deletelerde ilgili managerlerin getall ları null ise de kullanılabilir böyle kalsa da olur. kontrol ok.

        const string userFileName = "users.json";
        const string userBooksFileName = "userbooks.json";

        public static void CreateDbFilesIfNot()
        {
            if (!File.Exists(userFileName))
            {
                //File.SetAttributes(userFileName, FileAttributes.Hidden);
                //File.SetAttributes(path, File.GetAttributes(path) | FileAttributes.Hidden);
                File.Create(userFileName);

            }
            if (!File.Exists(userBooksFileName))
            {
                File.Create(userBooksFileName);
            }
        }

        public static void DeleteUserFile()
        {
            var jsonUserList = File.ReadAllText(userFileName);
            var userList = JsonConvert.DeserializeObject<List<User>>(jsonUserList);
            if (userList.Count == 0)
            {

                File.Delete(userFileName);
            }

        }

        public static void DeleteUserBooksFile()
        {
            var jsonUserBookList = File.ReadAllText(userBooksFileName);
            var userBooksList = JsonConvert.DeserializeObject<List<User>>(jsonUserBookList);
            if (userBooksList.Count == 0)
            {
                File.Delete(userBooksFileName);
            }

        }

    }
}
