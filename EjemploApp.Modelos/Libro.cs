using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploApp.Modelos
{
    public class Libro
    {
        public int Id { get; set; }     // PK
        public string Titulo { get; set; }
        public int AñoPublicacion { get; set; }
        public int NroEdicion { get; set; }
        public int NroPaginas { get; set; }

        public int AutorId  { get; set; }  //FK
        public Autor? Autor { get; set; }
    }
}
