using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Persona
    {
        public Persona(string nombre,string identifiacion, string sexo, int edad )
        {
            Nombre = nombre;
            Edad = edad;
            Sexo = sexo;
            Identificacion = identifiacion;
            Edad = edad;
        }
        public Persona()
        {
            
        }
        public string Nombre { get; set; }
        public int Edad {  get; set; }
        public string Sexo { get; set; }
        public string Identificacion { get; set; }
        public string Pulsacion { get; set; }

    }
}
