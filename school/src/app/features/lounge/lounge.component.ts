import { Component } from '@angular/core';
import { GenericTableComponent } from '../../shared/components/generic-table/generic-table.component';
import { MatIconModule } from '@angular/material/icon';
import { MatButtonModule } from '@angular/material/button';
import { SalonDto } from '../../core/models/Entitys';

@Component({
  selector: 'app-lounge',
  imports:  [GenericTableComponent, MatIconModule, MatButtonModule],
  templateUrl: './lounge.component.html',
  styleUrl: './lounge.component.css'
})
export class LoungeComponent {
columns = [
    { key: 'id', label: 'ID' },
    { key: 'nombre', label: 'Nombre' },
    { key: 'capacidad', label: 'Capacidad' }
  ];

  salones: SalonDto[] = [
    { id: 1, nombre: 'Aula 101', capacidad: 40 },
    { id: 2, nombre: 'Aula 202', capacidad: 35 },
    { id: 3, nombre: 'Laboratorio 1', capacidad: 25 },
    { id: 4, nombre: 'Auditorio', capacidad: 100 }
  ];

  ngOnInit(): void {}

  add() {
    const nuevo: SalonDto = {
      id: this.salones.length + 1,
      nombre: `Nuevo Salón ${this.salones.length + 1}`,
      capacidad: 30
    };
    this.salones = [...this.salones, nuevo];
  }

  edit(salon: SalonDto) {
    alert(`Editar salón: ${salon.nombre}`);
  }

  delete(id: number) {
    if (confirm(`¿Seguro que deseas eliminar el salón con id ${id}?`)) {
      this.salones = this.salones.filter(s => s.id !== id);
    }
  }
}
