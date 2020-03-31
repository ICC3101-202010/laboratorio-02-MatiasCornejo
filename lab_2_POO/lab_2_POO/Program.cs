

using System;
using System.Collections.Generic;

namespace lab_2_POO
{
    class MainClass
    {
        public static void Main()
        {
            List<Cancion> cancions = new List<Cancion>();

            cancions.Add(new Cancion() { nombre= "nombre cancion"});//agrego las cancioness a una lista
            


            Console.WriteLine("bienvenido!");
            // Creamos un objetos de la clase Cancion.
            Cancion c = new Cancion();
            // Imprimimos sus datos
            Console.WriteLine("Genero: " + c.GetGenero() + ", Artista: " + c.GetArtista() + ", Album: " + c.GetAlbum() + ", Nombre: " + c.GetNombre());
            
            foreach (Cancion a in cancions)
            {
                Console.WriteLine(a);//imprime cancion por cancion de la lista
            }
        }

    }
}
