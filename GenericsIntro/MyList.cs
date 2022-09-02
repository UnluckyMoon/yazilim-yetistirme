using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        //constructor
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            //geçiçi bellek //geçiçi belleği oluşturmamızın sebebi
            //İtems =new dediğimizde bize yeni bir referans numarası açıyor
            //ve diğer referans numarasını unutuyordu ama geçiçi bellek
            // yeni referanstan önce açılmış olan referansın içindeki belleği tutuyor
            // ki yeni bir referans açılırsa kaybolmasın
            T[] tempArray = items;
            // mevcutta eleman sayısı kaçsa bbir arttır.
            items = new T[items.Length + 1];

            // for göngüsünü geçiçi bellekte tuttugumuz referansları
            // yeni açılan referansa sırasıyla geçirmek için kullanıyoruz
            for (int i = 0; i < tempArray.Length; i++)
            {
                // burada ki gibi
                // referans tiplerde direk adres geçiyor
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item;
        }
        
    }
}
