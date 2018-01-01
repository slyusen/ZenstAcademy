import { Injectable } from '@angular/core';
import { Http, Response, Headers } from '@angular/http';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/catch';

import { Observable } from 'rxjs/Observable';


@Injectable()
export class StudentService {

    public headers: Headers;

    constructor(private http: Http) {
        this.headers = new Headers({ 'Content-Type': 'application/json', 'Accept': 'q=0.8;application/json;q=0.9' });  
        
    }

    getStudents() {
        return this.http.get('/api/students').map(res => res.json());
    }
    getStudentByNumber(id: string) {
        return this.http.get('/api/students/' + id).map(res => res.json());
    }
    getStudentByCourse(id: number) {
        return this.http.get('/api/students/bycourse/' + id).map(res => res.json());
    }
    addNewStudent(student: any): Observable<any> {
        
        return this.http.post('/api/students/add', JSON.stringify(student), { headers: this.headers })
        
    .map(this.extractData)
            .catch(this.handleError);
    }

    private extractData(res: Response) {
        let body = res.json();
        return body || {};
    }

    private handleError(error: any) {
        let errMsg = (error.message) ? error.message :
            error.status ? `${error.status} - ${error.statusText}` : 'Server error';
        console.error(errMsg);
        return Observable.throw(errMsg);
    }
}
