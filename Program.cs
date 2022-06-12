using System;

namespace kurucu_methodlar 
{
    class Program
    {
        static void Main(string[] args)
        {
            // Söz Dizimi
            // class SinifAdi
            //{
            //      [Erişim Belirleyici] [Veri Tipi] OzellikAdi;
            //      [Erişim Belirleyici] [Geri Dönüş Tipi] MetotAdi([Parametre Listesi])
            //        {
                        //Metot Komutları
            //        }
            //}

            //Erişim Belirleyiciler
            // *Public > Her yerden erişim sağlanır.
            // *Private > Tanımlandığı sınıf içerisinde erişim sağlanır.
            // *Internal > Kendi bulunduğu proje içerisinde erişim sağlanır.
            // *Protected > Sadece tanımlandığı sınıfta ve/veya o sınıftan kalıtım alan diğer miraslarda kullanılabilir.

            Console.WriteLine("********Çalışan 1********");
            
            Calisan calisan1 = new Calisan("Ayşe","Kara",23415634,"İnsan Kaynakları"); // Çalışan sınıfından bir instance oluşturuldu. Alttaki kodlara göre daha kolay ve düzgün bir yazım sağlar.
            calisan1.CalisanBilgileri(); // Çalışan sınıfının içinde yazdırma methodu oluşturmuştuk. Burada üst taraftaki kodda atadığımız değerleri yazdırma işlemi yaptık.

            Console.WriteLine("********Çalışan 2********");
            Calisan calisan2 = new Calisan(); // Çalışan sınıfından yine farklı bir instance oluşturduk. Üstteki yapıya göre oldukça komplex bir yapıdadır.
            calisan2.Ad="Deniz";
            calisan2.Soyad="Arda";
            calisan2.No=25646789;
            calisan2.Departman="Satın Alma";

            calisan2.CalisanBilgileri(); // Üst satırda atadığımız kodları yazdırma işlemi yaptık.
            Console.WriteLine("********Çalışan 3********");
            Calisan calisan3 = new Calisan("Ahmet","Üstün"); // Yine Çalışan sınıfından farklı bir instance oluşturduk ve No,Departman olmadan atadık.
            calisan3.CalisanBilgileri(); // Üst satırda atadığımız kodları yazdırma işlemi yaptık.
        }
    }
    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;
        
        public Calisan(string ad, string soyad, int no, string departman) // Kurucu methoddur. Class ismiyle aynı olması gerekir.
        {
            this.Ad=ad;
            this.Soyad=soyad;
            this.No=no;
            this.Departman=departman;
        }
        public Calisan(string ad, string soyad) // İkinci bir kurucu method tanımladık.
        {
            this.Ad=ad;
            this.Soyad=soyad;
        }
        public Calisan(){} // İlk değer atamasını yapar. Örneğin int ibo; dedik. Burada aslında int ibo=0; yapar gibi birşey oluyor.
        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışanın Adı:{0}",Ad);
            Console.WriteLine("Çalışanın Soyadı:{0}",Soyad);
            Console.WriteLine("Çalışanın Numarası:{0}",No);
            Console.WriteLine("Çalışanın Departmanı:{0}",Departman);
        }

    }
}