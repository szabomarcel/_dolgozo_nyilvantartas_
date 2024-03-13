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
    public partial class _dolgozo_Regiszter : Form
    {
        public _dolgozo_Regiszter()
        {
            InitializeComponent();
        }

        private async void button_Register_Click(object sender, EventArgs e)
        {
            var registrationData = new
            {
                Name = textBox_Name.Text,
                Salary = textBox_Salary.Text,
                Position = textBox_Position.Text
                // további adatok hozzáadása...
            };

            // Elküldi a regisztrációs adatokat az API-hoz
            try
            {
                using (var client = new HttpClient())
                {
                    var response = await client.GetAsync("https://retoolapi.dev/Kc6xuH/data");
                    response.EnsureSuccessStatusCode(); // dob kivételt, ha a kérés sikertelen
                    MessageBox.Show("Sikeres regisztráció!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba történt a regisztráció során: " + ex.Message);
            }
        }

        private void _dolgozo_Regiszter_Load(object sender, EventArgs e)
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
