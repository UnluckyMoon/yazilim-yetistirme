using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class sepetManager
    {

        //naming convention - isimlendirme
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete Eklendi"+" : "+urun.adi+" : "+urun.fiyatı);

        }
        // aşağıdaki kod hatalı değildir ama sadece çok uğraştırır
        // bu kodun değişikliği sayfalarca olur bu tavsiye edilmez
       
        public void Ekle2(string urunAdi,string aciklama, double fiyat)
        {

            Console.WriteLine("Sepete Eklendi" + " : " + urunAdi);
        }
    }
}
