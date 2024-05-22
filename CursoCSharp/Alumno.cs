using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp
{
    internal class Alumno
    {
        public string nombre;
        public int edad = 20;
        public double nota;
        public string grado;

        public Alumno(string nombre, int edad, double nota, string grado)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.nota = nota;
            this.grado = grado;
        }

        public bool Aprobado()
        {
            if (nota > 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
