import { NgModule } from '@angular/core';
import { SharedModule } from '../shared/shared.module';
import { BookService } from './services/book.service';
import { BookListComponent } from './components/book-list/book-list.component';
import { BookFormComponent } from './components/book-form/book-form.component';



@NgModule({
    imports: [
        SharedModule
    ],
    exports: [
        BookListComponent
    ],
    declarations: [BookListComponent, BookFormComponent],
    providers: [
        BookService
    ],
})
export class BookModule { }
