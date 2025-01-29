using System.Net.Http.Headers;


namespace Drinks_Info
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            using HttpClient client = new();
            client.DefaultRequestHeaders.Accept.Clear();
            //client.DefaultRequestHeaders.Accept.Add(
            //   new MediaTypeWithQualityHeaderValue(""))
            await ProcessDrinksAsync(client);     

        }

        static async Task ProcessDrinksAsync(HttpClient client)
        {
            var json = await client.GetStringAsync(
                "https://www.thecocktaildb.com/api/json/v1/1/random.php");
            Console.WriteLine(json);
        }
    }
}