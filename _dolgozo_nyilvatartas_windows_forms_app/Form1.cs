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

        private void button_Megjelenes_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://retoolapi.dev/Kc6xuH/data");
            HttpResponseMessage response = client.GetAsync(client.BaseAddress).Result;
            var dolgozo = response.Content.ReadAsStringAsync().Result;
            dolgozo.Trim();
        }
    }
}
