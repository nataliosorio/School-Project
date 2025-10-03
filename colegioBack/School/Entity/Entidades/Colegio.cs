

using Entity.Entidades.Base;

namespace Entity.Entidades;

public class Colegio : BaseModel
{
    public string Nombre { get; set; } = null!;
    public int MaxEstudiantes { get; set; }
    public int MaxCursos { get; set; }

    // Relaciones
    public ICollection<Curso> Cursos { get; set; } = new List<Curso>();
}
