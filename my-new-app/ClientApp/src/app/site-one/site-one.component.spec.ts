import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { SiteOneComponent } from './site-one.component';

describe('SiteOneComponent', () => {
  let component: SiteOneComponent;
  let fixture: ComponentFixture<SiteOneComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SiteOneComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SiteOneComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
