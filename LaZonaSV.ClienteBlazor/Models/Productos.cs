using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LaZonaSV.ClienteBlazor.Models
{
    public class Productos
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El producto es obligatorio")]
        public string Producto { get; set; }
        [Required(ErrorMessage = "La descripción es obligatoria es obligatorio")]
        public string Detalles { get; set; }
        [Required(ErrorMessage = "El precio es obligatorio")]
        public decimal Precio { get; set; }
        [Required(ErrorMessage = "La imagen es obligatorio")]
        public string Imagen { get; set; }

    }
}
