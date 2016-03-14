angular.module("daniel_app", [])
.controller("mycontroller", ["$scope", "$log", function ($scope, $log) {
    $scope.msg = "這段是從controller的js中塞入的文字";
}]);
