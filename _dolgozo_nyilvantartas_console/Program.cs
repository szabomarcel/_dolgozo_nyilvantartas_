using Dolgozo;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Dolgozo;

namespace _dolgozo_nyilvantartas_console
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            List<Nyilvantartas> nyilvantartas = new List<Nyilvantartas>();
            //List<Nyilvantartas> nyilvantartas2 = new List<Nyilvantartas>();
            nyilvantartas = await dolgozoNyilvantartasconsole();
            Console.WriteLine($"Dolgozok száma: {nyilvantartas.Count()}");
            /*foreach (Nyilvantartas nyilvantart in nyilvantartas)
            {
                Console.WriteLine($"{nyilvantart.Salary} - {nyilvantart.Name}");
            }*/
            //nyilvantartas2 = await munkakor();
            await Console.Out.WriteLineAsync("Program vége");
            Console.ReadLine();
        }

        private static async Task<List<Nyilvantartas>> dolgozoNyilvantartasconsole()
        {
            List<Nyilvantartas> nyilvantartas = new List<Nyilvantartas>();
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, "https://retoolapi.dev/Kc6xuH/data");
            var response = await client.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                string jsonString = await response.Content.ReadAsStringAsync();
                nyilvantartas = Nyilvantartas.FromJson(jsonString).ToList();
            }
            return nyilvantartas;
        }

        /*private static async Task<List<Nyilvantartas>> munkakor()
        {
            List<Nyilvantartas> nyilvantartas2 = new List<Nyilvantartas>();
            var positionCounts = nyilvantartas2.GroupBy(e => e.Position).Select(group => new { Position = group.Key, Count = group.Count() });

            /*foreach (Nyilvantartas nyilvantartas1 in nyilvantartas2)
            {
                Console.WriteLine($"{nyilvantartas1.Position}");
            }
            return nyilvantartas2;
        }*/
    }
}
