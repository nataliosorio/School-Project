import { Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { WelcomeComponent } from './welcome/welcome.component';
import { SchoolComponent } from './features/school/school.component';
import { CourseComponent } from './features/course/course.component';
import { StudentsComponent } from './features/students/students.component';
import { SubjectComponent } from './features/subject/subject.component';
import { AsignaturaComponent } from './features/asignatura/asignatura.component';
import { LoungeComponent } from './features/lounge/lounge.component';
import { PeriodComponent } from './features/period/period.component';
import { NoteComponent } from './features/note/note.component';

export const routes: Routes = [
 { path: '', redirectTo: 'welcome', pathMatch: 'full' },
 { path: 'welcome', component: WelcomeComponent },
  { path: 'home', component: HomeComponent },
  { path: 'colegios', component: SchoolComponent },
  { path: 'cursos', component: CourseComponent },
  { path: 'estudiantes', component: StudentsComponent },
  { path: 'materias', component: SubjectComponent },
  { path: 'asignaturas', component: AsignaturaComponent },
  { path: 'salones', component: LoungeComponent },
  { path: 'periodos', component: PeriodComponent },
  { path: 'notas', component: NoteComponent },
  { path: '**', redirectTo: 'home' }
];
