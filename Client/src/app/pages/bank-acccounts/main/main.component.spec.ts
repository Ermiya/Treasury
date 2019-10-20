import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { BankAcccountsMainComponent } from './main.component';

describe('BankAcccountsMainComponent', () => {
  let component: BankAcccountsMainComponent;
  let fixture: ComponentFixture<BankAcccountsMainComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [BankAcccountsMainComponent]
    })
      .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(BankAcccountsMainComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
