using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaz_E1
{
    class Docente : Persona
    {
        private string NroItem;
        public Docente() : base() { }
        public Docente(string c, string n, string a, string cel, string nro) : base(c,n,a,cel)
        {
            NroItem = nro;
        }

        public void escribirDoc(BinaryWriter escritor)
        {
            escritor.Write(ci);
            escritor.Write(nombres);
            escritor.Write(apellidos);
            escritor.Write(celular);
            escritor.Write(NroItem);
        }
        public void leerDoc(BinaryReader lector)
        {
            nombres = lector.ReadString();
            apellidos = lector.ReadString();
            ci = lector.ReadString();
            celular = lector.ReadString();
            NroItem = lector.ReadString();
        }
        public string obtenerDatos()
        {
            return "Nombre: "+nombres+"     Apellidos:"+apellidos+"      Ci:"+ci+ "      Celular:" + celular+ "      NroItem" + NroItem;
        }
    }
}
