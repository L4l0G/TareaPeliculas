using System;
using System.Collections.Generic;

namespace Pelicula
{

    public class Pelicula
    {
        public string Titulo;
        public Int16 Año;
        public string País;
        public string Director;
        //Campos

    class Program
    {
        static void Main(string[] args)
        {
           Pelicula p1= new Pelicula();
           Pelicula p2 = new Pelicula();
           p1.Titulo = "Parasite";
           p1.Año = 2019;
           Console.ReadLine($"{Titulo}");
           Console.ReadLine($"{Año}")
        }
    }
} }