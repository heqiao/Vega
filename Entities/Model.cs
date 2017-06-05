using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Vega.Entities
{
    public class Model : BaseEntity
    {
        public string Name { get; set; }
        public Make Make { get; set; }
        public int MakeId { get; set; }
        public ICollection<ModelFeature> ModelFeatures { get; set; }

    }
}