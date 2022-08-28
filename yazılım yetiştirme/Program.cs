using System;

namespace yazılım_yetiştirme
{
    class Program
    {
        static void Main(string[] args)
        {
            string KategoriEtiketi = "Kategori";

            Console.WriteLine(KategoriEtiketi);

            bool sistemeGrişYap = true;
            double DolarDun = 7.70;
            double DolarBugun = 8.25;

            if (DolarDun>DolarBugun)
            {
                Console.WriteLine("Dolar Düştü");
            }
            else if (DolarDun<DolarBugun)
            {
                Console.WriteLine("Dolar Arttı");

            }
            else
            {
                Console.WriteLine("eşittir");
            }

            if (sistemeGrişYap == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");

            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");

            }

        }
    }
}

