import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { DocumentStructMainComponent } from './main.component';

describe('DocumentStructMainComponent', () => {
  let component: DocumentStructMainComponent;
  let fixture: ComponentFixture<DocumentStructMainComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [DocumentStructMainComponent]
    })
      .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DocumentStructMainComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
