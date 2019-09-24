import { NgModule } from "@angular/core";
import { CommonModule } from "@angular/common";
import { FormsModule } from "@angular/forms";
// import { MockBackend } from "@angular/http/testing";

import { AuthRoutingModule } from "./auth-routing.routing";
import { AuthComponent } from "./auth.component";
// import { AlertComponent } from "./_directives/alert.component";
// import { LogoutComponent } from "./logout/logout.component";
// import { AuthGuard } from "./_guards/auth.guard";
// import { AlertService } from "./_services/alert.service";
// import { AuthenticationService } from "./_services/authentication.service";

@NgModule({
    declarations: [
        AuthComponent,
        // AlertComponent,
        // LogoutComponent,
    ],
    imports: [
        CommonModule,
        FormsModule,
        AuthRoutingModule,
    ],
    providers: [
        // AuthGuard,
        // AlertService,
        // AuthenticationService,
        // MockBackend
    ],
    entryComponents: [
        // AlertComponent
    ]
})

export class AuthModule {
}