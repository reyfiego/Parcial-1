using System;
using System.Collections;

namespace Parcial
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int Op = 0;
            
            do
            {
                int numestudiantes;
                ArrayList registro = new ArrayList();
                string nombre;
                string apellido;
                int edad;
                double nota1;
                double nota2;
                double parcial;
                double promedio;
                int contador = 0;
                Console.WriteLine("Ingrese el numero de Estudiantes");
                numestudiantes = int.Parse(Console.ReadLine());

                while (contador < numestudiantes)
                {
                    Console.Write("Ingrese el nombre del estudiante: ");
                    nombre = Console.ReadLine();
                    Console.Write("Ingrese el apellido del estudiante: ");
                    apellido = Console.ReadLine();
                    Console.Write("Ingrese la edad del estudiante: ");
                    edad = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese la primera nota del estudiante: ");
                    nota1 = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese la segunda nota del estudiante: ");
                    nota2 = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese la nota del parcial del estudiante: ");
                    parcial = int.Parse(Console.ReadLine());
                    promedio = (nota1 * 0.3) + (nota2 * 0.3) + (parcial * 0.4);
                    
                    Estudiantes estudiantes = new Estudiantes() { Nombre = nombre, Apellido = apellido, Edad = edad, Promedio = promedio };
                    registro.Add(estudiantes);
                    contador++;

                    if (promedio >= 6)
                    {
                        Console.WriteLine("Aprobado");
                    }
                    else
                    {
                        Console.WriteLine("Reprobado");
                    }
                }
                foreach (Estudiantes estus in registro)
                {
                    Console.WriteLine(estus.getdata());
                }
                Console.WriteLine("Si quieres agregar otro estudiante presiona 1, si quieres salir presiona cualquier otro numero");
                Op = int.Parse(Console.ReadLine());
            } while (Op == 1);

        }
    }
}

       public class Estudiantes
       {
             private string _nombre;
             private string _apellido;
             private int _edad;
             private double _promedio;
       public string Nombre
        {
               get => _nombre;
               set => _nombre = value;
        }
        public string Apellido
        {
               get => _apellido;
               set => _apellido = value;
         }
        public int Edad
        {
               get => _edad;
               set => _edad = value;
         }
        public double Promedio
        {
               get => _promedio;
               set => _promedio = value;
        }
        public string getdata()
        {
        return "Nombre: " + _nombre + " Apellido: " + _apellido + " Edad: " + _edad + " Nota: " + _promedio;
        }
}