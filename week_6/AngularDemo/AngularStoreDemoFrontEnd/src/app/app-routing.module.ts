import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { RegisterCustomerComponent } from './register-customer/register-customer.component';
import { LoginCustomerComponent } from './login-customer/login-customer.component';
import { FormExamplesComponent } from './form-examples/form-examples.component';

const routes: Routes = [
  { path: '', redirectTo: '/', pathMatch: 'full' }, // this redirects to the landing page
  { path: 'register', component: RegisterCustomerComponent},
  { path: 'login', component: LoginCustomerComponent},
  { path: 'form-examples', component: FormExamplesComponent}
]

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
