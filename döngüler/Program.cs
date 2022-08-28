using System;

namespace döngüler
{
    class Program
    {
        static void Main(string[] args)
        {

            string kurs1 = "yazılım yetiştirme kampı";
            string kurs2 = "programlama başlangıç kurs";
            string kurs3 = "Java";

            //array-Dizi
            string[] Kurslar = new string[]
            {
                "yazılım yetiştirme kampı"
                ,"programlama başlangıç kurs"
                ,"Java","c++","süheylaya aşık olma kursu"

            };

            for (int i = 0; i < Kurslar.Length; i++) 
            {
                Console.WriteLine(Kurslar[i]);
            }
            Console.WriteLine("for bitti");

            foreach (string kurs in Kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("foreach bitti");
        }
    }
}
