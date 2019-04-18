import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { SiteThreeComponent } from './site-three.component';

describe('SiteThreeComponent', () => {
  let component: SiteThreeComponent;
  let fixture: ComponentFixture<SiteThreeComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SiteThreeComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SiteThreeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
