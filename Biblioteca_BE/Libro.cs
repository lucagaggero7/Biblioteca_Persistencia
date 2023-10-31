using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_BE
{
    public class Libro
    {
        public string Nombrelibro { get; set; }
        public string Autor { get; set; }
        public string Editorial { get; set; }
        public string Periodo { get; set; }

        public void Agregar(string aNombrelibro,
                     string aAutor,
                     string aEditorial,
                     string aPeriodo)
        {
            Nombrelibro = aNombrelibro;
            Autor = aAutor;
            Editorial = aEditorial;
            Periodo = aPeriodo;
        }
    }
}

