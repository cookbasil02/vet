using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
namespace Vet.Shared.Entities
{
    public class Producto
    {
            //atributos de la entidad
            public int Id { get; set; } //codigo de servicio pk

            //name
            [Display(Name = "Producto")]
            [MaxLength(100, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
            [Required(ErrorMessage = "El campo {0} es obligatorio.")]
            public string Name { get; set; } = null!;

            //tipo
            [Display(Name = "tipo")]
            [MaxLength(100, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
            [Required(ErrorMessage = "El campo {0} es obligatorio.")]
            public string tipo { get; set; } = null!;
     
             //peso
             [Display(Name = "Cantidad")]
             [Required(ErrorMessage = "El campo {0} es obligatorio.")]

               public int Cantidad { get; set; } = 0;

        //detalle
        [Display(Name = "Detalle")]
            [MaxLength(100, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
            [Required(ErrorMessage = "El campo {0} es obligatorio.")]
            public string Detalle { get; set; } = null!;




    }
}
