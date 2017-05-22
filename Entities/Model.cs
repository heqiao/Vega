using System;
using System.Collections.Generic;
using System.Linq;

namespace Vega.Entities
{
    public class Model : BaseEntity
    {
        public string Name { get; set; }
        public virtual Make Make { get; set; }
        public virtual IEnumerable<Feature> Features { get; set; }
    }
}