// colegio.dto.ts
export interface ColegioDto {
  id: number;
  nombre: string;
  maxEstudiantes: number;
  maxCursos: number;
}

// curso.dto.ts
export interface CursoDto {
  id: number;
  nombre: string;

  colegioId: number;
  salonId: number;
  maxEstudiantes: number;

  colegioNombre?: string;
  salonNombre?: string;
}

// estudiante.dto.ts
export interface EstudianteDto {
  id: number;
  nombres: string;
  apellidos: string;
  documento: string;
  cursoId: number;

  cursoNombre?: string;
}

// materia.dto.ts
export interface MateriaDto {
  id: number;
  nombre: string;
}

// asignatura.dto.ts
export interface AsignaturaDto {
  id: number;
  materiaId: number;
  cursoId: number;

  materiaNombre?: string;
  cursoNombre?: string;
}

// periodo.dto.ts
export interface PeriodoDto {
  id: number;
  nombre: string;
  fechaInicio: Date;
  fechaFin: Date;

  porcentaje: number;
}

// nota.dto.ts
export interface NotaDto {
  id: number;
  estudianteId: number;
  asignaturaId: number;
  periodoId: number;
  valor: number;

  estudianteNombre?: string;
  asignaturaNombre?: string;
  periodoNombre?: string;
}

// salon.dto.ts
export interface SalonDto {
  id: number;
  nombre: string;
  capacidad: number;
}
