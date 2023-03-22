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
         public string SetPaís(string País)
        {
            this.País = País;
            return País;
        }
        public string SetDirector(string Director)
        {
            this.Director = Director;
            return Director;
        }

        public string GetTitulo()
        {
            return Titulo;
        }

        public Int16 GetAño()
        {
            return Año;
        }
         public string GetPaís()
        {
            return País;
        }

         public string GetDirector()
        {
            return Director;
        }

        public void AgregaActor(Actor actor)
        {
            actores.Add(actor);
        }
        public void Imprime()
        {
            Console.WriteLine($"{Titulo} ({Año})");
        }

        public void ImprimeActores()
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
        //Constructores
          public Actor (string Nombre, Int16 Año)
        {
            this.Nombre = Nombre; 
            this.Año = Año;
        }
        //Métodos 
        public void Imprime()
        {
            Console.WriteLine($"{Nombre} ({Año})");
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
           p1.SetAño (2019);
           p1.SetPaís("Corea Del Sur");
           p1.SetDirector("Bong Joon-ho");
           p1.AgregaActor(new Actor("Song Kang-ho", 1967));
           p1.ImprimeActores();
           p1.AgregaActor(new Actor("Cho Yeo-jeong", 1981));
           p1.ImprimeActores();
           Console.WriteLine("{0}({1}){2}{3}", p1.GetTitulo(), p1.GetAño(), p1.GetPaís(), p1.GetDirector());
           p2.SetTitulo("La La Land");
           p2.SetAño (2016);
           p2.SetPaís("Estados Unidos");
           p2.SetDirector("Damien Chazelle");
           p2.AgregaActor(new Actor ("Ryan Gosling", 1980));
           p2.ImprimeActores();
           p2.AgregaActor(new Actor ("Emma Stone", 1988));
           p2.ImprimeActores();
           Console.WriteLine("{0}({1}){2}{3}", p2.GetTitulo(), p2.GetAño(), p1.GetPaís(), p1.GetDirector());
        }
    }
} 