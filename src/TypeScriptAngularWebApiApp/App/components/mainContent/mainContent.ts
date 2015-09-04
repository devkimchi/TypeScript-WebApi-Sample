/// <reference path="../../../Scripts/typings/angularjs/angular.d.ts" />
/// <reference path="../../models/registrationModel.ts" />
/// <reference path="../../factories/salutationsFactory.ts" />

"use strict";

module app.angular.Directives {
    import RegistrationModel = angular.Models.RegistrationModel;

    export interface IMainContentScope extends ng.IScope {
        model: angular.Models.RegistrationModel;
    }

    export class MainContent implements ng.IDirective {
        replace = true;
        restrict = "EA";
        scope = {};
        templateUrl = "/App/components/mainContent/mainContent.html";

        controller($scope: IMainContentScope, salutationsFactory: angular.Factories.SalutationsFactory) {
            $scope.model = new RegistrationModel();

            salutationsFactory.getResponse()
                .success((salutations: Array<angular.Models.Salutation>) => {
                    $scope.model.salutations = salutations;
                });
        }
    }
}

angular.module("app")
    .directive("mainContent", () => new app.angular.Directives.MainContent());

