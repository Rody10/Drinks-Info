using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Drinks_Info
{
    internal static class APIService
    {
        // Obtains a list of Drinks. Each Drink has a name, ingredients, quantity and instructions 
        public static async Task<List<Drink>> ProcessDrinksInformationAsync(HttpClient client, String category)
        {
            await using Stream stream =
                await client.GetStreamAsync(
                $"https://www.thecocktaildb.com/api/json/v1/1/search.php?s={category}");
            var drinks =
                await JsonSerializer.DeserializeAsync<Drinks>(stream);

            return drinks.DrinksList ?? new();
        }

        // Obtains a list of DrinkCategories. Each DrinkCategory has a name 
        public static async Task<List<DrinkCategory>> ProcessDrinkCategoriesAsync(HttpClient client)
        {
            await using Stream stream =
                await client.GetStreamAsync(
                $"https://www.thecocktaildb.com/api/json/v1/1/list.php?c=list");
            var drinkCategories =
                await JsonSerializer.DeserializeAsync<DrinkCategories>(stream);

            return drinkCategories.DrinkCategoriesList ?? new();
        }
    }
}
