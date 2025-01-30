using System.Net.Http.Headers;
using System.Text.Json;


namespace Drinks_Info
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            using HttpClient client = new();
            var drinks = await ProcessDrinksAsync(client);
            foreach (var drink in drinks)
            {
                Console.WriteLine($"Name: {drink.Name}");
                if (drink.Category != "null")
                {
                    Console.WriteLine($"Category: {drink.Category}");
                }
                if (drink.Glass != "null")
                {
                    Console.WriteLine($"Glass: {drink.Glass}");
                }

                Console.WriteLine("Ingredients:");
                if (drink.Ingredient1 != "null")
                {
                    Console.WriteLine($"1. {drink.Measure1} of {drink.Ingredient1}");
                }
                if (drink.Ingredient2 != "null")
                {
                    Console.WriteLine($"2. {drink.Measure2} of {drink.Ingredient2}");
                }


                Console.WriteLine($"Instructions: {drink.Instructions}");
                Console.WriteLine("");
            }

        }

        static async Task<List<Drink>> ProcessDrinksAsync(HttpClient client)
        {
            await using Stream stream =
                await client.GetStreamAsync(
                "https://www.thecocktaildb.com/api/json/v1/1/search.php?s=margarita");
            var drinks =
                await JsonSerializer.DeserializeAsync<Drinks>(stream);
           
            return drinks.DrinksList ?? new();
            

            
        }
    }
}