/// <reference path="../../../Scripts/typings/angularjs/angular.d.ts" />

"use strict";

module app.angular.Directives {
    export interface IMainContentScope extends ng.IScope {
        username: string;
        password: string;
    }

    export class MainContent implements ng.IDirective {
        replace = true;
        restrict = "EA";
        scope = {};
        templateUrl = "/App/components/mainContent/mainContent.html";

        controller($scope: IMainContentScope) {
            $scope.username = "Enter username";
            $scope.password = "Enter password";
        }
    }
}

angular.module("app").directive("mainContent", () => new app.angular.Directives.MainContent());

