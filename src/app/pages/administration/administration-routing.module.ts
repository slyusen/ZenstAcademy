import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { AdministrationComponent } from './administration.component';
import { StudentsComponent } from './students/students.component';
import { EmployeesComponent } from './employees/employees.component';
import { CoursesComponent } from './courses/courses.component';
import { ModalsComponent } from './modals/modals.component';
import { TypographyComponent } from './typography/typography.component';
import { TabsComponent, Tab1Component, Tab2Component } from './tabs/tabs.component';
import { SearchComponent } from './search-fields/search-fields.component';

const routes: Routes = [{
  path: '',
  component: AdministrationComponent,
  children: [{
    path: 'students',
    component: StudentsComponent,
  }, {
    path: 'employees',
    component: EmployeesComponent,
  }, {
    path: 'courses',
    component: CoursesComponent,
  }, {
    path: 'modals',
    component: ModalsComponent,
  }, {
    path: 'typography',
    component: TypographyComponent,
  }, {
    path: 'search-fields',
    component: SearchComponent,
  }, {
    path: 'tabs',
    component: TabsComponent,
    children: [{
      path: '',
      redirectTo: 'tab1',
      pathMatch: 'full',
    }, {
      path: 'tab1',
      component: Tab1Component,
    }, {
      path: 'tab2',
      component: Tab2Component,
    }],
  }],
}];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class AdministrationRoutingModule { }
