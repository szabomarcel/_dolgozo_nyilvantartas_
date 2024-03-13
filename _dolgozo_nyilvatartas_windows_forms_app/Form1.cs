using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _dolgozo_nyilvatartas_windows_forms_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }

        private void listBox_Dolgozok_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private async void button_Megjelenes_Click(object sender, EventArgs e)
        {
            try
            {
                string[] dolgozoLista = await GetDolgozokAsync();

                listBox_Dolgozok.Items.Clear();
                listBox_Dolgozok.Items.AddRange(dolgozoLista);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba történt: " + ex.Message);
            }
        }
        private async Task<string[]> GetDolgozokAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://retoolapi.dev/Kc6xuH/data");
                HttpResponseMessage response = await client.GetAsync(client.BaseAddress);

                if (response.IsSuccessStatusCode)
                {
                    string dolgozoJson = await response.Content.ReadAsStringAsync();

                    // BOM eltávolítása
                    if (dolgozoJson.StartsWith("\ufeff"))
                    {
                        dolgozoJson = dolgozoJson.Substring(1);
                    }

                    return JsonConvert.DeserializeObject<string[]>(dolgozoJson);
                }
                else
                {
                    throw new Exception("A szerver hibát adott vissza.");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (MessageBox.Show("Valóban ki akar lépni?", "kilépés", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //System.Windows.Forms.Application.Exit();
                //Environment.Exit(0);
                System.Windows.Forms.Application.ExitThread();
            }
        }
    }
}
