import { NgModule }      from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
// Import HttpClientModule from @angular/common/http
import { HttpModule } from '@angular/http';
import { UserService } from "./user.service";

@NgModule({
    imports: [BrowserModule,
            // Include it under 'imports' in your application module
            // after BrowserModule.
        HttpModule],
  declarations: [ AppComponent ],
  bootstrap: [AppComponent],
  providers: [UserService]
})
export class AppModule { }
