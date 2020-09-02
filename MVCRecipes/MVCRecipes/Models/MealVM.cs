using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using System.Threading.Tasks;

namespace MVCRecipes.Models
{
    public class MealVM
    {
        public List<Recipe> Recipes { get; set; }
        public SelectList MealTime { get; set; }
        public string MealSearchString { get; set; }
        public string NameSearchString { get; set; }
    }
}
