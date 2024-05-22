
using CursoCSharp;



Alumno a1 = new Alumno("AAA",52,7.1, "software");

Console.WriteLine($"Nombre: {a1.nombre}, Edad: {a1.edad}, Nota: {a1.nota}, Grado: {a1.grado}" + " aprobo? " + a1.Aprobado() );