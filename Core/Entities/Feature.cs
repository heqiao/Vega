using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Vega.Core.Entities
{
    public class Feature : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<ModelFeature> ModelFeatures { get; set; }

    }
}