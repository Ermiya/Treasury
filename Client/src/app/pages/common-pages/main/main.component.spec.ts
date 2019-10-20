import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { CommonPagesMainComponent } from './main.component';

describe('CommonPagesMainComponent', () => {
  let component: CommonPagesMainComponent;
  let fixture: ComponentFixture<CommonPagesMainComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [CommonPagesMainComponent]
    })
      .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CommonPagesMainComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
