using System;
using System.Collections.Generic;

namespace Pelicula
{

    public class Pelicula
    {
        //Campo
        private string Titulo;
        private Int16 Año;
        private string País;
        private string Director;
        private List<Actor> actores = new List<Actor>();
        //Constructores
   
     public Pelicula(string Titulo, Int16 Año)
     {
        this.Titulo = Titulo;
        this.Año = Año;
     }

     public Pelicula()
     {

     }
        //Métodos
        public string SetTitulo(string Titulo)
        {
            this.Titulo = Titulo;
            return Titulo;
        }

        public Int16 SetAño(Int16 Año)
        {
            this.Año = Año;
            return Año;
        }

        public string GetTitulo()
        {
            return Titulo;
        }

        public Int16 GetAño()
        {
            return Año;
        }
        public void AñadirActor(Actor actor)
        {
            actores.Add(actor);
        }
        public void Imprime()
        {
            Console.WriteLine($"{Titulo}({Año})");
        }

        public void ImprimirActor()
        {
            foreach (Actor protagonista in actores)
            {
                protagonista.Imprime();
            }
        }

    }

    public class Actor
    {
        //Propiedades
        private string Nombre;
        private Int16 Año;
        private string País;
        private Int16 Edad;
        //Constructores
          public Actor (string Nombre, Int16 Año, string País, Int16 Edad)
        {
            this.Nombre = Nombre; 
            this.Año = Año;
            this.País = País;
            this.Edad = Edad;
        }
        //Métodos 
        public void Imprime()
        {
            Console.WriteLine($"{Nombre} {Año} {País} {Edad})");
        }
    }

    // Puedes probar tu código en Main() pero lo importante
    // es que pase las pruebas
    
    class Program
    {
        static void Main(string[] args)
        {
           Pelicula p1 = new Pelicula();
           Pelicula p2 = new Pelicula();
           p1.SetTitulo("Parasite");
           p1.SetAño(2019);
           p1.AñadirActor(new Actor("Song Kang-ho", 1967,"Corea del Sur", 56));
           p1.ImprimirActor();
           Console.WriteLine("{0}({1})", p1.GetTitulo(), p1.GetAño());
           p2.SetTitulo("Everything Everywhere All At Once");
           p2.SetAño(2022);
           p2.AñadirActor(new Actor ("Michelle Yeoh", 1962, "Malasia", 60));
           p2.ImprimirActor();
           Console.WriteLine("{0}({1})", p2.GetTitulo(), p2.GetAño());
        }
    }
} 