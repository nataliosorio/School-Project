import { Component, OnInit } from '@angular/core';
import { GenericTableComponent } from '../../shared/components/generic-table/generic-table.component';
import { MatButtonModule } from '@angular/material/button';
import { MatIconModule } from '@angular/material/icon';
import { EstudianteDto } from '../../core/models/Entitys';

@Component({
  selector: 'app-students',
  imports: [GenericTableComponent, MatIconModule, MatButtonModule],
  templateUrl: './students.component.html',
  styleUrl: './students.component.css'
})
export class StudentsComponent implements OnInit {
columns = [
    { key: 'id', label: 'ID' },
    { key: 'nombres', label: 'Nombres' },
    { key: 'apellidos', label: 'Apellidos' },
    { key: 'documento', label: 'Documento' },
    { key: 'cursoNombre', label: 'Curso' }
  ];

  estudiantes: EstudianteDto[] = [
    { id: 1, nombres: 'Juan', apellidos: 'Pérez', documento: '123456789', cursoId: 1, cursoNombre: 'Matemáticas 101' },
    { id: 2, nombres: 'María', apellidos: 'Gómez', documento: '987654321', cursoId: 2, cursoNombre: 'Historia Universal' },
    { id: 3, nombres: 'Carlos', apellidos: 'Rodríguez', documento: '456789123', cursoId: 1, cursoNombre: 'Matemáticas 101' }
  ];

  ngOnInit(): void {}

  add() {
    const nuevo: EstudianteDto = {
      id: this.estudiantes.length + 1,
      nombres: 'Nuevo',
      apellidos: `Estudiante ${this.estudiantes.length + 1}`,
      documento: `${100000000 + this.estudiantes.length}`,
      cursoId: 1,
      cursoNombre: 'Matemáticas 101'
    };
    this.estudiantes = [...this.estudiantes, nuevo];
  }

  edit(estudiante: EstudianteDto) {
    alert(`Editar estudiante: ${estudiante.nombres} ${estudiante.apellidos}`);
  }

  delete(id: number) {
    if (confirm(`¿Seguro que deseas eliminar el estudiante con id ${id}?`)) {
      this.estudiantes = this.estudiantes.filter(e => e.id !== id);
    }
  }
}
