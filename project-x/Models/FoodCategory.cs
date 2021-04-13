using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project_x.Models
{
    public class FoodCategory
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string FoodGroup { get; set; }
        public List<FoodItem> FoodItems { get; set; }

        public FoodCategory(string name)
        {
            Name = name;
        }
        public FoodCategory()
        {

        }
    }
}
