using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Vega.Entities
{
    public class Feature : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<ModelFeature> ModelFeatures { get; set; }

    }
}