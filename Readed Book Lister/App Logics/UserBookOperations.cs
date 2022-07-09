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
        //GetAllByUserId(int userId) * default => ok
        //list userbooks by bookname //titlecase
        //list userbooks by authorname //titlecase
        //list userbooks by readdate (not null olanları)
        //list GetByNoteState(int userId, bool hasNote) => ok
        //list GetByNativeStatue(int userId, bool nativeStatue) => ok

        //getall => ok (private)

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

        public static List<UserBook> GetByNoteState(int userId, bool hasNote)
        {
            if (HasUserGotAnyBook(userId))
            {
                var getUsersAllBooks = GetAllByUserId(userId);
                if (hasNote)
                {
                    // notu olanlar
                    var booksHasNote = getUsersAllBooks.Where(u => u.Note != null).ToList();
                    if (booksHasNote.Count != 0)
                    {
                        return booksHasNote;
                    }
                    System.Windows.Forms.MessageBox.Show(Messages.NoBookWithNote);
                    return null;
                }
                else
                {
                    // notu olmayanlar
                    var booksHasNoNote = getUsersAllBooks.Where(u => u.Note == null).ToList();
                    if (booksHasNoNote.Count != 0)
                    {
                        return booksHasNoNote;
                    }
                    System.Windows.Forms.MessageBox.Show(Messages.NoBookWithoutNote);
                }
            }
            return null;
        }

        public static List<UserBook> GetByNativeState(int userId, bool nativeState)
        {
            if (HasUserGotAnyBook(userId))
            {
                var getUserBooksByNative = GetAllByUserId(userId).Where(u => u.Native == nativeState).ToList();
                if (getUserBooksByNative.Count != 0)
                {
                    return getUserBooksByNative;
                }
                System.Windows.Forms.MessageBox.Show(Messages.NoBookForNativeStatue);
            }
            return null;
        }

        public static List<UserBook> GetAllByUserId(int userId)
        {
            var getAllBooks = GetAll();
            if (getAllBooks != null)
            {
                if (HasUserGotAnyBook(userId))
                {
                    var getUserBooks = getAllBooks.Where(u => u.UserId == userId).ToList();
                    return getUserBooks;
                }
            }
            return null;
        }

        private static List<UserBook> GetAll()
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

        private static bool HasUserGotAnyBook(int userId)
        {
            var getAllBooks = GetAll();
            if (getAllBooks != null)
            {
                var getUserBooks = getAllBooks.Where(u => u.UserId == userId).ToList();
                if (getUserBooks.Count != 0)
                {
                    return true;
                }
                System.Windows.Forms.MessageBox.Show(Messages.UserHasNoAnyBook);
                return false;
            }
            return false;
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
