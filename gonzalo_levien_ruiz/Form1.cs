using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace gonzalo_levien_ruiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public SqlConnection conectardb = new SqlConnection("Data Source=WIN-MMLGAQC02NE\\DOCUSHARE;Initial Catalog=login; Integrated Security=True");


        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        public void login(string usuario, string pass)
        {
            try
            {
                conectardb.Open();
                string sqlus = "SELECT nombre,tipo_usuario FROM usuarios WHERE usuario=@usuario AND contrasena=@pass";
                SqlCommand cmd = new SqlCommand(sqlus, conectardb);
                cmd.Parameters.AddWithValue("usuario", usuario);
                cmd.Parameters.AddWithValue("pass", pass);
                SqlDataAdapter adt = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adt.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    MessageBox.Show("Accesos Correcto");
                    this.Hide();
                    if (dt.Rows[0][1].ToString() == "Admin")
                    {
                        new Admin(dt.Rows[0][0].ToString()).Show();

                    }
                    else if (dt.Rows[0][1].ToString() == "Usuario")
                    {
                        new Usuario(dt.Rows[0][0].ToString()).Show();
                    }
                }
                else
                {
                    MessageBox.Show("Accesos Denegado, usuario o contraseña incorrectos ");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conectardb.Close();
            }
           
        }

        public void cerrar()
        {
            textBox1.Clear();
            textBox2.Clear();
            this.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            login(textBox1.Text,textBox2.Text);
        }
    }
}
