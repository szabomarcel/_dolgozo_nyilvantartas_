using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _dolgozo_nyilvatartas_windows_forms_app
{
    internal static class Program
    {
        public static Form1 form1 = null;
        public static _dolgozo_Login _Dolgozo_Login = null;
        public static _dolgozo_Regiszter _Dolgozo_Regiszter = null;
        public static _dolgozo_Modify _Dolgozo_Modify = null;
        public static _dolgozo_Delete _Dolgozo_Delete = null;
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            form1 = new Form1();
            _Dolgozo_Login = new _dolgozo_Login();
            _Dolgozo_Regiszter = new _dolgozo_Regiszter();
            _Dolgozo_Modify = new _dolgozo_Modify();
            _Dolgozo_Delete = new _dolgozo_Delete();
            Application.Run(_Dolgozo_Login);
        }
    }
}
