﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Readed_Book_Lister.Constants
{
    public class Messages
    {
        public static string RegisterSuccessful = "Kayıt başarılı.";
        public static string UserNotFoundByName = "Kullanıcı bulunamadı.";
        public static string UserNotFoundById = "Kullanıcı id'si hatalı.";
        public static string NickNameExists = "Kullanıcı adı kullanımda.";
        public static string LoginError = "Hatalı giriş. Lütfen yeniden deneyin.";
        public static string UserNotFound = "Kullanıcı kaydına ulaşılamadı.";
        public static string UserUpdateSuccesful = "Kullanıcı başarıyla güncellendi.";
        public static string CurrentPasswordError = "Mevcut parolanızı hatalı girdiniz.";
        public static string DeleteUserSuccesful = "Kullanıcı başarıyla silindi.";
        public static string UsersListIsEmpty = "Kayıtlı kullanıcı yok.";
        public static string UserBookAddSuccessful = "Kitap başarıyla kaydedildi.";        
        public static string NoBookForNativeStatue = "Bu statüde kayıtlı kitabınız yoktur.";
        public static string NoBookWithNote = "Notu olan kitabınız bulunmamaktadır.";
        public static string NoBookWithoutNote = "Notu olmayan kitabınız bulunmamaktadır.";               
        public static string UsersFileNotExist = "Kullanıcı dosyası bulunamadı.";
        public static string UserBooksFileNotExist = "Kullanıcı kitapları dosyası bulunamadı.";        
        public static string NoUserBookByBookName = "Belirtilen isimde kayıtlı kitap yoktur.";
        public static string NoUserBookByAuthorName = "Belirtilen yazar adında kayıtlı kitap yoktur.";
        public static string NoUserBookByUserBookId = "Belirtilen kitaba erişilemiyor.";
        public static string UserBookUpdateSuccessful = "Kitap başarıyla güncellendi.";
        public static string DeleteUserBookSuccessful = "Kitap başarıyla silindi.";
        public static string IsbnUsedBefore = "Belirtilen ISBN daha önce kullanılmış.";
        public static string NoBookByIsnbNo = "Belirtilen Isbn numarasına sahip kitabınız yok.";
        public static string NewPasswordAndNewPasswordAgainDoesNotMatch = "Yeni şifre ve Yeni Şifre Tekrar alanları eşleşmiyor.";
        public static string AnErrorOccured = "Silme sırasında bir hata meydana geldi.";

        //Form
        public static string AllFieldsAreRequired = "Tüm alanları doldurunuz.";
        public static string PasswordMatchError = "Parolalar eşleşmiyor.";
        public static string ImageNotProper = "Uygun olmayan öznitelikler (saydam alan vb). Farklı bir resim ile yeniden deneyiniz.";
        public static string AreYouSureToDeleteYourProfile = "Profilinizi silmek, kitaplarınız dahil tüm verilerinizi de siler. Bu işlem geri alınamaz. Devam etmek istediğinize emin misiniz?";
        public static string AreYouSureToDeleteUserBook = "Kitabı silmek istediğinize emin misiniz?";

        //DataGridView Messages (Main)
        public static string DataGridViewMessagesUserHasNoBook = "Sistemde kayıtlı kitabınız bulunmamaktadır. Kitap eklediğinizde burada görüntülenecektir.";
        public static string NoDataByFilter = "Belirttiğiniz flitreye uygun kitap bulunmamaktadır. Arama kriterlerinizi değiştirip tekrar deneyiniz.";

        //DataGridView Messages (Statistics)
        public static string NoStatisticByThisSelection = "İlgili aralıkta kayıtlı okunmuş kitabınız bulunmamaktadır.";
        
    }
}
