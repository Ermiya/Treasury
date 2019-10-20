import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { CheckIntroductionMainComponent } from './main.component';

describe('CheckIntroductionMainComponent', () => {
  let component: CheckIntroductionMainComponent;
  let fixture: ComponentFixture<CheckIntroductionMainComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [CheckIntroductionMainComponent]
    })
      .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CheckIntroductionMainComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
