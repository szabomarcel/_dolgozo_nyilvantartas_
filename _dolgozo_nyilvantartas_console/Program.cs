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
            Nyilvantartas maxPaid = null; // Inicializáljuk a maxPaid-t null-ra
            Nyilvantartas munkakor = null;
            foreach (Nyilvantartas nyilvantart in nyilvantartas)
            {
                if (maxPaid == null || nyilvantart.Salary > maxPaid.Salary)
                {
                    maxPaid = nyilvantart; // Frissítjük a maxPaid-t, ha szükséges
                }
                /*else if (munkakor.Name != munkakor.Position)
                {
                    await Console.Out.WriteLineAsync(munkakor.Position);
                    munkakor = nyilvantart;
                }*/
            }
            if (maxPaid != null)
            {
                Console.WriteLine($"Legjobban fizetett dolgozó neve: {maxPaid.Id} - {maxPaid.Name}");
            }
            /*else if (munkakor != null)
            {
                await Console.Out.WriteLineAsync(munkakor.Name);
            }*/

            else
            {
                await Console.Out.WriteLineAsync("Ez a név nem létezik.");
            }
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
