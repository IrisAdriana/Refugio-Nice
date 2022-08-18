import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { LoginService } from '../login-service/login.service';
import User from '../models/user';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  users$:Observable<User[]> | undefined;

  constructor(private service:LoginService) { }

  ngOnInit(): void {
    this.users$ = this.service.getUser();

  }

}
