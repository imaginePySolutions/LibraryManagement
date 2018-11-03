import { NgModule } from '@angular/core';
import { AngularMaterialModule } from './angular-material/angular-material.module';
import { NavbarComponent } from './navbar/navbar.component';
import { AppRoutingModule } from '../app-routing.module';



@NgModule({
    imports: [
        AngularMaterialModule,
        AppRoutingModule
    ],
    exports: [
        AngularMaterialModule,
        NavbarComponent
    ],
    declarations: [NavbarComponent],
    providers: [],
})
export class SharedModule { }
