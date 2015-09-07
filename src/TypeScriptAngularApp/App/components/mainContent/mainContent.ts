/// <reference path="../../../Scripts/typings/angularjs/angular.d.ts" />
/// <reference path="../../models/registrationModel.ts"/>

"use strict";

module app.angular.Directives {
    import RegistrationModel = angular.Models.RegistrationModel;
    import Salutation = angular.Models.Salutation;

    export interface IMainContentScope extends ng.IScope {
        model: angular.Models.RegistrationModel;
    }

    export class MainContent implements ng.IDirective {
        replace = true;
        restrict = "EA";
        scope = {};
        templateUrl = "/App/components/mainContent/mainContent.html";

        controller($scope: IMainContentScope) {
            $scope.model = new RegistrationModel();
            $scope.model.salutations = [
                new Salutation("Mr", "Mr"),
                new Salutation("Ms", "Ms"),
                new Salutation("Mrs", "Mrs"),
                new Salutation("Mx", "Mx")
            ];
        }
    }
}

angular.module("app").directive("mainContent", () => new app.angular.Directives.MainContent());

