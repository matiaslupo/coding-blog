import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CategoriesListComponent, AddCategoryComponent } from './pages/';

const routes: Routes = [
  {
    path:'',
    component: CategoriesListComponent
  },
  {
    path:'/add',
    component: AddCategoryComponent
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class CategoriesRoutingModule { }
