import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { ExchangeRateMainComponent } from './main.component';

describe('ExchangeRateMainComponent', () => {
  let component: ExchangeRateMainComponent;
  let fixture: ComponentFixture<ExchangeRateMainComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ExchangeRateMainComponent]
    })
      .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ExchangeRateMainComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
