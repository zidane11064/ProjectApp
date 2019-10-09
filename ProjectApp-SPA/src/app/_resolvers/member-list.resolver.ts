import { Injectable } from "@angular/core";
import { Resolve, Router, ActivatedRouteSnapshot } from '@angular/router';
import { User } from '../_model/user';
import { UserService } from '../_services/user.service';
import { AlertifyService } from '../_services/alertify.service';
import { catchError } from 'rxjs/operators';
import { of, Observable } from 'rxjs';

@Injectable()

export class MemberListResolver implements Resolve<User[]> {
    constructor(private userService: UserService, private router: Router, private alertify: AlertifyService) { }

    pageNumber = 1;
    pageSize = 5;

    resolve(route: ActivatedRouteSnapshot): Observable<User[]> {
        // tslint:disable-next-line: no-string-literal
        return this.userService.getUsers(this.pageNumber, this.pageSize).pipe(
            catchError(error => {
                this.alertify.error('Problem retrieving data');
                this.router.navigate(['/home']);
                return of(null);
            })
        );
    }
}