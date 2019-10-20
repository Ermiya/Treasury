import { ApplicantsRegistrationComponent } from './applicants-registration/applicants-registration.component';
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { SimpleGuard } from '@delon/auth';
import { environment } from '@env/environment';
// layout
import { LayoutDefaultComponent } from '../layout/default/default.component';
import { UserLoginComponent } from './passport/login/login.component';

const routes: Routes = [
  { path: 'passport/login', component: UserLoginComponent },
  {
    path: '',
    component: LayoutDefaultComponent,
    canActivate: [SimpleGuard],
    canActivateChild: [SimpleGuard],
    children: [
      { path: '', redirectTo: 'dashboard/v1', pathMatch: 'full' },
      { path: 'dashboard', redirectTo: 'dashboard/v1', pathMatch: 'full' },
      {
        path: 'applicants-register',
        loadChildren: () =>
          import('./applicants-registration/applicants-registration.module').then(m => m.ApplicantsRegistrationModule),
        canActivate: [SimpleGuard],
        canActivateChild: [SimpleGuard],
      },
      {
        path: 'base-info/bank-acccounts',
        loadChildren: () =>
          import('../pages/bank-acccounts/bank-acccounts.module').then(m => m.BankAcccountsModule),
        canActivate: [SimpleGuard],
        canActivateChild: [SimpleGuard],
      },
      {
        path: 'base-info/bank-branch',
        loadChildren: () =>
          import('../pages/bank-branch/bank-branch.module').then(m => m.BankBranchModule),
        canActivate: [SimpleGuard],
        canActivateChild: [SimpleGuard],
      },
      {
        path: 'base-info/check-introduction',
        loadChildren: () =>
          import('../pages/check-introduction/check-introduction.module').then(m => m.CheckIntroductionModule),
        canActivate: [SimpleGuard],
        canActivateChild: [SimpleGuard],
      },
      {
        path: 'base-info/document-struct',
        loadChildren: () =>
          import('../pages/document-struct/document-struct.module').then(m => m.DocumentStructModule),
        canActivate: [SimpleGuard],
        canActivateChild: [SimpleGuard],
      },
      {
        path: 'base-info/exchange-rate',
        loadChildren: () =>
          import('../pages/exchange-rate/exchange-rate.module').then(m => m.ExchangeRateModule),
        canActivate: [SimpleGuard],
        canActivateChild: [SimpleGuard],
      },
      // {
      //   path: 'payment/day-check-payment/206',
      //   loadChildren: () =>
      //     import('../pages/common-pages/common-pages.module').then(m => m.CommonPagesModule),
      //   canActivate: [SimpleGuard],
      //   canActivateChild: [SimpleGuard],
      // },
      // {
      //   path: 'payment/short-check-payment/208',
      //   loadChildren: () =>
      //     import('../pages/common-pages/common-pages.module').then(m => m.CommonPagesModule),
      //   canActivate: [SimpleGuard],
      //   canActivateChild: [SimpleGuard],
      // },
      // {
      //   path: 'payment/check-payment/209',
      //   loadChildren: () =>
      //     import('../pages/common-pages/common-pages.module').then(m => m.CommonPagesModule),
      //   canActivate: [SimpleGuard],
      //   canActivateChild: [SimpleGuard],
      // },
      // {
      //   path: 'payment/garantee-check-payment/210',
      //   loadChildren: () =>
      //     import('../pages/common-pages/common-pages.module').then(m => m.CommonPagesModule),
      //   canActivate: [SimpleGuard],
      //   canActivateChild: [SimpleGuard],
      // },
      // {
      //   path: 'payment/money-payment/207',
      //   loadChildren: () =>
      //     import('../pages/common-pages/common-pages.module').then(m => m.CommonPagesModule),
      //   canActivate: [SimpleGuard],
      //   canActivateChild: [SimpleGuard],
      // },
      // {
      //   path: 'receive/day-check-receive/205',
      //   loadChildren: () =>
      //     import('../pages/common-pages/common-pages.module').then(m => m.CommonPagesModule),
      //   canActivate: [SimpleGuard],
      //   canActivateChild: [SimpleGuard],
      // },
      // {
      //   path: 'receive/check-receive/203',
      //   loadChildren: () =>
      //     import('../pages/common-pages/common-pages.module').then(m => m.CommonPagesModule),
      //   canActivate: [SimpleGuard],
      //   canActivateChild: [SimpleGuard],
      // },
      // {
      //   path: 'receive/sefteh-receive/202',
      //   loadChildren: () =>
      //     import('../pages/common-pages/common-pages.module').then(m => m.CommonPagesModule),
      //   canActivate: [SimpleGuard],
      //   canActivateChild: [SimpleGuard],
      // },
      // {
      //   path: 'receive/money-receive/204',
      //   loadChildren: () =>
      //     import('../pages/common-pages/common-pages.module').then(m => m.CommonPagesModule),
      //   canActivate: [SimpleGuard],
      //   canActivateChild: [SimpleGuard],
      // },
      // {
      //   path: 'bank-action/bank-settel/211',
      //   loadChildren: () =>
      //     import('../pages/common-pages/common-pages.module').then(m => m.CommonPagesModule),
      //   canActivate: [SimpleGuard],
      //   canActivateChild: [SimpleGuard],
      // },
      // {
      //   path: 'bank-action/bank-get/212',
      //   loadChildren: () =>
      //     import('../pages/common-pages/common-pages.module').then(m => m.CommonPagesModule),
      //   canActivate: [SimpleGuard],
      //   canActivateChild: [SimpleGuard],
      // },
      // {
      //   path: 'bank-action/bank-assain/213',
      //   loadChildren: () =>
      //     import('../pages/common-pages/common-pages.module').then(m => m.CommonPagesModule),
      //   canActivate: [SimpleGuard],
      //   canActivateChild: [SimpleGuard],
      // },
      // {
      //   path: 'bank-action/check-to-money/214',
      //   loadChildren: () =>
      //     import('../pages/common-pages/common-pages.module').then(m => m.CommonPagesModule),
      //   canActivate: [SimpleGuard],
      //   canActivateChild: [SimpleGuard],
      // },
      // {
      //   path: 'check-converting/short-check-convert/216',
      //   loadChildren: () =>
      //     import('../pages/common-pages/common-pages.module').then(m => m.CommonPagesModule),
      //   canActivate: [SimpleGuard],
      //   canActivateChild: [SimpleGuard],
      // },
      // {
      //   path: 'check-converting/converting-floating-check-to-daily/217',
      //   loadChildren: () =>
      //     import('../pages/common-pages/common-pages.module').then(m => m.CommonPagesModule),
      //   canActivate: [SimpleGuard],
      //   canActivateChild: [SimpleGuard],
      // }
      // ,
      // {
      //   path: '',
      //   loadChildren: () =>
      //     import('../pages/common-pages/common-pages.module').then(m => m.CommonPagesModule),
      //   canActivate: [SimpleGuard],
      //   canActivateChild: [SimpleGuard],
      // },
      {
        path: 'common/:id',
        loadChildren: () =>
          import('../pages/common-pages/common-pages.module').then(m => m.CommonPagesModule),
        canActivate: [SimpleGuard],
        canActivateChild: [SimpleGuard],
      }
    ],
  },

  { path: '**', redirectTo: 'exception/404' },
];

@NgModule({
  imports: [
    RouterModule.forRoot(routes, {
      useHash: environment.useHash,
      // NOTICE: If you use `reuse-tab` component and turn on keepingScroll you can set to `disabled`
      // Pls refer to https://ng-alain.com/components/reuse-tab
      scrollPositionRestoration: 'top',
    }),
  ],
  exports: [RouterModule],
})
export class RouteRoutingModule { }
