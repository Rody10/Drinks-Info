using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drinks_Info
{
    internal static class UI
    {   
        public static async Task  DispayMenuOptions(HttpClient client)
        {
            bool terminateApp = false;
            List<DrinkCategory> drinkCategories = await APIService.ProcessDrinkCategoriesAsync(client);
            string ? userChoice = "";
            while (!terminateApp)
            {
                Console.WriteLine("Categories Menu");
                Console.WriteLine("");
                DisplayDrinkCategories(drinkCategories);

                Console.WriteLine("");
                Console.Write("Please enter the category you want (To exit press 0): ");
                userChoice = Console.ReadLine();
                if (userChoice == "0")
                {
                    Environment.Exit(0);
                }            
                List<Drink> drinks = await APIService.ProcessDrinksInformationAsync(client, userChoice);
                if (drinks.Count == 0) // could not find drinks due to either a typo or API did not give drinks under this category (noticed this behaviour when choice is "Party Drink")
                {
                    Console.WriteLine("");
                    Console.WriteLine("Drinks were not found. Either you used the wrong spelling or the drinks are not available. ");
                    Console.WriteLine("");
                }
                DisplayDrinksInformation(drinks);
            }
        }

        static void DisplayDrinkCategories(List<DrinkCategory> drinkCategories)
        {
            foreach (var drinkCategory in drinkCategories)
            {
                Console.WriteLine(drinkCategory.Name);
            }
        }

        static void DisplayDrinksInformation(List<Drink> drinks)
        {
            foreach (var drink in drinks)
            {
                Console.WriteLine($"Name: {drink.Name}");
                if (drink.Category != null)
                {
                    Console.WriteLine($"Category: {drink.Category}");
                }
                if (drink.Glass != null)
                {
                    Console.WriteLine($"Glass: {drink.Glass}");
                }

                Console.WriteLine("Ingredients:");
                if (drink.Ingredient1 != null)
                {
                    if (drink.Measure1 != null)
                    {
                        Console.WriteLine($"1. {drink.Measure1} of {drink.Ingredient1}");
                    }
                    else
                    {
                        Console.WriteLine($"1. {drink.Ingredient1}");
                    }
                }

                if (drink.Ingredient2 != null)
                {
                    if (drink.Measure2 != null)
                    {
                        Console.WriteLine($"2. {drink.Measure2} of {drink.Ingredient2}");
                    }
                    else
                    {
                        Console.WriteLine($"2. {drink.Ingredient2}");
                    }
                }

                if (drink.Ingredient3 != null)
                {
                    if (drink.Measure3 != null)
                    {
                        Console.WriteLine($"3. {drink.Measure3} of {drink.Ingredient3}");
                    }
                    else
                    {
                        Console.WriteLine($"3. {drink.Ingredient3}");
                    }
                }


                if (drink.Ingredient4 != null)
                {
                    if (drink.Measure4 != null)
                    {
                        Console.WriteLine($"4. {drink.Measure4} of {drink.Ingredient4}");
                    }
                    else
                    {
                        Console.WriteLine($"4. {drink.Ingredient4}");
                    }

                }

                if (drink.Ingredient5 != null)
                {
                    if (drink.Measure5 != null)
                    {
                        Console.WriteLine($"5. {drink.Measure5} of {drink.Ingredient5}");
                    }
                    else
                    {
                        Console.WriteLine($"5. {drink.Ingredient5}");
                    }
                }

                if (drink.Ingredient6 != null)
                {
                    if (drink.Measure6 != null)
                    {
                        Console.WriteLine($"6. {drink.Measure6} of {drink.Ingredient6}");
                    }
                    else
                    {
                        Console.WriteLine($"6. {drink.Ingredient6}");
                    }
                }

                if (drink.Ingredient7 != null)
                {
                    if (drink.Measure7 != null)
                    {
                        Console.WriteLine($"7. {drink.Measure7} of {drink.Ingredient7}");
                    }
                    else
                    {
                        Console.WriteLine($"7. {drink.Ingredient7}");
                    }
                }

                if (drink.Ingredient8 != null)
                {
                    if (drink.Measure8 != null)
                    {
                        Console.WriteLine($"8. {drink.Measure8} of {drink.Ingredient8}");
                    }
                    else
                    {
                        Console.WriteLine($"8. {drink.Ingredient8}");
                    }
                }

                if (drink.Ingredient9 != null)
                {
                    if (drink.Measure9 != null)
                    {
                        Console.WriteLine($"9. {drink.Measure9} of {drink.Ingredient9}");
                    }
                    else
                    {
                        Console.WriteLine($"9. {drink.Ingredient9}");
                    }
                }

                if (drink.Ingredient10 != null)
                {
                    if (drink.Measure10 != null)
                    {
                        Console.WriteLine($"10. {drink.Measure10} of {drink.Ingredient10}");
                    }
                    else
                    {
                        Console.WriteLine($"10. {drink.Ingredient10}");
                    }
                }

                if (drink.Ingredient11 != null)
                {
                    if (drink.Measure11 != null)
                    {
                        Console.WriteLine($"11. {drink.Measure11} of {drink.Ingredient11}");
                    }
                    else
                    {
                        Console.WriteLine($"11. {drink.Ingredient11}");
                    }
                }

                if (drink.Ingredient12 != null)
                {
                    if (drink.Measure12 != null)
                    {
                        Console.WriteLine($"12. {drink.Measure2} of {drink.Ingredient12}");
                    }
                    else
                    {
                        Console.WriteLine($"12. {drink.Ingredient12}");
                    }
                }

                if (drink.Ingredient13 != null)
                {
                    if (drink.Measure13 != null)
                    {
                        Console.WriteLine($"13. {drink.Measure13} of {drink.Ingredient13}");
                    }
                    else
                    {
                        Console.WriteLine($"13. {drink.Ingredient13}");
                    }
                }

                if (drink.Ingredient14 != null)
                {
                    if (drink.Measure14 != null)
                    {
                        Console.WriteLine($"14. {drink.Measure14} of {drink.Ingredient14}");
                    }
                    else
                    {
                        Console.WriteLine($"14. {drink.Ingredient14}");
                    }
                }

                if (drink.Ingredient15 != null)
                {
                    if (drink.Measure15 != null)
                    {
                        Console.WriteLine($"15. {drink.Measure15} of {drink.Ingredient15}");
                    }
                    else
                    {
                        Console.WriteLine($"15. {drink.Ingredient15}");
                    }
                }
                Console.WriteLine($"Instructions: {drink.Instructions}");
                Console.WriteLine("");
            }
        }

    }
}
