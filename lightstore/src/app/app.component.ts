import { Component, OnInit } from '@angular/core';
import { Router, NavigationStart, NavigationEnd } from '@angular/router';
declare var $: any;
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {
  title = 'my-dream-app';
  public options = {
    position: ['top', 'right'],
    timeOut: 2000,
    clickToClose: true,
    lastOnBottom: true,
    preventDuplicates: true,
    maxStack: 2,
  };

  constructor(private _router: Router,
    ) {
    this._router.events.subscribe(event => {
      if (event instanceof NavigationEnd) {
        $('.modal-backdrop').remove();
      }
    });
  }

  ngOnInit() {

  }
}
