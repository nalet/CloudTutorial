import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { SiteTwoComponent } from './site-two.component';

describe('SiteTwoComponent', () => {
  let component: SiteTwoComponent;
  let fixture: ComponentFixture<SiteTwoComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SiteTwoComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SiteTwoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
