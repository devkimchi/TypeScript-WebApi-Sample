/// <reference path="../../Scripts/typings/angularjs/angular.d.ts" />

"use strict";

module app.angular.Models {
    export class Link {
        href: string;
    }

    export class LinkCollection {
        self: Link;
        salutations: Link;
    }

    export class Salutation {
        text: string;
        value: string;
        _links: LinkCollection;
    }

    export class SalutationCollection {
        salutations: Array<Salutation>;
    }

    export class RegistrationModel {
        _links: LinkCollection;
        _embedded: SalutationCollection;
    }
}