
using CursoCSharp;



Alumno a1 = new Alumno("AAA",52,7.1, "software");

Alumno a2 = new Alumno("AAA", 52, 7.1, "software");

Alumno a3 = new Alumno("AAA", 52, 7.1, "software");

Alumno a4 = new Alumno("AAA", 52, 7.1, "software");

Console.WriteLine($"Nombre: {a1.nombre}, Edad: {a1.edad}, Nota: {a1.Nota}, Grado: {a1.grado}" + " aprobo? " + a1.Aprobado() );

Console.WriteLine(Alumno.alumnot);

Fraces.Saludar();