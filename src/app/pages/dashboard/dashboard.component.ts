import { Component, OnInit} from '@angular/core';
import { AppService } from '../../app.service';



@Component({
  selector: 'ngx-dashboard',
  styleUrls: ['./dashboard.component.scss'],
  templateUrl: './dashboard.component.html',
})


export class DashboardComponent {
  greetings = 'Hello';

  constructor(private _appService: AppService){

  }
  ngOnInit(): void {
    this._appService.sayHello()
      .subscribe(
      result => {
        this.greetings = result;
      }
      );
  }
}
