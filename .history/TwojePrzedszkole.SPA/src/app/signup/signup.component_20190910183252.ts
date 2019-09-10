import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { routerTransition } from '../router.animations';
import { AuthService } from '../_services/auth.service';
declare let alertify: any;

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
        private authService: AuthService
    ) {}

    ngOnInit() {}

    register() {
        this.authService.register(this.model).subscribe(() => {
            alertify.succes('Rejestracja powiodła się.');
        }, error => {
            alertify.succes('Wystąpił błąd rejestracji.');
        });
    }
}

