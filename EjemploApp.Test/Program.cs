using EjemploApp.Modelos;
using EjemploApp.ConsumeAPI;

namespace EjemploApp.Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var apiUrlAutores = "https://appwebutn2024-dah6gscvfjcde4bm.eastus2-01.azurewebsites.net/api/Autores";
           /*
            Crud<Autor>.Create(apiUrlAutores, new Autor
            {
                Nombres = "JUAN LEON MERA",
                Pais = "EC",
                GeneroLiterario = "DRAMA"
            });

            Crud<Autor>.Create(apiUrlAutores, new Autor
            {
                Nombres = "GABRIEL GARCIA MARQUEZ",
                Pais = "CO",
                GeneroLiterario = "NARRATIVA"
            });
           */
            var apiUrl = "https://appwebutn2024-dah6gscvfjcde4bm.eastus2-01.azurewebsites.net/api/Libros";

            /*
            var libro1 = Crud<Libro>.Create(apiUrl,
                new Libro
                {
                    Titulo = "A LA COSTA",
                    NroPaginas = 90,
                    NroEdicion = 1,
                    AñoPublicacion = 1990,
                    AutorId = 1
                }
            );

            Console.WriteLine(libro1.Titulo + ", TIENE CODIGO: " + libro1.Id);

            libro1.Titulo = "EL CORONEL NO TIENE QUIEN LE ESCRIBA";
            libro1.AutorId = 2;
            Crud<Libro>.Update(apiUrl, libro1.Id, libro1);
            */
            var libro2 = Crud<Libro>.Read_ById(apiUrl, 1);
            Console.WriteLine("LIBRO 1: " + libro2.Titulo);

            Crud<Libro>.Delete(apiUrl, 1);

        }
    }
}
