using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunglasses_Repository.CustomModels
{
    public class SunglassModel
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
        public string ManufacturerName { get; set; }
    }

}
