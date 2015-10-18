/// <reference path="../../../Scripts/typings/angularjs/angular.d.ts" />
/// <reference path="../../models/registrationModel.ts" />
/// <reference path="../../factories/salutationsFactory.ts" />

"use strict";

module app.angular.Directives {
    import RegiastrationModel = angular.Models.RegistrationModel;

    export interface IMainContentScope extends ng.IScope {
        model: angular.Models.RegistrationModel;
    }

    export class MainContent implements ng.IDirective {
        replace = true;
        restrict = "EA";
        scope = {
            model: new angular.Models.RegistrationModel()
        };
        templateUrl = "/App/components/mainContent/mainContent.html";

        controller($scope: IMainContentScope, salutationsFactory: angular.Factories.SalutationsFactory) {
            salutationsFactory.getResponse()
                .success((model: angular.Models.RegistrationModel) => {
                    $scope.model = model;
                });
        }
    }
}

angular.module("app")
    .directive("mainContent", () => new app.angular.Directives.MainContent());

