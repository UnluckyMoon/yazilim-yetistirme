using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    public class Urun
    {
        //property- özellik

        public int Id { get; set; }
        public string adi { get; set; }
        public int  fiyatı  { get; set; }

        public string aciklamasi { get; set; }

        public int StokAdeti { get; set; }
    }
}
