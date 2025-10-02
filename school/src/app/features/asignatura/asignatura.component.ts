import { Component, OnInit } from '@angular/core';
import { GenericTableComponent } from '../../shared/components/generic-table/generic-table.component';
import { MatIconModule } from '@angular/material/icon';
import { MatButtonModule } from '@angular/material/button';
import { AsignaturaDto } from '../../core/models/Entitys';

@Component({
  selector: 'app-asignatura',
  imports: [GenericTableComponent, MatIconModule, MatButtonModule],
  templateUrl: './asignatura.component.html',
  styleUrl: './asignatura.component.css'
})
export class AsignaturaComponent implements OnInit {
 columns = [
    { key: 'id', label: 'ID' },
    { key: 'materiaNombre', label: 'Materia' },
    { key: 'cursoNombre', label: 'Curso' }
  ];

  asignaturas: AsignaturaDto[] = [
    { id: 1, materiaId: 1, cursoId: 1, materiaNombre: 'Matemáticas', cursoNombre: 'Matemáticas 101' },
    { id: 2, materiaId: 2, cursoId: 2, materiaNombre: 'Historia', cursoNombre: 'Historia Universal' },
    { id: 3, materiaId: 3, cursoId: 1, materiaNombre: 'Lengua y Literatura', cursoNombre: 'Matemáticas 101' }
  ];

  ngOnInit(): void {}

  add() {
    const nuevo: AsignaturaDto = {
      id: this.asignaturas.length + 1,
      materiaId: 1,
      cursoId: 1,
      materiaNombre: 'Materia Demo',
      cursoNombre: 'Curso Demo'
    };
    this.asignaturas = [...this.asignaturas, nuevo];
  }

  edit(asignatura: AsignaturaDto) {
    alert(`Editar asignatura: ${asignatura.materiaNombre} en ${asignatura.cursoNombre}`);
  }

  delete(id: number) {
    if (confirm(`¿Seguro que deseas eliminar la asignatura con id ${id}?`)) {
      this.asignaturas = this.asignaturas.filter(a => a.id !== id);
    }
  }
}
