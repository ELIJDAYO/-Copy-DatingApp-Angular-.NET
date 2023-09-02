import { Injectable, inject } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import {CanActivateFn} from '@angular/router'
import { Observable, map } from 'rxjs';
import { AccountService } from '../_services/account.service';


export const AuthGuard: CanActivateFn = (router, state) => {
  const accountService = inject(AccountService);
  const toastr = inject(ToastrService)

  return accountService.currentUser$.pipe(
    map(user => {
      if(user) return true;
      toastr.error("You shall not pass")
      return false
    })
  )
}
