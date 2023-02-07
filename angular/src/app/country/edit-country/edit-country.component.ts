import { Component, EventEmitter, Injector, OnInit, Output } from '@angular/core';
import { AppComponentBase } from '@shared/app-component-base';
import { CountriesDto,CountriesServiceProxy } from '@shared/service-proxies/service-proxies';
import { BsModalRef } from 'ngx-bootstrap/modal';
@Component({
  selector: 'app-edit-country',
  templateUrl: './edit-country.component.html',
  styles: [
  ]
})
export class EditCountryComponent extends AppComponentBase
implements OnInit {
saving = false;
country: CountriesDto = new CountriesDto();
id: string;

@Output() onSave = new EventEmitter<any>();

constructor(
  injector: Injector,
  public _countryService: CountriesServiceProxy,
  public bsModalRef: BsModalRef
) {
  super(injector);
}

ngOnInit(): void {
  this._countryService.get(this.id).subscribe((result: CountriesDto) => {
    this.country = result;
  });
}

save(): void {
  this.saving = true;

  this._countryService.update(this.country).subscribe(
    () => {
      this.notify.info(this.l('SavedSuccessfully'));
      this.bsModalRef.hide();
      this.onSave.emit();
    },
    () => {
      this.saving = false;
    }
  );
}
}
