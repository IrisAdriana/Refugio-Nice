import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { LoginService } from '../services/login-service/login.service';
import { FormBuilder, FormGroup } from '@angular/forms';
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
  // cuenta: string ;
  // pwd: string | undefined;

  constructor(private service: LoginService,
    private userForm: FormBuilder) { }
  loading = false;

  ngOnInit(): void {
    this.form = this.userForm.group({
      Cuenta: String,
      Contrasenia: String,
    })
    this.getUser("Usuario1", "123")
  }
  getUser(cuenta: string, pwd: string): void {
    this.users$ = this.service.getUser(cuenta, pwd);
    console.log(this.users$)
    console.log("Is true")
  }
  // start(): boolean {
  //   let value = false;
  //   this.cuenta = this.userList?.Cuenta;
  //   this.pwd = this.userList?.Contrasenia;
  //   if (this.getUser(this.us.Cuenta, this.us.Contrasenia)) {
  //     console.log(" is True");
  //     value = true;
  //   }
  //   else {
  //     console.log("Is False")
  //     value = false
  //   }
  //   return value;
  // }

  // onSubmint(): void {

  //   console.log("hola");

  //   this.getUser();

  // }
}
