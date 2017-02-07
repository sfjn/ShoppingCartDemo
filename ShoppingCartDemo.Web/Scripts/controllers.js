'use strict';

angular.module('app.controllers', [])

    // Path: /
    .controller('HomeCtrl', ['$scope', '$location', '$window', function ($scope, $location, $window) {
        $scope.$root.title = 'Shopping Cart Demo for Serenata Flowers';
        $scope.$on('$viewContentLoaded', function () {
            $window.ga('send', 'pageview', { 'page': $location.path(), 'title': $scope.$root.title });
        });
    }])

    // Path: /about
    .controller('AboutCtrl', ['$scope', '$location', '$window', function ($scope, $location, $window) {
        $scope.$root.title = 'Shopping Cart Demo for Serenata Flowers | About';
        $scope.$on('$viewContentLoaded', function () {
            $window.ga('send', 'pageview', { 'page': $location.path(), 'title': $scope.$root.title });
        });
    }])

    // Path: /login
    .controller('CartCtrl', ['$scope', '$location', '$window', function ($scope, $window, shoppingData, shared) {
        $scope.items = [];

        $scope.item = {};

        $scope.sortExpression = "Name";


    function refreshItems() {
        shoppingData.getAllItems()
        .then(function (data) {
            $scope.items = data;
        },
        function (errorMessage) {
            assignError(errorMessage);
        });
    };


        $scope.addItem = function (item) {
            shoppingData.addAnItem(item).then(function () {
                refreshItems();
            },
                    function (errorMessage) {
                        assignError(errorMessage);
                    });

            $scope.item = {};
            if ($scope.itemForm != undefined)
                $scope.itemForm.$setPristine();
        };

        $scope.mySortFunction = function (item) {
            if (isNaN(item[$scope.sortExpression]))
                return item[$scope.sortExpression];
            return parseInt(item[$scope.sortExpression]);
        };

        $scope.name = /^[a-zA-Z ]*$/;

        $scope.integerval = /^\d*$/;

        refreshItems();


        $scope.purchase = function () {
            shared.setCartItems($scope.items);
            $window.location.href = "#/checkoutItems";
        };


        $scope.$root.title = 'Shopping Cart Demo for Serenata Flowers | Cart';
        $scope.$on('$viewContentLoaded', function () {
            $window.ga('send', 'pageview', { 'page': $location.path(), 'title': $scope.$root.title });
        });
    }])

    // Path: /error/404
    .controller('Error404Ctrl', ['$scope', '$location', '$window', function ($scope, $location, $window) {
        $scope.$root.title = 'Error 404: Page Not Found';
        $scope.$on('$viewContentLoaded', function () {
            $window.ga('send', 'pageview', { 'page': $location.path(), 'title': $scope.$root.title });
        });
    }]);