import { Component, OnInit } from '@angular/core';
import { StudentService } from '../../../services/student.service';
import { CourseService } from '../../../services/course.service';


@Component({
  selector: 'ngx-students',
  styleUrls: ['./students.component.scss'],
  templateUrl: './students.component.html',
})
export class StudentsComponent implements OnInit {

  

  public minDate = new Date(2017, 5, 10);
  public maxDate = new Date(2018, 9, 15);
 
  public bsValue: Date = new Date();
  

  public dob: any = this.bsValue.toDateString();

  public students: any;
  public student: any = {};
  public courses: any[];
  public selectedCourse: any;

  public school: any = {};

  public firstName: string = "";
  public lastName: string = "";
  public errorMessage: any;

  /**
   *
   */
  constructor(private studentService: StudentService, private courseService: CourseService) {
    
  }

  ngOnInit() {
       
    this.courseService.getCourses().subscribe(courses => {
        this.courses = courses;
        console.log("Course: ", this.courses);

    });
    this.courseService.getCourseById(1).subscribe(course => {
        this.selectedCourse = course;
        console.log("Course: ", this.selectedCourse.courseTitle);

    });
 
 
}

onSave() {

  //this.dob = this.bsValue.toDateString();
  if(this.dob == null)
      this.dob = this.minDate.toDateString();
 

  this.student.firstName = this.firstName;
  this.student.lastName = this.lastName;
  this.student.dateOfBirth = this.dob;
  console.log("Student to Add: ",this.student);
  this.studentService.addNewStudent(this.student).subscribe(result => console.log(result),
      error => this.errorMessage = <any>error);

  console.log("Error: ", this.errorMessage);
}
 



}
