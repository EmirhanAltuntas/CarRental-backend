using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAddedMessage = "Araç Eklendi";
        public static string CarNameInvalidMessage = "Araç ismi geçersiz";
        public static string CarsListed = "Araçlar Listelendi";
        public static string MaintenanceTime = "Sistem Bakımda";
        public static string CarUpdatedMessage = "Araç Güncellendi";
        public static string CarDeletedMessage = "Araç Silindi";
        public static string BrandAddedMessage = "Marka Eklendi";
        public static string BrandDeletedMessage = "Marka Silindi";
        public static string BrandUpdatedMessage = "Marka Güncellendi";
        public static string ColorAddedMessage = "Renk eklendi";
        public static string ColorDeletedMessage = "Renk Silindi";
        public static string ColorsListed = "Renkler Listelendi";
        public static string ColorUpdatedMessage = "Renk Güncellendi";
        public static string UserAddedMessage = "Kullanıcı Eklendi";
        public static string UserDeletedMessage = "Kullanıcı Silindi";
        public static string UsersListed = "Kullanıcılar Listelendi";
        public static string UserUpdatedMessage = "Kullanıcı Güncellendi";
        public static string CustomerAddedMessage = "Müşteri Eklendi";
        public static string CustomerDeletedMessage = "Müşteri Silindi";
        public static string CustomerUpdatedMessage = "Müşteri Güncellendi";
        public static string RentalAddedMessage ="Kiralama Başarılı";
        public static string RentalAddedError ="Kiralama Başarısız";
        public static string CarImageAdded ="Fotoğraf Eklendi";
        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string UserRegistered = "Kayıt oluşturuldu.";
        public static string UserNotFound = "Kullanıcı bulunamadı!";
        public static string PasswordError = "Parola hatası!";
        public static string SuccessfulLogin = "Başarılı giriş.";
        public static string UserAlreadyExists = "Kullanıcı Mevcut";
        public static string AccessTokenCreated = "Token oluşturuldu";
    }
}
