import { Injectable } from '@angular/core';
import { Http } from '@angular/http';
import 'rxjs/add/operator/map';

@Injectable()
export class CourseService {


    constructor(private http: Http) {

    }

    getCourses() {
        return this.http.get('/api/courses').map(res => res.json());
    }
    getCourseById(id: number) {
        return this.http.get('/api/courses/' + id).map(res => res.json());
    }
}
