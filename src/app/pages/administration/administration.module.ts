import { NgModule } from '@angular/core';

import { ThemeModule } from '../../@theme/theme.module';
import { StudentsModule } from './students/students.module';
import { AdministrationRoutingModule } from './administration-routing.module';
import { AdministrationComponent } from './administration.component';
import { EmployeesComponent } from './employees/employees.component';
import { ModalsComponent } from './modals/modals.component';
import { CoursesComponent } from './courses/courses.component';
import { ModalComponent } from './modals/modal/modal.component';
import { TypographyComponent } from './typography/typography.component';
import { TabsComponent, Tab1Component, Tab2Component } from './tabs/tabs.component';
import { SearchComponent } from './search-fields/search-fields.component';

const components = [
  AdministrationComponent,
  EmployeesComponent,
  ModalsComponent,
  CoursesComponent,
  ModalComponent,
  TypographyComponent,
  TabsComponent,
  Tab1Component,
  Tab2Component,
  SearchComponent,
];

@NgModule({
  imports: [
    ThemeModule,
    AdministrationRoutingModule,
    StudentsModule,
  ],
  declarations: [
    ...components,
  ],
  entryComponents: [
    ModalComponent,
  ],
})
export class AdministrationModule { }
