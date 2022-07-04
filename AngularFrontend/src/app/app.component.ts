import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  public ranobes?: Ranobe[];

  constructor(http: HttpClient) {
    http.get<Ranobe[]>('/api/ranobes').subscribe(result => {
      this.ranobes = result;
    }, error => console.error(error));
  }

  title = 'AngularFrontend';
}

interface Ranobe {
  englishName: string;
  foreignName: string;
  description: string;
  chapters: number;
  publishDate: Date;
  status: string;
}
