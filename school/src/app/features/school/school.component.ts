import { Component, OnInit } from '@angular/core';
import { ColegioDto } from '../../core/models/Entitys';
import { GenericTableComponent } from '../../shared/components/generic-table/generic-table.component';
import { MatIconModule } from '@angular/material/icon';
import { MatButtonModule } from '@angular/material/button';
import { General } from '../../core/services/general.service';  // Importamos el servicio
import { MatSnackBar } from '@angular/material/snack-bar';  // Importamos MatSnackBar
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';

@Component({
  selector: 'app-school',
  standalone: true,
  imports: [GenericTableComponent, MatIconModule, MatButtonModule, CommonModule, MatFormFieldModule, MatInputModule, FormsModule],
  templateUrl: './school.component.html',
  styleUrl: './school.component.css'
})
export class SchoolComponent implements OnInit {
  columns = [
    { key: 'nombre', label: 'Nombre' },
    { key: 'maxEstudiantes', label: 'Máx Estudiantes' },
    { key: 'maxCursos', label: 'Máx Cursos' }
  ];

  colegios: ColegioDto[] = [];
  showForm = false;
  newColegio: ColegioDto = { id: 0, nombre: '', maxEstudiantes: 0, maxCursos: 0 };
  editMode = false;

  constructor(private generalService: General, private snackBar: MatSnackBar) {}

  ngOnInit(): void {
    this.loadColegios();
  }

  // Método para cargar los colegios desde el backend
  loadColegios() {
    this.generalService.get<ColegioDto[]>('Colegio')
      .subscribe(
        (data) => {
          this.colegios = data;
        },
        (error) => {
          this.openSnackBar('Error al cargar los colegios: ' + error.message, 'Cerrar');
        }
      );
  }

  // Método para agregar un nuevo colegio
  add() {
    this.showForm = true;  // Muestra el formulario
    this.editMode = false;  // Aseguramos que no estamos en modo edición
    this.newColegio = { id: 0, nombre: '', maxEstudiantes: 0, maxCursos: 0 };  // Reinicia el objeto
  }

  // Método para editar un colegio
  edit(colegio: ColegioDto) {
    this.showForm = true;  // Muestra el formulario
    this.editMode = true;  // Activamos el modo edición
    this.newColegio = { ...colegio };  // Copiamos los datos del colegio a newColegio
  }

  // Método para guardar un nuevo colegio o actualizarlo
saveColegio() {
  if (this.editMode) {

    this.generalService.put<ColegioDto>('Colegio', this.newColegio).subscribe(
      (data) => {
        this.openSnackBar('Colegio actualizado correctamente ✅', 'Cerrar');
        this.showForm = false;  // Ocultamos el formulario
        this.newColegio = { id: 0, nombre: '', maxEstudiantes: 0, maxCursos: 0 }; // Reiniciar formulario
        this.loadColegios();  // 🔁 Recargamos la lista actualizada desde el backend
      },
      (error) => {
        this.openSnackBar('Error al actualizar el colegio: ' + error.message, 'Cerrar');
      }
    );

  } else {
    // 🔹 Crear nuevo colegio (POST)
    this.generalService.post<ColegioDto>('Colegio', this.newColegio).subscribe(
      (data) => {
        this.openSnackBar('Colegio guardado correctamente 🎉', 'Cerrar');
        this.showForm = false;  // Ocultamos el formulario
        this.newColegio = { id: 0, nombre: '', maxEstudiantes: 0, maxCursos: 0 }; // Reiniciar formulario
        this.loadColegios();  // 🔁 Recargamos la lista actualizada desde el backend
      },
      (error) => {
        this.openSnackBar('Error al guardar el colegio: ' + error.message, 'Cerrar');
      }
    );
  }
}


  // Método para cancelar y ocultar el formulario
  cancel() {
    this.showForm = false; // Evita el envío del formulario
  }

  // Método para mostrar el snack bar con el mensaje
  openSnackBar(message: string, action: string): void {
    this.snackBar.open(message, action, {
      duration: 5000,  // Duración de la alerta en milisegundos
    });
  }

  delete(id: number) {
    // Alerta de confirmación antes de eliminar
    if (confirm(`¿Seguro que deseas eliminar este colegio?`)) {
      // Llamada al backend para eliminar el colegio
      this.generalService.delete('Colegio', id).subscribe(
        () => {
          // Si la eliminación es exitosa, eliminamos el colegio de la lista en el frontend
          this.colegios = this.colegios.filter(c => c.id !== id);
          this.openSnackBar('Colegio eliminado correctamente', 'Cerrar');
          this.loadColegios();  // Recargamos la lista de colegios
        },
        (error) => {
          this.openSnackBar('Error al eliminar el colegio: ' + error.message, 'Cerrar');
        }
      );
    }
  }
}
