namespace EjemploApp.Modelos
{
    public class Autor
    {
        public int Id { get; set; }   // PK
        public string Nombres { get; set; }
        public string GeneroLiterario { get; set; }
        public string Pais { get; set; }
        public List<Libro>? Libros { get; set; }
    }
}
