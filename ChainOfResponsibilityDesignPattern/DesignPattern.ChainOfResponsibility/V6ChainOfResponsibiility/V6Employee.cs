//using DesignPattern.ChainOfResponsibility.Models;

//namespace DesignPattern.ChainOfResponsibility.V6ChainOfResponsibiility
//{
//    public abstract class V6Employee
//    {

//        protected V6Employee NextApprover;


//        public void SetNextApprover(V6Employee superVisor)
//        {
//            this.NextApprover = superVisor;
//        }

//        public abstract void ProcessRequest(V6CustomerProcessViewModel req);


//    }
//}


///*
 
//3. not baslangıç

//B1_V6 notlardan geldik

//V6Employee
 
// public class V6Employee
//    {
//    }

//abstract class olacak

//    public abstract class V6Employee
//    {
//    }

//abstract class lar ChainOfResponsibility nin yapı taslarından biri gibi bişey

//-------------------------------

//Abstract class ve interface arasındaki en temel fark olarak interface sadece metod imzası taşır. Abstract class ise metod imzaları ve implementasyonları içerir.
 
// Abstract class'lar, diğer sınıfların bir şablona sahip olmasını sağlar ve içi dolu metodlar da içerebilirken, interface'ler sadece metod imzalarını tanımlar ve içi dolu metodlar içeremez. 
//Yani, abstract class'lar daha esnek ve genişletilebilirken, interface'ler daha çok sözleşmeleri ifade eder ve çoklu kalıtımı destekler.
 
// -------------------------------
 
// içine bir protected bir degisken tanımlayalım
//protected kendi bulundugu ve miras aldıgı sınıftan erişmenizi saglayan bir erişim belirleyicisi

//protected olunca bir yerden örnek almak gerekiyor 

//V6Employee sınıfından bir örnek aldık ve NextApprover sonraki onaylayıcı adında bir field tanımladık

//        protected V6Employee NextApprover;

//sonraki onaylayıcı bir calısan oluyor bundan dolayı employee sınıfında bunu tanımladık
//veznader da müdür yard hep sonraki approver calısan oluyor

//birde metot tanımlayalım sonraki onaylayıcıya geçir adımı gibi

//        public void SetNextApprover(V6Employee superVisor)
//        {
//            this.NextApprover = superVisor;
//        }

//V6Employee tipinde supervisor parametresini verdik

//içerideki field e bunun atamasını yaptık

//sonraki onaylayıcı kimse artık setnextapprover i cagıracak parametre gönderecek oradaki kısım da burada atamasını yapacak

//bir metot daha tanımlayalım

//        public abstract void ProcessRequest(V6CustomerProcessViewModel req);

//V6CustomerProcessViewModel den bir request alacak abstract oldugundan body si yok 

//dersi burada bitirelim diger derse gecelim 

//3. not bitiş
 
 
// */