import { Injectable } from '@angular/core';
import { HttpRequest, HttpHandler, HttpEvent, HttpInterceptor, HttpClient } from '@angular/common/http';
import { Observable, ReplaySubject } from 'rxjs';
import { environment } from '../../environments/environment.prod';
import { User } from '../models/identity/User';
import { ICadastro } from '../models/icadastro';
import { map, take } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class AccountService {
  private currentUserSource = new ReplaySubject<User>(1);
  public currentUser$ = this.currentUserSource.asObservable();

  baseUrl = environment.apiURL + 'api/account'
  constructor(private http: HttpClient) { }

  public getClienteROByCGC(Cgc: string): Observable<ICadastro> {
    return this.http.get<ICadastro>(`${this.baseUrl}/${Cgc}`).pipe(take(1));
  }

  public getClienteRSByCGC(Cgc: string): Observable<ICadastro> {
    return this.http.get<ICadastro>(`${this.baseUrl}/${Cgc}`).pipe(take(1));
  }

  public setCurrentUser(user: User): void {
    localStorage.setItem('user', JSON.stringify(user));
    this.currentUserSource.next(user);
  }
}
