import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { routerTransition } from '../router.animations';
import { AuthService } from '../_services/auth.service';

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
      private authService: AuthService
    ) {}

    ngOnInit() {}

    login() {
        this.authService.login(this.model).subscribe(next => {
            console.log('Udało się zalogować.');
        }, error => {
            console.log('Logowanie nieudane.');
        });
    }

    onLoggedin() {
        this.login();

        const token = localStorage.getItem('token');
        if (token) {
            localStorage.setItem('isLoggedin', 'true');
        }
    }
}
