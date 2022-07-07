import { Component, OnInit } from '@angular/core';

import { RanobeService } from '../shared/ranobe.service'
import { Ranobe } from './shared/ranobe.model'

@Component({
  selector: 'app-ranobes',
  templateUrl: './ranobes.component.html',
  styleUrls: ['./ranobes.component.css']
})
export class RanobesComponent implements OnInit {

  ranobes: Ranobe[] = [];

  constructor(private ranobeService: RanobeService) { }

  ngOnInit(): void {
    this.getRanobes();
  }

  getRanobes(): void {
    this.ranobeService.getRanobes()
      .subscribe(ranobes => this.ranobes = ranobes);
  }

}
