using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180126_Practica01
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudiante estudiante = new Estudiante("Juan", 18);
            estudiante.Walk.Caminar();
            Profesor profesor = new Profesor("Pedro", 32);
            profesor.Walk.Caminar();
            Console.ReadLine();
        }
    }

    //Objeto
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Walkable Walk { get; set; }

        public void Walking()
        {
            Walk.Caminar();
        }
        public void Eat()
        {
            Console.WriteLine("Comiendo");
        }
        public void Poop()
        {
            Console.WriteLine("Defecando");
        }
    }

    //Herencia de objeto
    public class Estudiante : Person
    {
        public Estudiante(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
            Walk = new WalkTwoFeet();
        }
    }

    //Herencia de objeto
    public class Profesor : Person
    {
        public Profesor(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
            Walk = new WalkFourFeet();
        }
    }

    //Implementacion de interfaz
    public class WalkTwoFeet : Walkable
    {
        public void Caminar()
        {
            Console.WriteLine("Caminando en 2 pies");
        }
    }

    //Implementacion de interfaz
    public class WalkFourFeet : Walkable
    {
        public void Caminar()
        {
            Console.WriteLine("Caminando en 4 pies");
        }
    }

    //Interfaz
    public interface Walkable
    {
        void Caminar();
    }
}
