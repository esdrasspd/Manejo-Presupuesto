using System.ComponentModel.DataAnnotations;

namespace ManejoPresupuesto.Validaciones
{
    public class PrimeraLetraMayusculaAttribute: ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if(value == null || string.IsNullOrEmpty(value.ToString())) //verifica si la primera letra es mayuscula
            {
                return ValidationResult.Success; //validacion exitosa
            }

            var primeraLetra = value.ToString()[0].ToString(); //primera letra

            if(primeraLetra != primeraLetra.ToUpper())
            {
                return new ValidationResult("La primera letra debe ser mayúscula");
            }    

            return ValidationResult.Success; //la letra es mayúscula y es exitosa la validación
        }
    }
}
