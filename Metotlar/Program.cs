using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Urun classının ıcındekı adi fiyati aciklamasi
             * özelliklerini dolduruyoruz aşağıdaki gibi 
             *yeni ürünler oluşturabiliyoruz
             */
            Urun urun1 = new Urun();

            urun1.adi = "elma";
            urun1.fiyatı = 10;
            urun1.aciklamasi = "amasya elması";
            urun1.StokAdeti = 100;

            Urun urun2 = new Urun();
            urun2.adi = "karpuz";
            urun2.fiyatı = 90;
            urun2.aciklamasi = "diyarbakır karpuzu";

            /*
             * Urun classı için bir dizi olusturduk
             * ismine de urunler dedik  ve içine olusturdugumu
             * urunlerın ornek ısımlerını yazdık
            */
            Urun[] urunler = new Urun[]
            {
                urun1,urun2
            };
            // foreach döngüsünü kullanarak dizide kaç tane
            // ürün varsa onu yazdırıyoruz.
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.adi);
                Console.WriteLine(urun.fiyatı);
                Console.WriteLine(urun.aciklamasi);
                Console.WriteLine(urun.StokAdeti);
                Console.WriteLine("-----------------------");


            }
            //instance - örnek
            //encapsulation
            sepetManager sepetManager = new sepetManager();
            bool sepeteeklendi = true;
            if (sepeteeklendi == true)
            {
                sepetManager.Ekle(urun1);
                sepetManager.Ekle(urun2);
            }
            else {
                Console.WriteLine("sepet boş");
                    };
            // buraya yazdıgım bılgıler sepet managerdeki metot koduna gidiyor 
            //bu kod ta vsiye edilmeaz
            sepetManager.Ekle2("armut", "yeşil armut", 12);
            sepetManager.Ekle2("elma", "yeşil elma", 12);
            sepetManager.Ekle2("karpuz", "yeşil armut", 12);

        }
    }
}
 




//metotlar tekrar tekrar kullanılabilen bloglardır