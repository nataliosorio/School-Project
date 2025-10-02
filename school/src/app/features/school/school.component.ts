import { Component, OnInit } from '@angular/core';
import { ColegioDto } from '../../core/models/Entitys';
import { GenericTableComponent } from '../../shared/components/generic-table/generic-table.component';
import { MatIconModule } from '@angular/material/icon';
import { MatButtonModule } from '@angular/material/button';

@Component({
  selector: 'app-school',
  standalone: true,
  imports: [GenericTableComponent, MatIconModule, MatButtonModule],
  templateUrl: './school.component.html',
  styleUrl: './school.component.css'
})
export class SchoolComponent implements OnInit {
  columns = [
    { key: 'id', label: 'ID' },
    { key: 'nombre', label: 'Nombre' },
    { key: 'maxEstudiantes', label: 'Máx Estudiantes' },
    { key: 'maxCursos', label: 'Máx Cursos' }
  ];

  colegios: ColegioDto[] = [
    { id: 1, nombre: 'Colegio Nacional', maxEstudiantes: 500, maxCursos: 20 },
    { id: 2, nombre: 'Instituto Moderno', maxEstudiantes: 300, maxCursos: 15 },
    { id: 3, nombre: 'Escuela Distrital', maxEstudiantes: 200, maxCursos: 10 }
  ];

  ngOnInit(): void {}

  add() {
    const nuevo: ColegioDto = {
      id: this.colegios.length + 1,
      nombre: `Nuevo Colegio ${this.colegios.length + 1}`,
      maxEstudiantes: 100,
      maxCursos: 5
    };
    this.colegios = [...this.colegios, nuevo];
  }

  edit(colegio: ColegioDto) {
    alert(`Editar colegio: ${colegio.nombre}`);
  }

  delete(id: number) {
    if (confirm(`¿Seguro que deseas eliminar el colegio con id ${id}?`)) {
      this.colegios = this.colegios.filter(c => c.id !== id);
    }
  }
}
