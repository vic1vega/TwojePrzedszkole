import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { routerTransition } from '../router.animations';
import { AuthService } from '../_services/auth.service';
import { AlertifyService } from '../_services/alertify.service';

@Component({
    selector: 'app-signup',
    templateUrl: './signup.component.html',
    styleUrls: ['./signup.component.scss'],
    animations: [routerTransition()]
})
export class SignupComponent implements OnInit {

    model: any = {};

    constructor(
        public router: Router,
        private authService: AuthService,
        private alertify: AlertifyService
    ) {}

    ngOnInit() {}

    register() {
        this.authService.register(this.model).subscribe(() => {
            this.alertify.success('Rejestracja powiodła się. Teraz spróbuj się zalogować.');
        }, error => {
            this.alertify.error('Wystąpił błąd rejestracji.');
        });
    }
}

