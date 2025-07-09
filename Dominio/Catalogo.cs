using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dominio
{
     public class Catalogo
    {
        public int Id { get; set; }
        public string Codigo  { get; set; }
        public  string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string  ImagenUrl { get; set; }
        
        public Categorias Inventario  { get; set; }
        public Marcas Firmas { get; set; }
        public decimal Precio { get; set; }

    }
}
