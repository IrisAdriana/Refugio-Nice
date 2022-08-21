import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { LoginService } from '../services/login-service/login.service';
import { FormGroup } from '@angular/forms';
import User from '../models/user';
@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})

export class LoginComponent implements OnInit {
  users$: Observable<User[]> | undefined;
  form!: FormGroup;
  userList: User | undefined;
  constructor(private service: LoginService) { }
  loading = false;

  ngOnInit(): void {
    this.users$ = this.service.getUser();
  }
  getUser(): void {
    console.log("p2");
    this.users$ = this.service.getUser();
    console.log(this.users$)
  }

  onSubmint(): void {

    console.log("hola");

    this.getUser();

  }
}
