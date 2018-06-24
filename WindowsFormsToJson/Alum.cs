using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsToJson
{
    class Alum
    {
        //tipo alumno datos a recojer.
        private int id;
        private string nombre;
        private string apellidos;
        private string dni;

        //GETTERS Y SETTERS
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Dni { get; set; }
    }
}
