using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vega.Entities
{
    [Table("Models")]
    public class Model : BaseEntity
    {
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public Make Make { get; set; }
        public int MakeId { get; set; }
        // public ICollection<Feature> Features { get; set; }

        // public Model()
        // {
        //     Features = new Collection<Feature>();
        // }
    }
}