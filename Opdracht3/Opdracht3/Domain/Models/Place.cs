using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht3.Domain.Models
{
    public class Place
    {
        public Guid Id { get; set; }
        public Guid CategoryId { get; set; }
        public string Name { get; set; }
        public DateTime VisitDate { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string ImagePath { get; set; }
    }
}
