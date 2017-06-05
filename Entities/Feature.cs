using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vega.Entities
{
    [Table("Features")]
    public class Feature : BaseEntity
    {
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public ICollection<ModelFeature> ModelFeatures { get; set; }

    }
}