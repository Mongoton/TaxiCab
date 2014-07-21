
(function () {

    var app = angular.module("taxifarecalc", []);
        //.config(function($routeProvider, $locationProvider){
        //    $routeProvider.when('/blah', { templateUrl: 'ngViews/mainpage.html', controller: 'MainController' }).
        //    otherwise({
        //        redirectTo: 'ngViews'
        //    });
        //    $locationProvider.html5Mode(true);
        //});

    
    app.controller("MainController", function ($scope, calculate) {
        calculate.get().then(function(rideInfo) { $scope.rideInfo = rideInfo } );
        //$scope.calculate = function (ride) {
        //};
    });

    var calculate = function () { alert('herpderp')};

    app.factory('calculate', function ($http, $q) {
        return {
            get: function () {
                var deferred = $q.defer();
                $http.get('/').success(deferred.resolve).error(deferred.reject);
                return deferred.promise;
            }
        }
    });

}());