
//using Microsoft.EntityFrameworkCore;

//namespace DesignPattern.ChainOfResponsibility.DAL
//{
//    public class V4Context : DbContext
//    {

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            optionsBuilder.UseSqlServer("server=DESKTOP-K88T80S\\SQLEXPRESS;initial catalog=DesignPattern1;integrated security=true;");
//        }

//        public DbSet<V4CustomerProcess> V4CustomerProcesses { get; set; }
        
//    }

//}

///*
 
//1. not bitiş CustomerProcess den geldik

//2. not baslangıc 

//:DbContext den miras alalım 
 
//override OnConfi yazınca kendı tamamlıyor .net te code first de db i ayaga kaldırma işlemi bu 


//            optionsBuilder.UseSqlServer("server=DESKTOP-K88T80S\\SQLEXPRESS;initial catalog=DesignPattern1;integrated security=true;");

//server => sql servername
//initial catalog => db adı 
//integrated security => güvenlik ayarı

//        public DbSet<V4CustomerProcess> V4CustomerProcesses { get; set; }

//dbset ile db e gonderiyoruz class ı 

//V4CustomerProcess sınıf adı
//V4CustomerProcesses tablo adı

//diger videodan devam edelim

 
//*/