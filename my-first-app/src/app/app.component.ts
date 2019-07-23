import { Component } from '@angular/core';

export class Person{
  id: number;
  name: string;
}

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'my-first-app';
  personData: Person[] = [
  { id : 1, name: 'satya'},
  {id: 2, name: 'james'}
  ];
}
