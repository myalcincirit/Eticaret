using System;
using System.Collections.Generic;

namespace Eticaret.Models
{
    public partial class Sepet
    {
        public int id { get; set; }
        public Nullable<int> KullaniciId { get; set; }
        public Nullable<int> UrunId { get; set; }
    }
}
