using Microsoft.AspNetCore.Mvc.Rendering;

namespace ManejoPresupuesto.Models
{
    public class CuentaCreacionViewModel: Cuenta
    {
        public IEnumerable<SelectListItem> TiposCuentas { get; set; } //clase especial que permite hacer select de manera sencilla
    }
}
