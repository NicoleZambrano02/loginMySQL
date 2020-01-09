using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class Inicio_de_sesion : Form
    {
        MySqlConnection con;
        Form1 vistas;
        public Inicio_de_sesion()
        {
            InitializeComponent();
            con = new MySqlConnection("Server=localhost;Database=pruebas;user=nz02;Pwd=12345");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Inicio_de_sesion_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open(); //Abrimos la conexion creada.
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM login WHERE Email='" + textBox1.Text + "'AND Pwd='" + textBox2.Text + "' ", con); //Realizamos una selecion de la tabla usuarios.
            MySqlDataReader leer = cmd.ExecuteReader();
            if (leer.Read()) //Si el usuario es correcto nos abrira la otra ventana.
            {
                this.Hide();
                vistas= new Form1();
                vistas.Show();
            }
            else //Si no lo es mostrara este mensaje.
                MessageBox.Show("Error - Ingrese sus datos correctamente");
            con.Close(); //Cerramos la conexion.


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
