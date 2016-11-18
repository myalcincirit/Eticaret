using System;
using System.Collections.Generic;

namespace Eticaret.Models
{
    public partial class Admin
    {
        public int id { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
    }
}
