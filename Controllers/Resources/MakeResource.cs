using System.Collections.Generic;
using System.Collections.ObjectModel;
using Vega.Core.Entities;

namespace Vega.Controllers.Resources
{
    public class MakeResource : KeyValuePairResource
    {
        public ICollection<KeyValuePairResource> Models { get; set; }
        public MakeResource()
        {
            Models = new Collection<KeyValuePairResource>();            
        }
    }
}