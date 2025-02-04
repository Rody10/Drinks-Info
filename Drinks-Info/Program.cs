using System.Net.Http.Headers;
using System.Text.Json;


namespace Drinks_Info
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            using HttpClient client = new();
            await UI.DispayMenuOptions(client);
            
        }

       


    }
}