using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace gonzalo_levien_ruiz
{
    class conexiondb
    {
        string cadena = "Data Source=WIN-MMLGAQC02NE\\DOCUSHARE;Initial Catalog=login; Integrated Security=True";
        public SqlConnection conectardb = new SqlConnection();

        public conexiondb()
        {
            conectardb.ConnectionString = cadena;
        } 

        public void abrir()
        {
            try
            {
                conectardb.Open();
                Console.WriteLine("Conexion Abierta");
                MessageBox.Show("Accesos Correcto");
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al abrir DB " + ex.Message);
                MessageBox.Show("Accesos Denegado, usuario o contraseña incorrectos");
            }
        }

        public void cerrar()
        {
            conectardb.Close();
        }
    }
}
