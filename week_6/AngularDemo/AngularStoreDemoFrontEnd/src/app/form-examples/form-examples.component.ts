import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-form-examples',
  templateUrl: './form-examples.component.html',
  styleUrls: ['./form-examples.component.css']
})
export class FormExamplesComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

  // register form - fname, lname, email, phone number, username, password
  reactiveformexample = new FormGroup({
    fname: new FormControl('', [Validators.required, Validators.maxLength(20), Validators.minLength(3), Validators.pattern('[a-zA-Z]*')]),
    lname: new FormControl('', [Validators.required, Validators.maxLength(20), Validators.minLength(3)]),
    email: new FormControl('', Validators.email),
    phonenumber: new FormControl('', Validators.required),
    username: new FormControl('', Validators.required),
    password: new FormControl('', Validators.required)
  });

  submitReactiveForm() {
    console.log(`fname - ${this.reactiveformexample.get('fname')?.value}, lname - ${this.reactiveformexample.get('lname')?.value}, email - ${this.reactiveformexample.get('email')?.value}, phonenumber - ${this.reactiveformexample.get('phonenumber')?.value}, username - ${this.reactiveformexample.get('username')?.value}, password - ${this.reactiveformexample.get('password')?.value}`);
  }

  fname2?: string;
  lname2?: string;
  email2?: string;
  phonenumber2?: number;
  username2?: string;
  password2?: string;

  submitTemplateForm() {
    console.log(`${this.fname2}, ${this.lname2}, ${this.email2}, ${this.phonenumber2}, ${this.username2}, ${this.password2}`);
  }
}
