using AutoMapper;
using Entity.Entidades;
using Entity.Dtos;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        // 🔹 Colegio
        CreateMap<Colegio, ColegioDto>();
        CreateMap<ColegioDto, Colegio>();

        // 🔹 Curso
        CreateMap<Curso, CursoDto>()
            .ForMember(dest => dest.ColegioNombre,
                opt => opt.MapFrom(src => src.Colegio.Nombre))
            .ForMember(dest => dest.SalonNombre,
                opt => opt.MapFrom(src => src.Salon.Nombre));
        CreateMap<CursoDto, Curso>();

        // 🔹 Estudiante
        CreateMap<Estudiante, EstudianteDto>()
            .ForMember(dest => dest.CursoNombre,
                opt => opt.MapFrom(src => src.Curso.Nombre));
        CreateMap<EstudianteDto, Estudiante>();

        // 🔹 Asignatura
        CreateMap<Asignatura, AsignaturaDto>()
            .ForMember(dest => dest.MateriaNombre,
                opt => opt.MapFrom(src => src.Materia.Nombre))
            .ForMember(dest => dest.CursoNombre,
                opt => opt.MapFrom(src => src.Curso.Nombre));
        CreateMap<AsignaturaDto, Asignatura>();

        // 🔹 Materia
        CreateMap<Materia, MateriaDto>();
        CreateMap<MateriaDto, Materia>();

        // 🔹 Nota
        CreateMap<Nota, NotaDto>()
            .ForMember(dest => dest.EstudianteNombre,
                opt => opt.MapFrom(src => src.Estudiante.Nombres + " " + src.Estudiante.Apellidos))
            .ForMember(dest => dest.AsignaturaNombre,
                opt => opt.MapFrom(src => src.Asignatura.Materia.Nombre)) // desde Materia
            .ForMember(dest => dest.PeriodoNombre,
                opt => opt.MapFrom(src => src.Periodo.Nombre));
        CreateMap<NotaDto, Nota>();

        // 🔹 Periodo
        CreateMap<Periodo, PeriodoDto>();
        CreateMap<PeriodoDto, Periodo>();

        // 🔹 Salon
        CreateMap<Salon, SalonDto>();
        CreateMap<SalonDto, Salon>();
    }
}
