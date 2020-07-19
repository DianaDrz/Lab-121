using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz_E1
{
    class Persona
    {
        protected string ci, nombres, apellidos, celular;

        public Persona() { }
        public Persona(string c, string n, string a,  string cel )
        {
            ci = c;
            nombres = n;
            apellidos = a;
            celular = cel;
        }
        public string getnombre()
        {
            return nombres;
        }
    }
}
