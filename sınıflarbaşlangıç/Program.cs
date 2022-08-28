using System;

namespace sınıflarbaşlangıç
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "c#";
            kurs1.Egitmen = "yiğithan";
            kurs1.İzlenmeOrani = 32;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "c2";
            kurs2.Egitmen = "yiğithan2";
            kurs2.İzlenmeOrani = 333212;

            Kurs kurs3= new Kurs();
            kurs3.KursAdi = "c3";
            kurs3.Egitmen = "yiğithan3";
            kurs3.İzlenmeOrani = 3122;

            // sınıfı diziye çevirdik ki dizide ki verileri döngüye alalım dıye
            Kurs[] kurslar = new Kurs[]
            {
                kurs1,kurs2,kurs3
            };
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);
                
            }

        }
    }
    class Kurs
    {
        public string KursAdi{ get; set; }
        public string Egitmen { get; set; }
        public int İzlenmeOrani { get; set; }
    }
}
