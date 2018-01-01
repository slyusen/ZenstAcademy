import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { CoursesComponent } from './courses.component';
import { RegisterComponent } from './register/register.component';

const routes: Routes = [{
    path: '',
    component: CoursesComponent,
    children: [{
      path: 'register',
      component: RegisterComponent,
    },
  ]
  }];
  

export const routing = RouterModule.forChild(routes);