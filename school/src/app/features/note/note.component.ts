import { Component, OnInit } from '@angular/core';
import { GenericTableComponent } from '../../shared/components/generic-table/generic-table.component';
import { MatIconModule } from '@angular/material/icon';
import { MatButtonModule } from '@angular/material/button';
import { NotaDto } from '../../core/models/Entitys';

@Component({
  selector: 'app-note',
  imports: [GenericTableComponent, MatIconModule, MatButtonModule],
  templateUrl: './note.component.html',
  styleUrl: './note.component.css'
})
export class NoteComponent implements OnInit {
 columns = [
    { key: 'id', label: 'ID' },
    { key: 'estudianteNombre', label: 'Estudiante' },
    { key: 'asignaturaNombre', label: 'Asignatura' },
    { key: 'periodoNombre', label: 'Periodo' },
    { key: 'valor', label: 'Nota' }
  ];

  notas: NotaDto[] = [
    { id: 1, estudianteId: 1, asignaturaId: 1, periodoId: 1, valor: 4.5, estudianteNombre: 'Juan Pérez', asignaturaNombre: 'Matemáticas', periodoNombre: 'Primer Periodo' },
    { id: 2, estudianteId: 2, asignaturaId: 2, periodoId: 1, valor: 3.8, estudianteNombre: 'María Gómez', asignaturaNombre: 'Historia', periodoNombre: 'Primer Periodo' },
    { id: 3, estudianteId: 1, asignaturaId: 3, periodoId: 2, valor: 4.0, estudianteNombre: 'Juan Pérez', asignaturaNombre: 'Lengua y Literatura', periodoNombre: 'Segundo Periodo' }
  ];

  ngOnInit(): void {}

  add() {
    const nuevo: NotaDto = {
      id: this.notas.length + 1,
      estudianteId: 1,
      asignaturaId: 1,
      periodoId: 1,
      valor: 5.0,
      estudianteNombre: 'Estudiante Demo',
      asignaturaNombre: 'Asignatura Demo',
      periodoNombre: 'Periodo Demo'
    };
    this.notas = [...this.notas, nuevo];
  }

  edit(nota: NotaDto) {
    alert(`Editar nota de ${nota.estudianteNombre} en ${nota.asignaturaNombre}: ${nota.valor}`);
  }

  delete(id: number) {
    if (confirm(`¿Seguro que deseas eliminar la nota con id ${id}?`)) {
      this.notas = this.notas.filter(n => n.id !== id);
    }
  }
}
