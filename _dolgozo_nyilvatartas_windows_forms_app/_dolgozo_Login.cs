using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _dolgozo_nyilvatartas_windows_forms_app
{
    public partial class _dolgozo_Login : Form
    {
        public _dolgozo_Login()
        {
            InitializeComponent();
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            if (Program.name.validUser(textBox_Name.Text, textBox_Position.Text) >= 0)
            {
                Program.form1.Show();
            }
        }

        private void button_Register_Click(object sender, EventArgs e)
        {
            if (Program.name.validUser(textBox_Name.Text, textBox_Position.Text) >=0)
            {
                Program._Dolgozo_Regiszter.Show();
            }
        }
    }
}
