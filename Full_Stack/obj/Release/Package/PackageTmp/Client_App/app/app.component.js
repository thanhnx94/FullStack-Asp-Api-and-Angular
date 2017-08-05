"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = require("@angular/core");
var user_service_1 = require("./user.service");
var AppComponent = (function () {
    function AppComponent(_userService) {
        this._userService = _userService;
        this.name = 'Angular';
        this.indLoading = false;
    }
    AppComponent.prototype.ngOnInit = function () {
        this._url_base = 'api/v1/User';
        this.LoadUsers();
    };
    AppComponent.prototype.LoadUsers = function () {
        var _this = this;
        console.log(this._url_base);
        this.indLoading = true;
        this._userService.get(this._url_base)
            .subscribe(function (users) { _this.users = users; _this.indLoading = false; }, function (error) { return _this.msg = error; });
    };
    AppComponent = __decorate([
        core_1.Component({
            selector: 'my-app',
            providers: [user_service_1.UserService],
            template: "<h1>Hello {{name}} - ----- Th\u00E0nh c\u00F4ng r\u1ED3i</h1><br>\n            <div class='table-responsive'>\n            <div></div>\n            <div></div>\n            <div *ngIf='users && users.length==0' class=\"alert alert-info\" role=\"alert\">No record found!</div>\n            <table class='table table-striped' *ngIf='users && users.length'>\n                <thead>\n                    <tr>\n                        <th>First Name</th>\n                        <th>Last Name</th>\n                        <th>Gender</th>\n                        <th></th>\n                    </tr>\n                </thead>\n                <tbody>\n                    <tr *ngFor=\"let user of users\">\n                        <td>{{user.Id}}</td>\n                        <td>{{user.name}}</td>\n                        <td>{{user.status}}</td>\n                        <td>\n                            <button title=\"Edit\" class=\"btn btn-primary\">Edit</button>\n                            <button title=\"Delete\" class=\"btn btn-danger\">Delete</button>\n                        </td>\n                    </tr>\n                </tbody>\n            </table>\n            <div>\n            </div>\n        </div>",
        }),
        __metadata("design:paramtypes", [user_service_1.UserService])
    ], AppComponent);
    return AppComponent;
}());
exports.AppComponent = AppComponent;
//# sourceMappingURL=app.component.js.map