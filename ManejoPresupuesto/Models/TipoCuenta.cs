using ManejoPresupuesto.Validaciones;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ManejoPresupuesto.Models
{
    public class TipoCuenta
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")] //hace obligatorio el campo nombre
        [StringLength(maximumLength: 50, MinimumLength = 3, ErrorMessage = "La longitud del campo {0} debe estar entre {2} y {1}")] //maximo 50 caracteres y minimo 3
        [PrimeraLetraMayuscula]
        [Remote(action: "VerificarExisteTipoCuenta", controller: "TiposCuentas", 
            AdditionalFields = nameof(Id))]
        public string Nombre { get; set; }
        public int UsuarioId { get; set; }
        public int Orden { get; set; }

        /*
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Nombre != null && Nombre.Length > 0)
            {
                var primeraLetra = Nombre[0].ToString();

                if (primeraLetra != primeraLetra.ToUpper())
                {
                    yield return new ValidationResult("La primera letra debe ser mayúscula",
                        new[] { nameof(Nombre) }); //devuelve el error y nameof indica que el error es del campo nombre
                }
            }
        }
        */
    }
}
