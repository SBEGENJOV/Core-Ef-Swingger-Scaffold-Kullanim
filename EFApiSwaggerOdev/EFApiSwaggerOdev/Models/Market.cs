using System;
using System.Collections.Generic;

namespace EFApiSwaggerOdev.Models
{
    public partial class Market
    {
        //public Market()
        //{
        //    Calisans = new HashSet<Calisan>();
        //}

        public int MarketId { get; set; }
        public string? MarketAd { get; set; }
        public string? MarketAdres { get; set; }
        public string? MarketKod { get; set; }
        public int? SubeId { get; set; }

        //public virtual Sube? Sube { get; set; }
        //public virtual ICollection<Calisan> Calisans { get; set; }
    }
}
