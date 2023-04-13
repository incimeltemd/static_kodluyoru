using System;

namespace classes
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("çalışan sayısı= " + Calisan.CalisanSayisi);
            Calisan calisan = new Calisan("Ahmet","Canli","IK");
            Calisan calisan2 = new Calisan("Meltem","Canli","IK");
            Calisan calisan3 = new Calisan("Murat","Canli","IK");
            Console.WriteLine("çalışan sayısı= " + Calisan.CalisanSayisi);

            Console.WriteLine("toplam sonucu= " + İslemler.Topla(200,50));
            Console.WriteLine("çıkarma sonucu= " + İslemler.Cikarma(200,50));

        }
    }

    class Calisan
    {
        private static int calisanSayisi;

        public static int CalisanSayisi { get => calisanSayisi;}
        private string Isim;
        private string Soyisim;
        private string Departman;

       static Calisan()
       {
            calisanSayisi = 0;
       }
        public Calisan(string isim, string soyisim, string departman)
        {
            this.Isim = isim;
            this.Soyisim = soyisim;
            this.Departman = departman;
            calisanSayisi++;
        }
            
    }
    static class İslemler
    {
        public static long Topla(int sayi1, int sayi2)
        {
            return sayi1+sayi2;
        }

        public static long Cikarma(int sayi1, int sayi2)
        {
            return sayi1-sayi2;
        }
    }
}
