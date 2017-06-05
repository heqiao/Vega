using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Vega.Entities
{
    public class Make : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Model> Models { get; set; }

        public Make()
        {
            Models = new Collection<Model>();
        }
    }   
}