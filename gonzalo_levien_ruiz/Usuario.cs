using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gonzalo_levien_ruiz
{
    public partial class Usuario : Form
    {
        public Usuario(string nombre)
        {
            InitializeComponent();
            label1.Text = "Bienvenido a Lexa Consulting " + nombre;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form1 rec = new Form1();
            rec.cerrar();
        }
    }
}
