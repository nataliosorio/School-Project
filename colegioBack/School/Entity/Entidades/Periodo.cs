
using Entity.Entidades.Base;

namespace Entity.Entidades;

public class Periodo : BaseModel
{
    public string Nombre { get; set; } = null!;
    public DateTime FechaInicio { get; set; }
    public DateTime FechaFin { get; set; }

    // 🔹 Nuevo campo: porcentaje que representa dentro de la nota final
    public decimal Porcentaje { get; set; }

    public ICollection<Nota> Notas { get; set; } = new List<Nota>();
}
