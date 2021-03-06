﻿'use strict';

angular.module('app.controllers', [])

    // Path: /
    .controller('HomeCtrl',
    [
        '$scope', '$http', '$window', function($scope, $http, $window) {
            $scope.$root.title = 'Shopping Cart Demo for Serenata Flowers';

            $scope.cart = [];
            $scope.items = [];

            $scope.addItem = function(item) {
                $http.post('/api/cart/', item)
                    .success(function() {
                        $window.location.href = '/cart';
                    });
                $scope.item = {};
            };

            $scope.removeItem = function(id) {
                $http.delete('/api/cart/' + id)
                    .success(function() {
                        refreshCart();
                    });
            };

            $scope.sortExpression = "Name";

            function refreshCart() {
                $http.get('/api/cart/')
                    .success(function(data) {
                        $scope.cart = data;
                    });
            };

            function refreshItems() {
                $http.get('/api/product/')
                    .success(function(data) {
                        $scope.items = data;
                    });
            };

            refreshCart();
            refreshItems();

        }
    ]);
