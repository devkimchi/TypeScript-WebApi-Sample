/// <reference path="../../Scripts/typings/angularjs/angular.d.ts" />

"use strict";

module app.angular.Models {
    export class Salutation {
        constructor(text: string, value: string) {
            this.text = text;
            this.value = value;
        }

        text: string;
        value: string;
    }

    export class RegistrationModel {
        salutations: Array<Salutation>;
    }
}