import { Component, OnInit } from '@angular/core';

import { FormGroup } from '@angular/forms';
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

  loading = false;

  form! : FormGroup;
  userList: User | undefined ;

  constructor(private service:LoginService) { }

  ngOnInit(): void {
    
    /*this.users$ = this.service.getUser();
    console.log(this.users$);*/

  }
  getUser():void{

    console.log("p2");
    this.users$ = this.service.getUser();
    console.log(this.users$)
  }

  onSubmint(): void {

    console.log("hola");
    
      this.getUser();
     
  
  }


  

}
