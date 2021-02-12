using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba eklendi";
        public static string BrandAdded = "Marka eklendi";
        public static string ColorAdded = "Renk eklendi";

        public static string CarDeleted = "Araba silindi";
        public static string BrandDeleted = "Marka silindi";
        public static string ColorDeleted = "Renk silindi";

        public static string CarUpdated = "Araba güncellendi";
        public static string BrandUpdated = "Marka güncellendi";
        public static string ColorUpdated = "Renk güncellendi";

        public static string CarListed = "Arabalar listelendi";
        public static string BrandListed = "Markalar listelendi";
        public static string ColorListed = "Renkler Listelendi";

        public static string CarIdListed = "Araba Id leri listelendi";
        public static string BrandIdListed = "Marka Id leri listelendi";
        public static string ColorIdListed = "Renk Id leri listelendi";

        public static string CarListedByDailyPrice = "Arabalar belirtilen liste fiyatı aralığında listelendi";
        public static string CarListedByModelYear = "Arabalar belirtilen model yıllarına göre listelendi";

        public static string CarDetailsListed = "Araba ayrıntıları listelendi";

        public static string CarDailyPriceInvalid = "Günlük ücret 0'dan küçük olamaz";
        public static string BrandNameInvalid = "Marka bilgisi en az 3 karakterden oluşmalı";
        public static string ColorNameInvalid = "Renk adi bilgisi en az 3 karakterden oluşmalı";
        public static string CarUpdatedInvalid = "Araba güncellenemedi";

    }
}
