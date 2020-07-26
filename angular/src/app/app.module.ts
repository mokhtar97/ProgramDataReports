import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { MatDialogModule } from '@angular/material/dialog';

import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';

import { HttpConfigInterceptor } from './interceptor/httpconfig.interceptor';

import { ErrorDialogComponent } from './error dialog/error-dialog/error-dialog.component';

import { ErrorDialogService } from './error dialog/error-dialog.service';

import { LoginService } from './services/login.service';

import { ProductService } from './ProductServices/product.service';
import { Product } from './shared/product';
import { AgGridModule } from 'ag-grid-angular';
import { ProductsComponent } from './product/products/products.component';

@NgModule({
  declarations: [
    AppComponent,
    ProductsComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MatDialogModule,
    HttpClientModule,
    AgGridModule.withComponents([])
  ],
  providers: [ { provide: HTTP_INTERCEPTORS, useClass: HttpConfigInterceptor, multi: true },
     ErrorDialogService, LoginService, ProductService, Product],
  entryComponents: [ErrorDialogComponent],
  bootstrap: [AppComponent]
})
export class AppModule { }
