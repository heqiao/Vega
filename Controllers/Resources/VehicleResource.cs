using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Vega.Controllers.Resources
{
    public class ContactResource {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
    public class VehicleResource
    {
        public int ModelId { get; set; }
        public bool IsRegistered { get; set; }
        public ContactResource Contact { get; set; }
        public ICollection<int> Features { get; set; }

        public VehicleResource()
        {
            Features = new Collection<int>();
        }
    }
}