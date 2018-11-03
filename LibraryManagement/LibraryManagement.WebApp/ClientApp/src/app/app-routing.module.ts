import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { BookListComponent } from './book/components/book-list/book-list.component';

const routes: Routes = [
    {path : 'books',component : BookListComponent},
    {path : '',redirectTo:'/books',pathMatch:'full'},
    {path : '**',redirectTo:'/books',pathMatch:'full'}
]

@NgModule({
    imports: [
        RouterModule.forRoot(routes)],
    exports: [
        RouterModule
    ],
    declarations: [],
})
export class AppRoutingModule { }