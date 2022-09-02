using System;

namespace DegerVeReferansTipleri
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 69;
            //sayi1 ?? ------- 30
            // new demek yeni bir adres olustur demek
            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0] ?? --------999


            //int ,decimal, float,double,bool= değer tipleri
            
            // array,class,interface= referans tipleri
            
            //değer tiplerde değeri atıyorsun.
            //Referans tiplerde ise adresi atıyorsun
            /*değertipleri                    Referans tipleri
             *d 
            stack                                   heap
            -------                               ---------
            sayi1=10                              sayilar1 10,20,30                        
            sayi2=30                              sayilar2 100,200,300
            sayi2'nin değerini                     sayilar1'in adresini(eşitleme)
            sayi1'e atadık yani               sayilar2'in adresine atıyorsun
            sayi1 artık 30 oldu                  artık sayilar1 sayilar2'nin adresine bağlı oluyor
            sayi2 ile bir bağlantısı kalmadı             kendi sayilar1 adresinden tamamen kopuyor
            sayi2 ise 65 oldu
            
             */
        }
    }
}
