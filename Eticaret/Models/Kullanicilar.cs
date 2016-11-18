using System;
using System.Collections.Generic;

namespace Eticaret.Models
{
    public partial class Kullanicilar
    {
        public int id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Email { get; set; }
        public string Tel { get; set; }
        public string Adress { get; set; }
        public string Sehir { get; set; }
        public string Sifre { get; set; }
    }
}
