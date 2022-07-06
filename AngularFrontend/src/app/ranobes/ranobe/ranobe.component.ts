import { Component, OnInit, Input } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

import { Ranobe } from '../shared/ranobe.model';
import { RanobeService } from '../shared/ranobe.service';

@Component({
  selector: 'app-ranobe',
  templateUrl: './ranobe.component.html',
  styleUrls: ['./ranobe.component.css']
})
export class RanobeComponent implements OnInit {

  @Input() ranobe?: Ranobe;

  constructor(
    private ranobeService: RanobeService,
    private route: ActivatedRoute
  ) { }

  ngOnInit(): void {
    this.getRanobe();
  }

  getRanobe(): void {
    const id = Number(this.route.snapshot.paramMap.get('id'));
    console.log(id);
    this.ranobeService.getRanobeById(id)
      .subscribe(ranobe => this.ranobe = ranobe);
  }

}
