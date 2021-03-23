import { Component, OnInit } from '@angular/core';
import { RegisterResponseModel } from '../models/register-response.model';
import { RegisterModel } from '../models/register.model';
import { AuthService } from '../services/auth.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {

  constructor(private authService: AuthService) { }

  selectedGender: string = 'Male';
  user: RegisterModel = new RegisterModel();

  onSubmit(){
    this.user.gender = this.selectedGender;
    this.authService.Register(this.user).subscribe(
      (response: RegisterResponseModel) => {
        if(response.success){
          localStorage.setItem('token', response.token);
          this.user = new RegisterModel();
        }else{
          this.user = new RegisterModel();
        }
      }
    );
  }

  ngOnInit() {
  }

}
