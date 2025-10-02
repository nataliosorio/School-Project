import { Component, OnInit } from '@angular/core';
import { GenericTableComponent } from '../../shared/components/generic-table/generic-table.component';
import { MatIconModule } from '@angular/material/icon';
import { MatButtonModule } from '@angular/material/button';
import { MateriaDto } from '../../core/models/Entitys';

@Component({
  selector: 'app-subject',
  imports:  [GenericTableComponent, MatIconModule, MatButtonModule],
  templateUrl: './subject.component.html',
  styleUrl: './subject.component.css'
})
export class SubjectComponent implements OnInit {
columns = [
    { key: 'id', label: 'ID' },
    { key: 'nombre', label: 'Nombre' }
  ];

  materias: MateriaDto[] = [
    { id: 1, nombre: 'Matemáticas' },
    { id: 2, nombre: 'Historia' },
    { id: 3, nombre: 'Lengua y Literatura' },
    { id: 4, nombre: 'Ciencias Naturales' }
  ];

  ngOnInit(): void {}

  add() {
    const nuevo: MateriaDto = {
      id: this.materias.length + 1,
      nombre: `Nueva Materia ${this.materias.length + 1}`
    };
    this.materias = [...this.materias, nuevo];
  }

  edit(materia: MateriaDto) {
    alert(`Editar materia: ${materia.nombre}`);
  }

  delete(id: number) {
    if (confirm(`¿Seguro que deseas eliminar la materia con id ${id}?`)) {
      this.materias = this.materias.filter(m => m.id !== id);
    }
  }
}
