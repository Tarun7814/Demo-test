import { Component, EventEmitter, Injector, OnInit, Output } from '@angular/core'; 
import { AppComponentBase } from '@shared/app-component-base';
import { BsModalRef } from 'ngx-bootstrap/modal'; 
import { CountriesDto,CountriesServiceProxy } from '@shared/service-proxies/service-proxies';

@Component({
  selector: 'app-create-country',
  templateUrl: './create-country.component.html',
  styles: [
  ]
})
export class CreateCountryComponent extends AppComponentBase
implements OnInit {
saving = false;
country: CountriesDto = new CountriesDto();

@Output() onSave = new EventEmitter<any>();

constructor(
  injector: Injector,
  public _countryService: CountriesServiceProxy,
  public bsModalRef: BsModalRef
) {
  super(injector);
}

ngOnInit(): void {
   
}

save(): void {
  this.saving = true;

  this._countryService.create(this.country).subscribe(
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

