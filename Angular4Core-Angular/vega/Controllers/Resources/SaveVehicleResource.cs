using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using vega.Models;

namespace vega.Controllers.Resources
{
    public class SaveVehicleResource
    {
        public int Id { get; set; } 
        public int ModelId { get; set; }
        public bool IsRegistred { get; set; }
        public ContactResource Contact { get; set; }
        public ICollection<int> Features { get; set; }
        
        public SaveVehicleResource()
        {
            Features = new Collection<int>();
        }
    }
}