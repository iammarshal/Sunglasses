using System;
using System.Collections.Generic;

#nullable disable

namespace Sunglasses_Repository.Models
{
    public partial class Manufacturer
    {
        public Manufacturer()
        {
            Sunglasses = new HashSet<Sunglass>();
        }

        public string ManufacturerId { get; set; }
        public string ManufacturerName { get; set; }
        public string ManufacturerDescription { get; set; }

        public virtual ICollection<Sunglass> Sunglasses { get; set; }
    }
}
