using System;
using System.Collections.Generic;

namespace Pelicula
{

    public class Pelicula
    {
        //Campo
        public string Titulo;
        public Int16 Año;
        public string País;
        public string Director;
        private List<Actor> actores = new List<Actor>();
        //Constructores
     public Pelicula ()
     {

     }

     public Pelicula(string Titulo, Int16 Año)
     {
        this.Titulo = Titulo;
        this.Año = Año;
     }
        //Métodos
     
        public void Imprime()
        {
            Console.WriteLine($"{Titulo}({Año})");
        }


    }

    public class Actor
    {
        //Propiedades

        //Constructores


        //Métodos 
        public void Imprime()
        {
            Console.WriteLine($"{Nombre} ({Año})");
        }
    }

    // Puedes probar tu código en Main() pero lo importante
    // es que pase las pruebas
    }
    class Program
    {
        static void Main(string[] args)
        {
           Pelicula p1= new Pelicula();
           Pelicula p2 = new Pelicula();
           Pelicula p1 = new Pelicula();
           p1.SetTitulo("Parasite");
           p1.SetAño(2019);
           Console.WriteLine("{0}({1})", p1.GetTitulo(), p1.GetAño());

        }
    }
} 