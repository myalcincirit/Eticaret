using System;
using System.Collections.Generic;

namespace Eticaret.Models
{
    public partial class Urunler
    {
        public int id { get; set; }
        public string UrunAdi { get; set; }
        public string UrunFiyati { get; set; }
        public string UrunAciklamasi { get; set; }
        public string UrunResimYol { get; set; }
        public string UrunRengi { get; set; }
        public Nullable<int> cResimId { get; set; }
        public string kUrunResim { get; set; }
        public Nullable<System.DateTime> Tarih { get; set; }
    }
}
