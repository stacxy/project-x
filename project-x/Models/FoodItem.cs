using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project_x.Models
{
    public class FoodItem
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public FoodCategory Category { get; set; }
        public int CategoryId { get; set; }

       public List<NutrientValue> NutritionalValue {get; set;}

        public FoodItem(string name)
        {
            Name = name;
        }
        public FoodItem()
        {

        }

    }
}
