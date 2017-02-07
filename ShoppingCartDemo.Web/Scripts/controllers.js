'use strict';

angular.module('app.controllers', [])

    // Path: /
    .controller('HomeCtrl', ['$scope', '$http', '$window', function ($scope, $http, $window) {
        $scope.$root.title = 'Shopping Cart Demo for Serenata Flowers';
        //$scope.$on('$viewContentLoaded', function () {
            //$window.ga('send', 'pageview', { 'page': $location.path(), 'title': $scope.$root.title });
        //});

			$scope.items = [];

			$scope.item = {};

			$scope.sortExpression = "Name";

			function refreshItems(){
				$http.get('/api/cart/').success(function (data) {
					$scope.items = data;
				});
			};

			$scope.addItem = function (item) {
				$http.post('/api/cart/', item).success(function(){
					refreshItems();
				});
				$scope.item = {};
				//$scope.itemForm.$setPristine();
			};
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

    

function CartCtrl($scope, $http) {
			$scope.items = [];

			$scope.item = {};

			$scope.sortExpression = "Name";

			function refreshItems(){
				$http.get('/api/shoppingCart/').success(function (data) {
					$scope.items = data;
				});
			};

			$scope.addItem = function (item) {
				$http.post('/api/shoppingCart/', item).success(function(){
					refreshItems();
				});
				$scope.item = {};
				$scope.itemForm.$setPristine();
			};

			$scope.removeItem = function (id) {
				$http.delete('/api/shoppingCart/'+id).success(function(){
					refreshItems();
				});
			};

			$scope.mySortFunction = function(item) {
				if(isNaN(item[$scope.sortExpression]))
					return item[$scope.sortExpression];
				return parseInt(item[$scope.sortExpression]);
			};

			$scope.totalPrice = function(){
				var total = 0;
					for(count=0;count<$scope.items.length;count++){
						total += $scope.items[count].Price*$scope.items[count].Quantity;
					}
					return total;
			};

			$scope.name=/^[a-zA-Z ]*$/;
		
			$scope.integerval=/^\d*$/;

			refreshItems();
		}