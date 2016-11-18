using System;
using System.Collections.Generic;

namespace Eticaret.Models
{
    public partial class Kategoriler
    {
        public int id { get; set; }
        public string KategoriAd { get; set; }
        public Nullable<int> Urunİd { get; set; }
    }
}
