import { Component, OnInit } from '@angular/core';
import { GenericTableComponent } from '../../shared/components/generic-table/generic-table.component';
import { MatButtonModule } from '@angular/material/button';
import { MatIconModule } from '@angular/material/icon';
import { CursoDto } from '../../core/models/Entitys';

@Component({
  selector: 'app-course',
  imports: [GenericTableComponent, MatIconModule, MatButtonModule],
  templateUrl: './course.component.html',
  styleUrl: './course.component.css'
})
export class CourseComponent implements OnInit {
columns = [
    { key: 'id', label: 'ID' },
    { key: 'nombre', label: 'Nombre' },
    { key: 'maxEstudiantes', label: 'Máx Estudiantes' },
    { key: 'colegioNombre', label: 'Colegio' },
    { key: 'salonNombre', label: 'Salón' }
  ];

  cursos: CursoDto[] = [
    { id: 1, nombre: 'Matemáticas 101', maxEstudiantes: 40, colegioId: 1, salonId: 1, colegioNombre: 'Colegio Nacional', salonNombre: 'Aula 101' },
    { id: 2, nombre: 'Historia Universal', maxEstudiantes: 35, colegioId: 2, salonId: 2, colegioNombre: 'Instituto Moderno', salonNombre: 'Aula 202' },
    { id: 3, nombre: 'Lengua y Literatura', maxEstudiantes: 30, colegioId: 1, salonId: 3, colegioNombre: 'Colegio Nacional', salonNombre: 'Aula 103' }
  ];

  ngOnInit(): void {}

  add() {
    const nuevo: CursoDto = {
      id: this.cursos.length + 1,
      nombre: `Nuevo Curso ${this.cursos.length + 1}`,
      maxEstudiantes: 25,
      colegioId: 1,
      salonId: 1,
      colegioNombre: 'Colegio Nacional',
      salonNombre: 'Aula Demo'
    };
    this.cursos = [...this.cursos, nuevo];
  }

  edit(curso: CursoDto) {
    alert(`Editar curso: ${curso.nombre}`);
  }

  delete(id: number) {
    if (confirm(`¿Seguro que deseas eliminar el curso con id ${id}?`)) {
      this.cursos = this.cursos.filter(c => c.id !== id);
    }
  }
}
