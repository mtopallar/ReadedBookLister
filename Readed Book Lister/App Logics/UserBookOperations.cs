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

        // USER ID yi UNUTMAAAAAAAAAAAAAAAAAAA
        //add => ok
        //update => ok
        //delete => ok
        //GetAllByUserId(int userId) * default => ok
        //list userbooks by bookname //titlecase// GetAllByUserIdAndBookName(int userId, string bookName) => ok
        //list userbooks by authorname //titlecase// GetAllByUserIdAndAuthorName(int userId, string authorName) => ok
        //list userbooks by readmouth and year => GetAllByReadMouthYearAndUserId(int userId,int readMouth, int readYear) => ok
        //list userbooks by readyear (just year) => GetAllByJustReadYearAndUserId(int userId, int readYear) => ok
        //list userbooks by unknown read date // GetAllUnknownReadDateAndUserId(int userId) => ok
        //list GetByNoteStateAndUserId(int userId, bool hasNote) => ok
        //list GetByNativeStatueAndUserId(int userId, bool nativeStatue) => ok

        //getall => ok (private)
        //GetByUserIdAndBookNameWithBothLocalizations(int userId, string bookName) private
        //GetByUserIdAndAuthorNameWithBothLocalizations(int userId, string authorName) private

        // resmi olmayan kitaplara default resmi atayan metodu yaz. add ve update metodlarının içinde kullan. Resim boyutlandırma ve seçilen resmi dosyaya kopyalayan metodlara bak.

        public static void Add(UserBook userBook)
        {
            // Güzel bir örnek oldu.
            JsonOperations.CreateDbFilesIfNot();

            EditNamesByNativeState(NoteTrimmer(userBook));
            userBook.Id = IdGeneratorForNewUserBook();

            var getAllList = GetAll();
            if (getAllList == null)
            {
                var userBookToJson = JsonConvert.SerializeObject(userBook, Formatting.Indented);
                File.WriteAllText(userBookFileName, userBookToJson);
                System.Windows.Forms.MessageBox.Show(Messages.UserBookAddSuccessful);
                return;
            }

            getAllList.Add(userBook);
            var addedListToJson = JsonConvert.SerializeObject(getAllList, Formatting.Indented);
            File.WriteAllText(userBookFileName, addedListToJson);
            System.Windows.Forms.MessageBox.Show(Messages.UserBookAddSuccessful);

        }

        public static void Update(UserBook userBook)
        {
            //Checked.
            var getAllBooks = GetAll();

            if (getAllBooks != null)
            {
                var getBookToUpdate = getAllBooks.Where(u => u.Id == userBook.Id).FirstOrDefault();

                if (getBookToUpdate != null)
                {
                    EditNamesByNativeState(NoteTrimmer(userBook));
                    getBookToUpdate.Image = userBook.Image;
                    getBookToUpdate.BookName = userBook.BookName;
                    getBookToUpdate.AuthorName = userBook.AuthorName;
                    getBookToUpdate.Readed = userBook.Readed;
                    getBookToUpdate.Native = userBook.Native;
                    getBookToUpdate.ReadMonth = userBook.ReadMonth;
                    getBookToUpdate.ReadYear = userBook.ReadYear;
                    getBookToUpdate.Image = userBook.Image;
                    getBookToUpdate.Note = userBook.Note;

                    var updatedListToJson = JsonConvert.SerializeObject(getAllBooks, Formatting.Indented);
                    File.WriteAllText(userBookFileName, updatedListToJson);
                    System.Windows.Forms.MessageBox.Show(Messages.UserBookUpdateSuccessful);
                    return;
                }
                System.Windows.Forms.MessageBox.Show(Messages.NoUserBookByUserBookId);
            }
        }

        public static void Delete(UserBook userBook)
        {
            //Checked.
            var getAllBooks = GetAll();
            if (getAllBooks != null)
            {
                var userBookToRemove = getAllBooks.Where(u => u.Id == userBook.Id).FirstOrDefault();
                if (userBookToRemove != null)
                {
                    getAllBooks.Remove(userBookToRemove);
                    var updatedListToJson = JsonConvert.SerializeObject(getAllBooks, Formatting.Indented);
                    File.WriteAllText(userBookFileName, updatedListToJson);
                    System.Windows.Forms.MessageBox.Show(Messages.DeleteUserBookSuccessful);
                    return;
                }
                System.Windows.Forms.MessageBox.Show(Messages.NoUserBookByUserBookId);
            }
        }

        public static List<UserBook>? GetAllByUserIdAndBookName(int userId, string bookName)
        {
            // Checked.
            var getAllByUserIdAndBookName = GetByUserIdAndBookNameWithBothLocalizations(userId, bookName);
            if (getAllByUserIdAndBookName != null)
            {
                return getAllByUserIdAndBookName;
            }
            return null;
        }

        public static List<UserBook>? GetAllByUserIdAndAuthorName(int userId, string authorName)
        {
            //Checked.
            var getAllByUserIdAndAuthorName = GetByUserIdAndAuthorNameWithBothLocalizations(userId, authorName);
            if (getAllByUserIdAndAuthorName != null)
            {
                return getAllByUserIdAndAuthorName;
            }
            return null;
        }

        public static List<UserBook>? GetAllByReadMouthYearAndUserId(int userId, int readMonth, int readYear)
        {
            //Checked.

            var getAllByUserId = GetAllByUserId(userId);
            if (getAllByUserId != null)
            {
                var getListByCriteria = getAllByUserId.Where(u => u.ReadMonth == readMonth && u.ReadYear == readYear).ToList();
                if (getListByCriteria.Count != 0)
                {
                    return getListByCriteria;
                }
                System.Windows.Forms.MessageBox.Show(Messages.NoUserBookByReadMountAndYear);
            }
            return null;
        }

        public static List<UserBook>? GetAllByJustReadYearAndUserId(int userId, int readYear)
        {
            // Geliştirildi.

            var getAllByUserId = GetAllByUserId(userId);
            if (getAllByUserId != null)
            {
                var knownReadYearList = getAllByUserId.Where(u => u.ReadYear == readYear).ToList();
                if (knownReadYearList.Count != 0)
                {
                    return knownReadYearList;
                }
                System.Windows.Forms.MessageBox.Show(Messages.NoBookByKnownDateStatue);
            }

            return null;
        }

        public static List<UserBook>? GetAllUnknownReadDateAndUserId(int userId)
        {
            // Geliştirildi.

            var getAllByUserId = GetAllByUserId(userId);
            if (getAllByUserId != null)
            {
                var getUnknownReadDateList = getAllByUserId.Where(u => u.ReadMonth == null && u.ReadYear == null).ToList();
                if (getUnknownReadDateList.Count != 0)
                {
                    return getUnknownReadDateList;
                }
                System.Windows.Forms.MessageBox.Show(Messages.NoBookByUnkownDateStatue);
            }

            return null;
        }

        public static List<UserBook>? GetByNoteStateAndUserId(int userId, bool hasNote)
        {
            // Geliştirildi.

            var getUsersAllBooks = GetAllByUserId(userId);
            if (getUsersAllBooks != null)
            {
                if (hasNote)
                {
                    // notu olanlar
                    var booksHasNote = getUsersAllBooks.Where(u => u.Note != null).ToList();
                    if (booksHasNote.Count != 0)
                    {
                        return booksHasNote;
                    }
                    System.Windows.Forms.MessageBox.Show(Messages.NoBookWithNote);
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

        public static List<UserBook>? GetByNativeStateAndUserId(int userId, bool nativeState)
        {
            // Geliştirildi.

            var getUsersBook = GetAllByUserId(userId);
            if (getUsersBook != null)
            {
                var getUserBooksByNative = getUsersBook.Where(u => u.Native == nativeState).ToList();
                if (getUserBooksByNative.Count != 0)
                {
                    return getUserBooksByNative;
                }
                System.Windows.Forms.MessageBox.Show(Messages.NoBookForNativeStatue);
            }

            return null;
        }

        public static List<UserBook>? GetAllByUserId(int userId)
        {
            // Checked.
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

        //PRIVATE Helper Methods
        
                
        private static List<UserBook>? GetByUserIdAndBookNameWithBothLocalizations(int userId, string bookName)
        {
            var getAllByUserId = GetAllByUserId(userId);
            if (getAllByUserId != null)
            {
                var editedTextByTr = StringUtilityHelper.ToTrLocaleTitleCase(StringUtilityHelper.TrimStartAndFinish(bookName));
                var tryReturnTrEditedBooksByBookName = getAllByUserId.Where(u => u.BookName == editedTextByTr).ToList();
                if (tryReturnTrEditedBooksByBookName.Count != 0)
                {
                    return tryReturnTrEditedBooksByBookName;
                }
                var editedTextByEng = StringUtilityHelper.ToEngLocaleTitleCase(StringUtilityHelper.TrimStartAndFinish(bookName));
                var tryReturnEngEditedBooksByBookName = getAllByUserId.Where(u => u.BookName == editedTextByEng).ToList();
                if (tryReturnEngEditedBooksByBookName.Count != 0)
                {
                    return tryReturnEngEditedBooksByBookName;
                }
                System.Windows.Forms.MessageBox.Show(Messages.NoUserBookByBookName);
            }

            return null;
        }

        private static List<UserBook>? GetByUserIdAndAuthorNameWithBothLocalizations(int userId, string authorName)
        {
            var getAllByUserId = GetAllByUserId(userId);
            if (getAllByUserId != null)
            {
                var editedTextByTr = StringUtilityHelper.ToTrLocaleTitleCase(StringUtilityHelper.TrimStartAndFinish(authorName));
                var tryReturnTrEditedBooksByAuthorName = getAllByUserId.Where(u => u.AuthorName == editedTextByTr).ToList();
                if (tryReturnTrEditedBooksByAuthorName.Count != 0)
                {
                    return tryReturnTrEditedBooksByAuthorName;
                }

                var editedTextByEng = StringUtilityHelper.ToEngLocaleTitleCase(StringUtilityHelper.TrimStartAndFinish(authorName));
                var tryReturnEngEditedBooksByAuthorName = getAllByUserId.Where(u => u.AuthorName == editedTextByEng).ToList();
                if (tryReturnEngEditedBooksByAuthorName.Count != 0)
                {
                    return tryReturnEngEditedBooksByAuthorName;
                }
                System.Windows.Forms.MessageBox.Show(Messages.NoUserBookByAuthorName);
            }
            return null;
        }

        private static List<UserBook>? GetAll()
        {
            // Checked.
            var jsonUserBookList = File.ReadAllText(userBookFileName);
            var userBookList = JsonConvert.DeserializeObject<List<UserBook>>(jsonUserBookList);
            if (userBookList != null)
            {
                if (userBookList.Count != 0)
                {
                    return userBookList;
                }
                System.Windows.Forms.MessageBox.Show(Messages.UserBooksListIsEmpty);
                return null;
            }
            System.Windows.Forms.MessageBox.Show(Messages.UserBooksFileNotExist);
            return null;
        }

        private static bool HasUserGotAnyBook(int userId)
        {
            // Checked.
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
            // Checked.
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
            // Checked.
            StringUtilityHelper.TrimStartAndFinish(userBook.Note);
            return userBook;
        }

        private static int IdGeneratorForNewUserBook()
        {
            int minId = 1;
            var getUserBookList = GetAll();
            if (getUserBookList == null)
            {
                return minId;
            }
            return (getUserBookList.OrderByDescending(u => u.Id).First().Id) + 1;
        }
    }
}
