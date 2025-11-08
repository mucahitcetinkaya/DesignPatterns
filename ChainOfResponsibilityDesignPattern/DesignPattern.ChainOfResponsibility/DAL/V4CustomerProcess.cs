
//namespace DesignPattern.ChainOfResponsibility.DAL
//{
//    public class V4CustomerProcess
//    {

//        public int CustomerProcessID { get; set; }
//        public string Name { get; set; }
//        public string Amount { get; set; }
//        public string EmployeeName { get; set; }
//        public string Description { get; set; }


//    }
//}


///*
 

//1. not baslangıc b1 v4 den geldik

//gerekli probları tanımlamaız gerekiyor
//buradaki planlar

//musteri bankaya gidecek veznedara gidecek para isteyecek olumlu olumsuz cevap alacak olumsuz ise bir üstüne yönlendirecek tarih ve saat bilgisi olacak sonra 2. adım gelecek vs 

//1- Ali Çınar => 340.000 - Veznedar Ayşe Öztürk - Veznedar olarak bu parayı ödeyemiyorum, bu sebeple işlemi Müdür yardımcıma iletiyorum. - 08.11.2025 - 20:22
//2- Ali Çınar => 340.000 - Müdür Yardımcısı Merve Kayalı ....

//Gerekli probları yazalım 

//        public int CustomerProcessID { get; set; } tutulan id 
//        public string Name { get; set; } musteri adi
//        public string Amount { get; set; } kredi miktarı
//        public string EmployeeName { get; set; } calısan adı 
//        public string Description { get; set; } acıklama
 
//context sınıfına gidelim db ile baglantı yapalım

//1. not bitiş 

 
//*/