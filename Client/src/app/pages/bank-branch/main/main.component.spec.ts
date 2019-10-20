import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { BankBranchMainComponent } from './main.component';

describe('BankBranchMainComponent', () => {
  let component: BankBranchMainComponent;
  let fixture: ComponentFixture<BankBranchMainComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [BankBranchMainComponent]
    })
      .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(BankBranchMainComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
