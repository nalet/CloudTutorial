import { Component, OnInit, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-site-three',
  templateUrl: './site-three.component.html',
  styleUrls: ['./site-three.component.css']
})
export class SiteThreeComponent implements OnInit {

  public objekte: Objekt[];
  public newObjekt: Objekt = new Objekt()
  public personen: Person[];

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {
    this.load();
  }

  load() {
    this.http.get<Objekt[]>(this.baseUrl + 'api/Objekt').subscribe(result => {
      this.objekte = result;
    }, error => console.error(error));
    this.http.get<Person[]>(this.baseUrl + 'api/Person').subscribe(result => {
      this.personen = result;
    }, error => console.error(error));
  }

  ngOnInit() {
  }

  submit(form) {
    this.http.post<Objekt>(this.baseUrl + 'api/Objekt',this.newObjekt).subscribe(result => {
      this.newObjekt = new Objekt();
      this.load();
    }, error => console.error(error));
  }

  delete(id) {
    this.http.delete(this.baseUrl + 'api/Objekt/' + id).subscribe(result => {
      this.load();
    }, error => console.error(error));
  }

}

class Objekt {
  objektId: number;
  name: string;
  besitzer: Person;
  einheiten: any[];
}

class Person {
  personId: number;
  name: string;
}