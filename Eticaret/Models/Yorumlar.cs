using System;
using System.Collections.Generic;

namespace Eticaret.Models
{
    public partial class Yorumlar
    {
        public int id { get; set; }
        public string Ad { get; set; }
        public string SoyAd { get; set; }
        public string Email { get; set; }
        public string Yorum { get; set; }
        public Nullable<int> UrunId { get; set; }
    }
}
