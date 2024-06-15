using System.ComponentModel.DataAnnotations;

namespace Practica3.Models
{
    public class Inventario
    {
        [Key]
        public int IDInventario { get; set; }

        public int FKIDLibro { get; set; }

        public int FKIDSucursal { get; set; }

        public int Existencia { get; set; }
    }
}
