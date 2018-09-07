import { NgModule } from '@angular/core';
import { SharedModule } from '../shared/shared.module';
import { BookService } from './services/book.service';
import { BookListComponent } from './components/book-list/book-list.component';



@NgModule({
    imports: [
        SharedModule
    ],
    exports: [
        BookListComponent
    ],
    declarations: [BookListComponent],
    providers: [
        BookService
    ],
})
export class BookModule { }
