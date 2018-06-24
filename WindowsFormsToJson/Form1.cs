using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
namespace WindowsFormsToJson
{
    public partial class Form1 : Form
    {
        Alum Alumno = new Alum();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string nombre = textBox2.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
                // Pasamos por parametro a la funcion de parseo json
                ParseJSON(Convert.ToInt32(textBox1.Text), textBox2.Text, textBox3.Text, textBox4.Text);
            }

        private void ParseJSON(int id, string nombre, string apellido, string dni)
        {
            
            Alumno.Id = id;
            Alumno.Nombre = nombre;
            Alumno.Apellidos = apellido;
            Alumno.Dni = dni;

            String JsonListaAlum = JsonConvert.SerializeObject(Alumno);

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            GuardarRegistro(JsonListaAlum);


        }

        private void GuardarRegistro(string Alumno)
        {
            string path = @"C:\Users\G1\source\repos\WindowsFormsToJson\WindowsFormsToJson\ListaAlumnos\DatosDeAlumnos.txt";

            File.Create(path).Dispose();
            using (TextWriter fichero = new StreamWriter(path))
            {
                // Se escribe el objeto Alumno en el fichero.
                fichero.WriteLine(Alumno);
            }
        }
    }
    }

