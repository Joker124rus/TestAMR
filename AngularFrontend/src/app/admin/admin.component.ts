import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { tap } from 'rxjs/operators';

import { Ranobe } from '../ranobes/shared/ranobe.model';
import { RanobeService } from '../shared/ranobe.service';

@Component({
  selector: 'app-admin',
  templateUrl: './admin.component.html',
  styleUrls: ['./admin.component.css']
})
export class AdminComponent implements OnInit {

  ranobes: Ranobe[] = [];

  isCreating: boolean = false;

  constructor(
    private ranobeService: RanobeService
  ) { }

  ngOnInit(): void {
    this.loadRanobes();
  }

  loadRanobes(): void {
    this.ranobeService.getRanobes()
      .subscribe(ranobes => this.ranobes = ranobes);
  }

  showCreateForm(): void {
    if (this.isCreating) {
      this.isCreating = false;
    }
    else {
      this.isCreating = true;
    }
  }

  createRanobe(ranobe: Ranobe): void {
     this.ranobeService.createRanobe(ranobe)
       .subscribe(ranobe => this.ranobes.push(ranobe));
  }
}
