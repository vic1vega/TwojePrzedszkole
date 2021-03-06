import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { routerTransition } from '../router.animations';
import { AuthService } from '../_services/auth.service';
import { AlertifyService } from '../_services/alertify.service';

@Component({
    selector: 'app-login',
    templateUrl: './login.component.html',
    styleUrls: ['./login.component.scss'],
    animations: [routerTransition()]
})
export class LoginComponent implements OnInit {

    model: any = {};

    constructor(
        public router: Router,
        private authService: AuthService,
        private alertify: AlertifyService
    ) { }

    ngOnInit() { }

    login() {
        this.authService.login(this.model).subscribe(next => {
            this.alertify.success('Udało się zalogować.');
            localStorage.setItem('isLoggedin', 'true');
            this.router.navigate(['/dashboard']);
        }, error => {
            this.alertify.error('Logowanie nieudane.');
        });

    }

    loggedIn() {
        // this.login();
        // localStorage.setItem('isLoggedin', 'true');
        // // const onLogin = localStorage.getItem('isLogggedin');
        // this.router.navigate(['/dashboard']);

    }
}
