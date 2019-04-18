# CloudTutorial #

## Plain Angular App ##
Create a new Angular Application with:

    ng new cloud-frontend -g

Choose SCSS as style definition type und use Routing.

Change directory to the project:

    cd cloud-frontend

Add the Material design

    ng add @angular/material

Use your prefered style and answer the other questions with yes.

Run the application with:

    ng serve

Browse to the URL: http://localhost:4200/ to see your application.

Adding a navigation with:

    ng generate @angular/material:material-nav --name=my-nav

Running the command with `-d true` shows you the output without modifing files.

Adding a dashboard with:

    ng generate @angular/material:material-dashboard --name=my-dashboard

Adding a table with:

    ng generate @angular/material:material-table --name=my-table

Generate three sites with:

    ng g component siteOne
    ng g component siteTwo
    ng g component siteThree

Change the file content of app.component.html to:

    <app-my-nav></app-my-nav>

Now we want to implement different sites, as we navigate trough our application. Therefore we change the routes variable in `app-routing.module.ts`

    const routes: Routes = [
        { path: 'site-two', component: SiteTwoComponent },
        { path: 'site-three', component: SiteThreeComponent },
        { path: '', component: SiteOneComponent }
    ];

SiteOneCompontent is at the end with no path, as we want it to be our default page.

Now we add these routes to the navigation component, by changing the links as following in the `<mat-nav-list>`:

    <mat-nav-list>
      <a mat-list-item href="/">Site One</a>
      <a mat-list-item href="site-two">Site Two</a>
      <a mat-list-item href="site-three">Site Three</a>
    </mat-nav-list>

Add the `<router-outlet></router-outlet>` as follows:

    <!-- Add Content Here -->
    <router-outlet></router-outlet>

Now the navigation works and you can see the changes in your app.

As the navigation is set up, we want to add some content to it. So change the `site-one.component.html` that it looks like that:

    <app-my-dashboard></app-my-dashboard>

The Table component does not work, so we are using this example https://material.angular.io/components/table/overview make the changes accordingly.