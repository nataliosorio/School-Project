import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AfterViewInit, EventEmitter, inject, Input, OnChanges, OnInit, Output, ViewChild } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { MatButtonModule } from '@angular/material/button';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatIconModule } from '@angular/material/icon';
import { MatInputModule } from '@angular/material/input';
import { MatPaginator, MatPaginatorModule } from '@angular/material/paginator';
import { MatSortModule } from '@angular/material/sort';
import { MatTableDataSource, MatTableModule } from '@angular/material/table';
import { MatTooltipModule } from '@angular/material/tooltip';
import { General } from '../../../core/services/general.service';
import { FormatDatePipe } from '../../pipes/format-date-pipe';

@Component({
  selector: 'app-generic-table',
    imports: [MatTableModule, MatPaginatorModule, MatSortModule, MatFormFieldModule, MatInputModule, MatButtonModule, MatIconModule, CommonModule, FormsModule, MatTooltipModule, FormatDatePipe],
  templateUrl: './generic-table.component.html',
  styleUrl: './generic-table.component.css'
})
export class GenericTableComponent<T = any> implements OnInit, AfterViewInit, OnChanges {
 @Input() columns: { key: string, label: string }[] = [];
  @Input() data: T[] = [];
  @Input() showActions: boolean = false;

  @Output() create = new EventEmitter<void>();
  @Output() edit = new EventEmitter<T>();
  @Output() delete = new EventEmitter<number>();
  @Output() deletePermanent = new EventEmitter<number>();

  dataSource = new MatTableDataSource<T>();
  displayedColumns: string[] = [];
  userRoles: string[] = [];
  isAdmin: boolean = false;
isUser: boolean = false;
searchText: string = '';


  @ViewChild(MatPaginator) paginator!: MatPaginator;

  constructor(private service: General) {}


  ngOnInit(): void {
    this.displayedColumns = this.columns.map(c => c.key);
    if (this.showActions) this.displayedColumns.push('acciones');

    this.dataSource = new MatTableDataSource(this.data);
  }

  ngAfterViewInit(): void {
    this.dataSource.paginator = this.paginator;
  }

  ngOnChanges(): void {
    this.dataSource = new MatTableDataSource(this.data);
    this.dataSource.paginator = this.paginator;
  }



applyFilter(event: Event) {
  const filterValue = (event.target as HTMLInputElement).value;
  this.searchText = filterValue.trim().toLowerCase();
  this.dataSource.filter = this.searchText;
}

clearFilter() {
  this.searchText = '';
  this.dataSource.filter = '';
}
}
