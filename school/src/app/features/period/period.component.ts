import { Component, OnInit } from '@angular/core';
import { GenericTableComponent } from '../../shared/components/generic-table/generic-table.component';
import { MatIconModule } from '@angular/material/icon';
import { MatButtonModule } from '@angular/material/button';
import { PeriodoDto } from '../../core/models/Entitys';

@Component({
  selector: 'app-period',
  imports: [GenericTableComponent, MatIconModule, MatButtonModule],
  templateUrl: './period.component.html',
  styleUrl: './period.component.css'
})
export class PeriodComponent implements OnInit {
columns = [
    { key: 'id', label: 'ID' },
    { key: 'nombre', label: 'Nombre' },
    { key: 'fechaInicio', label: 'Fecha Inicio' },
    { key: 'fechaFin', label: 'Fecha Fin' },
    { key: 'porcentaje', label: 'Porcentaje (%)' }
  ];

  periodos: PeriodoDto[] = [
    { id: 1, nombre: 'Primer Periodo', fechaInicio: new Date(2025, 0, 15), fechaFin: new Date(2025, 3, 15), porcentaje: 25 },
    { id: 2, nombre: 'Segundo Periodo', fechaInicio: new Date(2025, 3, 16), fechaFin: new Date(2025, 6, 15), porcentaje: 25 },
    { id: 3, nombre: 'Tercer Periodo', fechaInicio: new Date(2025, 6, 16), fechaFin: new Date(2025, 9, 15), porcentaje: 25 },
    { id: 4, nombre: 'Cuarto Periodo', fechaInicio: new Date(2025, 9, 16), fechaFin: new Date(2025, 11, 20), porcentaje: 25 }
  ];

  ngOnInit(): void {}

  add() {
    const nuevo: PeriodoDto = {
      id: this.periodos.length + 1,
      nombre: `Nuevo Periodo ${this.periodos.length + 1}`,
      fechaInicio: new Date(),
      fechaFin: new Date(new Date().setMonth(new Date().getMonth() + 3)),
      porcentaje: 20
    };
    this.periodos = [...this.periodos, nuevo];
  }

  edit(periodo: PeriodoDto) {
    alert(`Editar periodo: ${periodo.nombre}`);
  }

  delete(id: number) {
    if (confirm(`¿Seguro que deseas eliminar el periodo con id ${id}?`)) {
      this.periodos = this.periodos.filter(p => p.id !== id);
    }
  }
}
