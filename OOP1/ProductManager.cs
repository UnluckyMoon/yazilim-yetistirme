using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    //(C)reate (R)ead (U)pdate (D)elete
    class ProductManager
    {
        public void Add(Product product)
        {

            Console.WriteLine(product.ProductName+ " eklendi.");
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");

        }
        






























        // bu sekılde yazarsak eğer çıkan veriyi tutar ve üzerinde işlem yapmamıza izin verir
        public int Topla(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;
        }

        //void emir kipi git yap bitir
        public void Topla2(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1+sayi2);
        }
    }
}
