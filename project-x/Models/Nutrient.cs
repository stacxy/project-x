using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project_x.Models
{
    public class Nutrient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Abbrev { get; set; }
        public string Unit { get; set; } //of measurement

        public Nutrient(string name)
        {
            Name = name;
        }

        public Nutrient()
        {

        }
    }
}
