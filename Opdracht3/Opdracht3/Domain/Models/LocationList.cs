using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht3.Domain.Models
{
    public class LocationList
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public List<Location> Locations {get; set;}
    }
}
