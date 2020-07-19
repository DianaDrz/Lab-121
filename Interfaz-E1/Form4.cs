using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz_E1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            ArchivoDocente d = new ArchivoDocente(@"d:\docentes.dat");
            string[] v = d.datosDocente().Split('\n');
            for (int i = 0; i < v.Length; i++)
            {
                listBox1.Items.Add(v[i].ToString());
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
