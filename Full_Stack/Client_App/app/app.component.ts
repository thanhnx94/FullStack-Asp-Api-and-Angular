import { Component, OnInit } from '@angular/core';
import { User } from "./user";
import { UserService } from "./user.service";

@Component({
    selector: 'my-app',
    providers: [UserService],
  template: `<h1>Hello {{name}} - ----- Thành công rồi</h1><br>
            <div class='table-responsive'>
            <div></div>
            <div></div>
            <div *ngIf='users && users.length==0' class="alert alert-info" role="alert">No record found!</div>
            <table class='table table-striped' *ngIf='users && users.length'>
                <thead>
                    <tr>
                        <th>First Name</th>
                        <th>Last Name</th>
                        <th>Gender</th>
                        <th></th>
                    </tr>
                </thead>
                <tbody>
                    <tr *ngFor="let user of users">
                        <td>{{user.Id}}</td>
                        <td>{{user.name}}</td>
                        <td>{{user.status}}</td>
                        <td>
                            <button title="Edit" class="btn btn-primary">Edit</button>
                            <button title="Delete" class="btn btn-danger">Delete</button>
                        </td>
                    </tr>
                </tbody>
            </table>
            <div>
            </div>
        </div>`,
})
export class AppComponent implements OnInit {
    name = 'Angular';
    results: string[];
    indLoading: boolean = false;
    _url_base: 'api/v1/User';
    users: User[];
    msg: string;
    constructor(private _userService: UserService) { }
    ngOnInit(): void {
        this._url_base = 'api/v1/User';
        this.LoadUsers();
    }

    LoadUsers(): void {
        console.log(this._url_base);
        this.indLoading = true;
        this._userService.get(this._url_base)
            .subscribe(users => { this.users = users; this.indLoading = false; },
            error => this.msg = <any>error);
    }
    
}
