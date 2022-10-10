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
using System.Windows.Forms;
using System.Xml.Linq;

namespace Readed_Book_Lister.Methods.App_Methods
{
    public class UserBookOperations
    {
        const string userBookFileName = "userbooks.json";

        public static bool Add(UserBook userBook) // bool eklendi ve kullanıldı
        {
            // Güzel bir örnek oldu.
            JsonOperations.CreateDbFilesIfNot();

            if (!IsIsbnUsedBefore(userBook))
            {
                return false;
            }

            //F.E. tarafında tbx null kontrolü var ama buraya da validasyon eklenebilir.

            BookNameToTitleCaseAndTrim(EditAuthorNameByNativeState(PublisherToTitleCaseAndTrim(NoteTrimmer(userBook))));

            userBook.Id = IdGeneratorForNewUserBook();

            var getAllList = GetAll();
            if (getAllList == null)
            {
                var addBookToNewList = new List<UserBook> { userBook };
                var newListToJson = JsonConvert.SerializeObject(addBookToNewList, Formatting.Indented);
                File.WriteAllText(userBookFileName, newListToJson);
                System.Windows.Forms.MessageBox.Show(Messages.UserBookAddSuccessful);
                return true;
            }

            getAllList.Add(userBook);
            var addedListToJson = JsonConvert.SerializeObject(getAllList, Formatting.Indented);
            File.WriteAllText(userBookFileName, addedListToJson);
            System.Windows.Forms.MessageBox.Show(Messages.UserBookAddSuccessful);
            return true;
        }

        public static bool Update(UserBook userBook) // double check ok
        {
            //Checked.
            var getAllBooks = GetAll();

            if (getAllBooks != null)
            {
                if (!IsIsbnUsedBefore(userBook))
                {
                    return false;
                }

                var getBookToUpdate = getAllBooks.Where(u => u.Id == userBook.Id).FirstOrDefault();

                if (getBookToUpdate != null)
                {
                    BookNameToTitleCaseAndTrim(EditAuthorNameByNativeState(PublisherToTitleCaseAndTrim(NoteTrimmer(userBook))));
                    getBookToUpdate.Image = userBook.Image;
                    getBookToUpdate.BookName = userBook.BookName;
                    getBookToUpdate.AuthorName = userBook.AuthorName;
                    getBookToUpdate.Isbn = userBook.Isbn;
                    getBookToUpdate.Publisher = userBook.Publisher;
                    getBookToUpdate.Readed = userBook.Readed;
                    getBookToUpdate.Native = userBook.Native;
                    getBookToUpdate.ReadMonth = userBook.ReadMonth;
                    getBookToUpdate.ReadYear = userBook.ReadYear;
                    getBookToUpdate.Image = userBook.Image;
                    getBookToUpdate.Note = userBook.Note;

                    var updatedListToJson = JsonConvert.SerializeObject(getAllBooks, Formatting.Indented);
                    File.WriteAllText(userBookFileName, updatedListToJson);
                    System.Windows.Forms.MessageBox.Show(Messages.UserBookUpdateSuccessful);
                    return true;
                }
                System.Windows.Forms.MessageBox.Show(Messages.NoUserBookByUserBookId);
            }

            return false;
        }

