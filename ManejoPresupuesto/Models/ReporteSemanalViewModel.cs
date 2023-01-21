namespace ManejoPresupuesto.Models
{
    public class ReporteSemanalViewModel
    {
        public decimal Ingresos => TransaccionesPorSemana.Sum(x => x.Ingresos); //suma de los ingresos
        public decimal Gastos => TransaccionesPorSemana.Sum(x => x.Gastos); //suma de gastos
        public decimal Total => Ingresos - Gastos; //total es igual a ingresos menos gastos
        public DateTime FechaReferencia { get; set; }
        public IEnumerable<ResultadoObtenerPorSemana> TransaccionesPorSemana { get; set; }
    }
}
