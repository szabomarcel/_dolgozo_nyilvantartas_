using Dolgozo;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Dolgozo;
using System.Reflection.Emit;

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
            Nyilvantartas maxPaid = null;
            foreach (Nyilvantartas nyilvantart in nyilvantartas)
            {
                if(maxPaid == null || nyilvantartas.Count > maxPaid.Salary || maxPaid != null)
                {
                    maxPaid = nyilvantart; // Frissítjük a maxPaidEmployee-t, ha szükséges
                    Console.WriteLine($"Legjobban fizetett dolgozó neve: {maxPaid.Name}");
                }
                else
                {
                    await Console.Out.WriteLineAsync("Ez a név nem létezik.");
                }
            }
            /*foreach (Nyilvantartas nyilvantartas1 in nyilvantartas)
            {
                Nyilvantartas munkakor = null;
                if(munkakor == null || munkakor != null || munkakor.Name == munkakor.Position)
                {
                    await Console.Out.WriteLineAsync(munkakor.Position);
                }
            }*/
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
    }
}
