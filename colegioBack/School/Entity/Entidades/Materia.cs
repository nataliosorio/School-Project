

using Entity.Entidades.Base;

namespace Entity.Entidades
{
    public class Materia: BaseModel
    {
        public string Nombre { get; set; } = null!;

        public ICollection<Asignatura> Asignaturas { get; set; } = new List<Asignatura>();
    }
}