        public static bool Delete(UserBook userBook) // double check ok
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
                    return true;
                }
                System.Windows.Forms.MessageBox.Show(Messages.NoUserBookByUserBookId);
            }
            return false;
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
            }
            // belki count u sıfır olan yeni bi liste dönmek gerekebilir handle edişine göre.
            return null;
        }

        public static List<UserBook>? GetUserBooksBetweenSelectedYears(int userId, int firstYear, int secondYear)
        {
            var getAllByUserId = GetAllByUserId(userId);
            if (getAllByUserId != null)
            {
                var getFilteredBooks = getAllByUserId.Where(u => u.ReadYear >= firstYear && u.ReadYear <= secondYear).ToList();
                if (getFilteredBooks.Count != 0)
                {
                    return getFilteredBooks;
                }
            }
            return null;
        }

        public static List<UserBook>? GetAllUnknownReadDateAndUserId(int userId)
        {
            // Geliştirildi.

            var getAllByUserId = GetAllByUserId(userId);
            if (getAllByUserId != null)
            {
                //sadece yıla baksam da olur çünkü sadece ay bilgisi ile kitap kaydı yok. ya sadece yıl ya da ay ve yıl olabiliyor.
                //yani yılı boş olanın ay ı zaten boş olmak zorunda. yılı dolu ayı boş olanlar zaten dgv de yıl bazlı istatistiklerde listeleniyor.
                var getUnknownReadDateList = getAllByUserId.Where(u => u.ReadMonth == null && u.ReadYear == null).ToList();                 
                if (getUnknownReadDateList.Count != 0)
                {
                    return getUnknownReadDateList;
                }                
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

        public static List<UserBook> GetByUserIdAndIsbnNo(int userId, TextBox tbxIsbn)
        {
            var userBooks = GetAllByUserId(userId);

            if (userBooks != null)
            {
                if (!string.IsNullOrEmpty(StringUtilityHelper.TrimStartAndFinish(tbxIsbn.Text)))
                {
                    return userBooks.Where(u => u.Isbn.StartsWith(StringUtilityHelper.TrimStartAndFinish(tbxIsbn.Text))).ToList();
                }

                return userBooks;
            }
            return new List<UserBook>();
        }

        // Query temelli sorgu.
        public static List<UserBook> GetListByQuery(int userId, TextBox tbxBookName, TextBox tbxAuthor, TextBox tbxPublisher, RadioButton rbtnReaded, RadioButton rbtnNotReaded, RadioButton rbtnHasNotes, RadioButton rbtnHasNoNotes, RadioButton rbtnNative, RadioButton rbtnNotNative)
        {
            var usersList = GetAllByUserId(userId);

            if (usersList != null)
            {
                return GetListByNotNativeQuery(GetListByNativeQuery(GetListByHasNoNotesQuery(GetListByHasNotesQuery(GetListByNotReadedQuery(GetListByReadedQuery(GetListByPublisherQuery(GetListByAuthorNameQuery(GetListByBookNameQuery(usersList, tbxBookName), tbxAuthor), tbxPublisher), rbtnReaded), rbtnNotReaded), rbtnHasNotes), rbtnHasNoNotes), rbtnNative), rbtnNotNative);
            }
            return new List<UserBook>();
            // burada count = 0 dönüyorum ki mainde dgv de !=0 !=null ve >0 durumları için ayrı cevap alabilelim. null ve >0 durumları zaten var. count == 0 için dgv düzenlenip flitre için text yazılırsa tamamdır.
        }

        //PRIVATE Helper Methods

        private static List<UserBook> GetListByBookNameQuery(List<UserBook> userBooks, TextBox tbxBookName)
        {
            if (userBooks.Count != 0 && !string.IsNullOrEmpty(StringUtilityHelper.TrimStartAndFinish(tbxBookName.Text)))
            {
                return userBooks.Where(u => u.BookName.Contains(StringUtilityHelper.ToTrLocaleTitleCase(StringUtilityHelper.TrimStartAndFinish(tbxBookName.Text)))).ToList();

                //Contains yerine StartsWith de kullanabiliyorum.Ancak o zaman ilgili parametrenin sadece başından başlıor bakmaya. Yani rüzgara fısıldayan kadınlar için rüz diye aramaya başlaman gerek. fısıldayan yazınca yok diyor. contains dersen içerikte herhangi bir kelimede eşleşme varsa getiriyor.
            }

            return userBooks;
        }

        private static List<UserBook> GetListByAuthorNameQuery(List<UserBook> userBooks, TextBox tbxAuthorName)
        {
            if (userBooks.Count != 0 && !string.IsNullOrEmpty(StringUtilityHelper.TrimStartAndFinish(tbxAuthorName.Text)))
            {
                return userBooks.Where(u => u.AuthorName.Contains(StringUtilityHelper.ToTrLocaleTitleCase(StringUtilityHelper.TrimStartAndFinish(tbxAuthorName.Text)))).ToList();
            }
            return userBooks;
        }

        private static List<UserBook> GetListByPublisherQuery(List<UserBook> userBooks, TextBox tbxPublisherName)
        {
            if (userBooks.Count != 0 && !string.IsNullOrEmpty(StringUtilityHelper.TrimStartAndFinish(tbxPublisherName.Text)))
            {
                return userBooks.Where(u => u.Publisher.Contains(StringUtilityHelper.ToTrLocaleTitleCase(StringUtilityHelper.TrimStartAndFinish(tbxPublisherName.Text)))).ToList();
            }
            return userBooks;
        }

        private static List<UserBook> GetListByReadedQuery(List<UserBook> userBooks, RadioButton rbtnReaded)
        {
            if (userBooks.Count != 0 && rbtnReaded.Checked)
            {
                return userBooks.Where(u => u.Readed == true).ToList();
            }
            return userBooks;
        }

        private static List<UserBook> GetListByNotReadedQuery(List<UserBook> userBooks, RadioButton rbtnNotReaded)
        {
            if (userBooks.Count != 0 && rbtnNotReaded.Checked)
            {
                return userBooks.Where(u => u.Readed == false).ToList();
            }
            return userBooks;
        }

        private static List<UserBook> GetListByHasNotesQuery(List<UserBook> userBooks, RadioButton rbtnHasNotes)
        {
            if (userBooks.Count != 0 && rbtnHasNotes.Checked)
            {
                return userBooks.Where(u => u.Note != string.Empty).ToList();
            }
            return userBooks;
        }

        private static List<UserBook> GetListByHasNoNotesQuery(List<UserBook> userBooks, RadioButton rbtnHasNoNotes)
        {
            if (userBooks.Count != 0 && rbtnHasNoNotes.Checked)
            {
                return userBooks.Where(u => u.Note == string.Empty).ToList();
            }
            return userBooks;
        }

        private static List<UserBook> GetListByNativeQuery(List<UserBook> userBooks, RadioButton rbtnNative)
        {
            if (userBooks.Count != 0 && rbtnNative.Checked)
            {
                return userBooks.Where(u => u.Native == true).ToList();
            }
            return userBooks;
        }

        private static List<UserBook> GetListByNotNativeQuery(List<UserBook> userBooks, RadioButton rbtnNotNative)
        {
            if (userBooks.Count != 0 && rbtnNotNative.Checked)
            {
                return userBooks.Where(u => u.Native == false).ToList();
            }
            return userBooks;
        }

        private static bool IsIsbnUsedBefore(UserBook userBook)
        {
            var getAllByUserId = GetAllByUserId(userBook.UserId);
            if (userBook.Id == 0)
            {
                if (getAllByUserId != null && getAllByUserId.Any(u => u.Isbn == userBook.Isbn))
                {
                    System.Windows.Forms.MessageBox.Show(Messages.IsbnUsedBefore);
                    return false;
                }
                return true;
            }
            else
            {
                if (getAllByUserId != null && getAllByUserId.Any(u => u.Id != userBook.Id && u.Isbn == userBook.Isbn))
                {
                    System.Windows.Forms.MessageBox.Show(Messages.IsbnUsedBefore);
                    return false;
                }
                return true;
            }
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
            }
            return false;
        }

        private static UserBook EditAuthorNameByNativeState(UserBook userBook)
        {
            // Checked.
            if (userBook.Native)
            {
                userBook.AuthorName = StringUtilityHelper.ToTrLocaleTitleCase(StringUtilityHelper.TrimStartAndFinish(userBook.AuthorName));
                return userBook;
            }
            userBook.AuthorName = StringUtilityHelper.ToEngLocaleTitleCase(StringUtilityHelper.TrimStartAndFinish(userBook.AuthorName));
            return userBook;
        }

        private static UserBook NoteTrimmer(UserBook userBook)
        {
            // Checked.
            userBook.Note = StringUtilityHelper.TrimStartAndFinish(userBook.Note);
            return userBook;
        }

        private static UserBook PublisherToTitleCaseAndTrim(UserBook userBook)
        {
            userBook.Publisher = StringUtilityHelper.ToTrLocaleTitleCase(StringUtilityHelper.TrimStartAndFinish(userBook.Publisher));
            return userBook;
        }

        private static UserBook BookNameToTitleCaseAndTrim(UserBook userBook)
        {
            userBook.BookName = StringUtilityHelper.ToTrLocaleTitleCase(StringUtilityHelper.TrimStartAndFinish(userBook.BookName));
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
