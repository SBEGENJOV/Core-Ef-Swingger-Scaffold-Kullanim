using System;
using System.Collections.Generic;

namespace EFApiSwaggerOdev.Models
{
    public partial class Calisan
    {
        public int CalisanId { get; set; }
        public string? CalisanAd { get; set; }
        public int? CalisanYas { get; set; }
        public string? CalisanGorev { get; set; }
        public int? MarketId { get; set; }

        //public virtual Market? Market { get; set; }
    }
}
