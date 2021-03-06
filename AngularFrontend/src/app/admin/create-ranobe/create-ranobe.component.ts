import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { RanobesComponent } from 'src/app/ranobes/ranobes.component';
import { Ranobe } from 'src/app/ranobes/shared/ranobe.model';

import { RanobeService } from 'src/app/shared/ranobe.service';

@Component({
  selector: 'app-create-ranobe',
  templateUrl: './create-ranobe.component.html',
  styleUrls: ['./create-ranobe.component.css']
})
export class CreateRanobeComponent implements OnInit {

  statuses = [
    "Ongoing",
    "Complete",
    "Announce",
    "Freeze",
    "Deny"
  ]

  ranobe!: Ranobe;

  @Output() ranobeCreated = new EventEmitter<Ranobe>();

  constructor(
    private ranobeService: RanobeService,

  ) { }

  ngOnInit(): void {
    this.clear();
  }

  onSubmit() {
    this.ranobeCreated.emit(this.ranobe);
   }

  clear() {
    this.ranobe = new Ranobe(0, "", "", "", 0, new Date(), "", "", 0, 0, "");
  }

}
