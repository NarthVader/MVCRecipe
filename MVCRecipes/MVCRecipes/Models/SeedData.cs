using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace MVCRecipes.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MVCRecipesContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MVCRecipesContext>>()))
            {
                // Look for any recipes
                if (context.Recipe.Any())
                {
                    return;   // DB has been seeded
                }

                context.Recipe.AddRange(
                    new Recipe
                    {
                        Name = "Cedar Plank Salmon",
                        Ingredients = "1 cedar plank (6 by 14 inches)\r " +
                        "2 salmon fillets(1 1 / 2 pounds total)\r" +
                        "Salt and freshly ground black pepper\r" +
                        "6 tablespoons Dijon mustard\r" +
                        "6 tablespoons brown sugar",
                        Directions = "Soak cedar plank in salted water for 2 hours, then drain. Remove skin from salmon fillet. Remove any remaining bones. Rinse the salmon under cold running water and pat dry with paper towels. Generously season the salmon with salt and pepper on both sides. Lay the salmon (on what was skin-side down) on the cedar plank and carefully spread the mustard over the top and sides. Place the brown sugar in a bowl and crumble between your fingers, then sprinkle over the mustard.",
                        Meal = "Dinner"
                    },

                    new Recipe
                    {
                        Name = "Grilled Spiced Chicken Wings",
                        Ingredients = "8 chicken wings (about 1½ pounds), halved through the joint\r" +
                        "1 teaspoon olive oil\r" +
                        "2 teaspoons seafood seasoning (such as Old Bay)\r" +
                        "3 tablespoons unsalted butter, melted ranch dressing, for dipping",
                        Directions = "Heat grill to medium. In a large bowl, toss the wings with the oil and 1 teaspoon of the seafood seasoning. Grill, uncovered, turning once, until cooked through, 15 to 20 minutes.",
                        Meal = "Lunch"
                    },

                    new Recipe
                    {
                        Name = "Cereal",
                        Ingredients = "Milk\r" +
                        "Your favorite box of cereal",
                        Directions = "Pour Cereal in bowl with milk. Enjoy",
                        Meal = "Breakfast"
                    },

                    new Recipe
                    {
                        Name = "Test",
                        Ingredients = "tons of stuff",
                        Directions = "bake it",
                        Meal = "Snack"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
