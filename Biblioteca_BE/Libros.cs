using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_BE
{
    public class Libros
    {

        public DataTable ListaDT { get; set; } = new DataTable();
      
        //Crea la Estructura de la Lista de usuarios
        public Libros()
        {
            ListaDT.TableName = "ListaLibros";
            ListaDT.Columns.Add("Nombrelibro");
            ListaDT.Columns.Add("Autor");
            ListaDT.Columns.Add("Editorial");
            ListaDT.Columns.Add("Periodo");

            LeerArchivo();
        }

        //Lee el archivo Usuarios.xml si es que existe
        public void LeerArchivo()
        {
            if (System.IO.File.Exists("Libros.xml"))
            {
                ListaDT.ReadXml("Libros.xml");
            }
        }

        // Inserta un nuevo usuario en la lista de usuarios y luego escribe esta lista en el archivo Usuarios.xml
        public void InsertLibro(Libro aLibro)
        {
            ListaDT.Rows.Add(); //agrego renglon vacio
            int NuevoRenglon = ListaDT.Rows.Count - 1;
            ListaDT.Rows[NuevoRenglon]["Nombrelibro"] = aLibro.Nombrelibro;
            ListaDT.Rows[NuevoRenglon]["Autor"] = aLibro.Autor;
            ListaDT.Rows[NuevoRenglon]["Editorial"] = aLibro.Editorial;
            ListaDT.Rows[NuevoRenglon]["Periodo"] = aLibro.Periodo;


            ListaDT.WriteXml("Libros.xml");
        }

    }
}
