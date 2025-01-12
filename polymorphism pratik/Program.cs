using System;

namespace GeometriUygulamasi
{
    // Base sınıf, tüm geometrik şekiller için ortak özellikleri ve metodu içerir.
    public abstract class BaseGeometrikSekil
    {
        public double Genislik { get; set; }
        public double Yükseklik { get; set; }

        // Alan hesaplama metodunu abstract yaparak, türeyen sınıflarda bu metodun implemente edilmesini zorunlu hale getiriyoruz.
        public abstract double AlanHesapla();
    }

    // Kare sınıfı, BaseGeometrikSekil'den türemektedir.
    public class Kare : BaseGeometrikSekil
    {
        public Kare(double kenarUzunlugu)
        {
            Genislik = kenarUzunlugu;
            Yükseklik = kenarUzunlugu;  // Kare olduğu için genellikle genişlik ve yükseklik eşittir.
        }

        // Alan hesaplama metodunu implement ediyoruz.
        public override double AlanHesapla()
        {
            return Genislik * Yükseklik;  // Alan = kenar^2
        }
    }

    // Dikdörtgen sınıfı, BaseGeometrikSekil'den türemektedir.
    public class Dikdortgen : BaseGeometrikSekil
    {
        public Dikdortgen(double genislik, double yukseklik)
        {
            Genislik = genislik;
            Yükseklik = yukseklik;
        }

        // Alan hesaplama metodunu implement ediyoruz.
        public override double AlanHesapla()
        {
            return Genislik * Yükseklik;  // Alan = Genişlik * Yükseklik
        }
    }

    // Dik Üçgen sınıfı, BaseGeometrikSekil'den türemektedir.
    public class DikUcgen : BaseGeometrikSekil
    {
        public DikUcgen(double genislik, double yukseklik)
        {
            Genislik = genislik;
            Yükseklik = yukseklik;
        }

        // Alan hesaplama metodunu implement ediyoruz.
        public override double AlanHesapla()
        {
            return (Genislik * Yükseklik) / 2;  // Alan = (Genişlik * Yükseklik) / 2
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Farklı şekillerden nesneler oluşturuyoruz.
            BaseGeometrikSekil kare = new Kare(4);
            BaseGeometrikSekil dikdortgen = new Dikdortgen(5, 10);
            BaseGeometrikSekil dikUcgen = new DikUcgen(6, 8);

            // Her bir şeklin alanını hesaplayıp yazdırıyoruz.
            Console.WriteLine("Kare'nin Alanı: " + kare.AlanHesapla());
            Console.WriteLine("Dikdörtgen'in Alanı: " + dikdortgen.AlanHesapla());
            Console.WriteLine("Dik Üçgen'in Alanı: " + dikUcgen.AlanHesapla());

            Console.ReadKey();
        }
    }
}
