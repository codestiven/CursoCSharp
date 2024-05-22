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
        private double nota;
        public string grado;

        public Alumno(string Nombre, int Edad, double notaa, string Grado)
        {
            nombre = Nombre;
            edad = Edad;
            Nota = notaa;
            grado = Grado;
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

        public double Nota
        {
            get { return nota; }
            set
            {
                if (value >= 0 && value <= 10)
                {
                    nota = value;
                }
                else
                {
                    nota = -1;
                }
            }
        }
    }
}
