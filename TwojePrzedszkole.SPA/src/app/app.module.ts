import { CommonModule } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { LanguageTranslationModule } from './shared/modules/language-translation/language-translation.module' 

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { AuthGuard } from './shared';
import { AuthService } from './_services/auth.service';
import { AlertifyService } from './_services/alertify.service';

@NgModule({
   imports: [
      CommonModule,
      BrowserModule,
      BrowserAnimationsModule,
      HttpClientModule,
      LanguageTranslationModule,
      AppRoutingModule
   ],
   declarations: [AppComponent],
   providers: [AuthService, AuthGuard, AlertifyService], // do usuniecia jeden provider autoryzacyjny
   bootstrap: [AppComponent]
})
export class AppModule {}
