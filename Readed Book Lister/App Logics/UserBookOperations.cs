using Newtonsoft.Json;
using Readed_Book_Lister.Constants;
using Readed_Book_Lister.Entities;
using Readed_Book_Lister.Methods.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Readed_Book_Lister.Methods.App_Methods
{
    public class UserBookOperations
    {
        const string userBookFileName = "userbooks.json";

        //add => ok
        //update
        //delete
        //get userbooks by user id * default
        //list userbooks by bookname
        //list userbooks by authorname
        //list userbooks by readdate (not null olanları)
        //list userbooks by note
        //list userbooks bu native

        //getall => ok

        public static void Add(UserBook userBook)
        {
            // Güzel bir örnek oldu.

            JsonOperations.CreateDbFilesIfNot();
            var editedBook = EditNamesByNativeState(NoteTrimmer(userBook));

            var getAllList = GetAll();
            if (getAllList == null)
            {
                var userBookToJson = JsonConvert.SerializeObject(editedBook, Formatting.Indented);
                File.WriteAllText(userBookFileName, userBookToJson);
                System.Windows.Forms.MessageBox.Show(Messages.UserBookAddSuccessful);
                return;
            }

            getAllList.Add(editedBook);
            var addedListToJson = JsonConvert.SerializeObject(getAllList, Formatting.Indented);
            File.WriteAllText(userBookFileName, addedListToJson);
            System.Windows.Forms.MessageBox.Show(Messages.UserBookAddSuccessful);

        }

        public static List<UserBook> GetAll()
        {
            var jsonUserBookList = File.ReadAllText(userBookFileName);
            var userBookList = JsonConvert.DeserializeObject<List<UserBook>>(jsonUserBookList);
            if (userBookList.Count != 0)
            {
                return userBookList;
            }
            System.Windows.Forms.MessageBox.Show(Messages.UserBookListNotFoundOrEmpty);
            return null;
        }

        private static UserBook EditNamesByNativeState(UserBook userBook)
        {
            if (userBook.Native)
            {
                userBook.BookName = StringUtilityHelper.ToTrLocaleTitleCase(StringUtilityHelper.TrimStartAndFinish(userBook.BookName));
                userBook.AuthorName = StringUtilityHelper.ToTrLocaleTitleCase(StringUtilityHelper.TrimStartAndFinish(userBook.AuthorName));
                return userBook;
            }
            userBook.BookName = StringUtilityHelper.ToEngLocaleTitleCase(StringUtilityHelper.TrimStartAndFinish(userBook.BookName));
            userBook.AuthorName = StringUtilityHelper.ToEngLocaleTitleCase(StringUtilityHelper.TrimStartAndFinish(userBook.AuthorName));
            return userBook;
        }

        private static UserBook NoteTrimmer(UserBook userBook)
        {
            StringUtilityHelper.TrimStartAndFinish(userBook.Note);
            return userBook;
        }
    }
}
