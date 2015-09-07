/// <reference path="../../Scripts/typings/angularjs/angular.d.ts" />

"use strict";

module app.angular.Models {
    export class Link {
        href: string;
        templated: boolean;
    }

    export class SelfLink {
        self: Link;
    }

    export class Salutation {
        text: string;
        value: string;
        _links: SelfLink;
    }

    export class RegistrationModel {
        _embedded: Array<Salutation>;
        _links: SelfLink;
    }
}