using System;
namespace lab_2_POO
{
    // Clase Person con dos atributos edad y nombre
    public class Cancion
    {
        // Atributos

        public string genero;
        public string artista;
        public string album;
        public string nombre;



        // Constructor vacío
        public Cancion()
        {
            genero = "Pop";
            artista = "Ellie Goulding";

            album = "Lights";

            nombre = "Lights";

        }

        // Constructor con parámetros
        public Cancion(string inputGenero, string inputArtista, string inputAlbum, string inputNombre)

        {

            genero = inputGenero;
            artista = inputArtista;
            album = inputAlbum;
            nombre = inputNombre;
        }


        public string GetNombre()
        {
            return nombre;

        }
        public string GetGenero()
        {
            return genero;

        }

        public string GetArtista()
        {
            return artista;
        }

        public string GetAlbum()
        {
            return album;
        }

    }
}
