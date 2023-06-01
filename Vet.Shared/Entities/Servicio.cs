using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Vet.Shared.Entities
{
    public class Servicio
    {
            //atributos de la entidad
            public int Id { get; set; } //codigo de servicio pk

            //name
            [Display(Name = "Servicio")]
            [MaxLength(100, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
            [Required(ErrorMessage = "El campo {0} es obligatorio.")]
            public string Name { get; set; } = null!;

            //Motivo
            [Display(Name = "Motivo")]
            [MaxLength(100, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
            [Required(ErrorMessage = "El campo {0} es obligatorio.")]
            public string Motivo { get; set; } = null!;

            //Motivo
            [Display(Name = "Detalle")]
            [MaxLength(100, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
            [Required(ErrorMessage = "El campo {0} es obligatorio.")]
            public string Detalle { get; set; } = null!;




    }
}
