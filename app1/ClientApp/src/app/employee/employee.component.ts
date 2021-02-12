import { HttpClient, HttpHandler, HttpHeaders } from '@angular/common/http';
import { Component, Inject, OnInit } from '@angular/core';

@Component({
  selector: 'app-employee',
  templateUrl: './employee.component.html',
  styleUrls: ['./employee.component.css']
})
export class EmployeeComponent implements OnInit {
  public employees: Employee[];
  public http: HttpClient;
  public baseUrl: string;
  showdata: boolean = false;

  //constructor() { }
  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string, private handler: HttpHandler) {
    //http.get<Employee[]>(baseUrl + 'employee/GetEmployee').subscribe(result => {
    //  this.employees = result;
    //}, error => console.error(error));
    this.http = new HttpClient(handler)
    this.baseUrl = baseUrl;
    //this.employees = new Employee[];
    console.log("In Constructor employees are : ", this.employees);
  }

  ngOnInit() {
    console.log("in ngOnInIt employees are : ", this.employees);
  }

  loadData() {
    this.http.get<Employee[]>(this.baseUrl + 'employee/GetEmployee').subscribe((result:Employee[]) => {
      this.employees = result;
      console.log("success employee data are :", this.employees)
    }, error => console.error(" error is :",error));
    this.showdata = !this.showdata;
  }

}

export class Employee {
  EmployeeName: string;
  JoiningDate: Date;
  BirthDate: Date;
  Designation: string;
  Salary: number;
}
