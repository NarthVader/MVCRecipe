using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MVCRecipes.Models
{
    public class MVCRecipesContext : DbContext
    {
        public MVCRecipesContext (DbContextOptions<MVCRecipesContext> options)
            : base(options)
        {
        }

        public DbSet<MVCRecipes.Models.Recipe> Recipe { get; set; }
    }
}
