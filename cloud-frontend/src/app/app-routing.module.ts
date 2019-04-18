import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { SiteOneComponent } from './site-one/site-one.component';
import { SiteTwoComponent } from './site-two/site-two.component';
import { SiteThreeComponent } from './site-three/site-three.component';

const routes: Routes = [
  { path: 'site-two', component: SiteTwoComponent },
  { path: 'site-three', component: SiteThreeComponent },
  { path: '', component: SiteOneComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
