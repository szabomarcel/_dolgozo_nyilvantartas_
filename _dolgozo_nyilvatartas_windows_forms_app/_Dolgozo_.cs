using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _dolgozo_nyilvatartas_windows_forms_app
{
    internal class _Dolgozo_
    {
        public int id;
        public string name;
        public int salary;
        public int position;        

        public _Dolgozo_(int id, string name, int salary, int position)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
            this.position = position;
        }
        public override string ToString()
        {
            return $"{id} ({name} van)";
        }
    }
}
