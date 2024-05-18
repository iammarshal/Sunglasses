using System;
using System.Collections.Generic;

#nullable disable

namespace Sunglasses_Repository.Models
{
    public partial class Sunglass
    {
        public int SunglassesId { get; set; }
        public string SunglassesName { get; set; }
        public string Feature { get; set; }
        public string Material { get; set; }
        public string Shape { get; set; }
        public decimal? Price { get; set; }
        public int? Quantity { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ManufacturerId { get; set; }

        public virtual Manufacturer Manufacturer { get; set; }
    }
}
