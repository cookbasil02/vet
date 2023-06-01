using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Vet.Shared.Entities
{
    public class Mascota
    {

        //atributos de la entidad
        public int Id { get; set; } //id mascota pk

        //nombre de la mascota
        [Display(Name = "Mascota")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Name { get; set; } = null!;

        //raza
        [Display(Name = "Raza")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Raza { get; set; } = null!;

        //especie
        [Display(Name = "Especie")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Especie { get; set; } = null!;

        //sexo
        [Display(Name = "Sexo")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Sexo { get; set; } = null!;

        //fecha de nacimiento
        [Display(Name = "Fecha de Nacimiento")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]

        public string FechaNacimiento { get; set; } = null!;

        //Color
        [Display(Name = "Color")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]

        public string Color { get; set; } = null!;

        //peso
        [Display(Name = "Peso")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]

        public int Peso { get; set; } = 0;

        ////Tratamiento
        [Display(Name = "Tratamiento")]
        [MaxLength(500, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]

        public string Tratamiento { get; set; } = null!;

        //Antecedentes
        [Display(Name = "Antecedentes")]
        [MaxLength(500, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]

        public string TAntecedentes { get; set; } = null!;

    }
}
