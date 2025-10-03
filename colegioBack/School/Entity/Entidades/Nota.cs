

using Entity.Entidades;
using Entity.Entidades.Base;

public class Nota : BaseModel
{
    public int EstudianteId { get; set; }
    public Estudiante Estudiante { get; set; }

    public int AsignaturaId { get; set; }
    public Asignatura Asignatura { get; set; }

    public int PeriodoId { get; set; }
    public Periodo Periodo { get; set; }

    public decimal Valor { get; set; }
}
