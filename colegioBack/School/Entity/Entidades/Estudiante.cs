
using Entity.Entidades.Base;

namespace Entity.Entidades;

public class Estudiante : BaseModel
{
    public string Nombres { get; set; } = null!;
    public string Apellidos { get; set; } = null!;
    public string Documento { get; set; } = null!;

    public int CursoId { get; set; }
    public Curso Curso { get; set; } = null!;

    public ICollection<Nota> Notas { get; set; } = new List<Nota>();
}
