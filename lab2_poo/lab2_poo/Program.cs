using System;

namespace lab_2
{
    class proyecto

    {
        public static void proyecto.Main(string[] args)
        {


            // Creamos un objetos de la clase Cancion.
            Cancion c = new Cancion();
            // Imprimimos sus datos
            Console.WriteLine("Genero: " + c.GetGenero() + ", Artista: " + c.GetArtista() + ", Album: " + c.GetAlbum() + ", Nombre: " + c.GetNombre());
        }
    }

}