using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz_E1
{
    class ArchivoDocente
    {
        private string nombre;
        public ArchivoDocente(string na)
        {
            nombre = na;
        }

        public void adicionarDocente(Docente doc)
        {
            Stream arch = File.Open(nombre, FileMode.Append);
            BinaryWriter escribe = new BinaryWriter(arch);
            try
            {
                doc.escribirDoc(escribe);
            }
            catch (Exception)
            {
                Console.WriteLine("Fallo en adicionar el objeto");
            }
            finally
            {
                arch.Close();
            }
        }

        public String datosDocente()
        {
            Stream arch = File.Open(nombre, FileMode.OpenOrCreate);
            BinaryReader lector = new BinaryReader(arch);
            Docente d = new Docente();
            string cad = "";
            try
            {
                Console.WriteLine("\nDatos del Jugador");

                while (true)
                {
                    d.leerDoc(lector);
                    cad += d.obtenerDatos() + "\n";

                }
            }
            catch (Exception)
            {
                Console.WriteLine("Fin de archivo...");
            }
            finally
            {
                arch.Close();
            }
            return cad;
        }

        public String verifica(string x)
        {
            Stream arch = File.Open(nombre, FileMode.OpenOrCreate);
            BinaryReader lector = new BinaryReader(arch);
            Docente d = new Docente();
            string cad = "";
            try
            {
                Console.WriteLine("\nDatos del Jugador");

                while (true)
                {
                    d.leerDoc(lector);
                    if(d.getnombre().Equals(x))
                        cad += d.obtenerDatos() + "\n";

                }
            }
            catch (Exception)
            {
                Console.WriteLine("Fin de archivo...");
            }
            finally
            {
                arch.Close();
            }
            return cad;
        }
    }
}
