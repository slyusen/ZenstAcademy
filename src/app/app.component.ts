/**
 * @license
 * Copyright Akveo. All Rights Reserved.
 * Licensed under the MIT License. See License.txt in the project root for license information.
 */
import { Component, OnInit } from '@angular/core';
import { AnalyticsService } from './@core/utils/analytics.service';
import { Http, Response } from '@angular/http';

import { AppService } from './app.service';


@Component({
  selector: 'ngx-app',
  template: '<router-outlet></router-outlet>',
})
export class AppComponent implements OnInit {

  greetings = "";
  constructor(private analytics: AnalyticsService, private _appService: AppService) {
  }

  ngOnInit(): void {
    this._appService.sayHello()
      .subscribe(
      result => {
        this.greetings = result;
      }
      );
    this.analytics.trackPageViews();
  }
}
