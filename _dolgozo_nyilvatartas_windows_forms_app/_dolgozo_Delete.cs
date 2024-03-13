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
    public partial class _dolgozo_Delete : Form
    {
        public _dolgozo_Delete()
        {
            InitializeComponent();
        }

        private void _dolgozo_Delete_Load(object sender, EventArgs e)
        {
            if (MessageBox.Show("Valóban ki akar lépni?", "kilépés", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //System.Windows.Forms.Application.Exit();
                //Environment.Exit(0);
                System.Windows.Forms.Application.ExitThread();
            }
        }

        private void listBox_Dolgozok_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
