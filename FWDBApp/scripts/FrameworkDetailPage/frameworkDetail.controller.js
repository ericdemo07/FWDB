(function () {
    angular.module('fwdbApp').controller('FrameworkDetailController', FrameworkDetailController);
    FrameworkDetailController.$inject = ['$scope', 'QueryService'];

    function FrameworkDetailController($scope, QueryService) {
        $scope.getFrameworksAsList = function () {
            QueryService.DisplayFrameworkAsList().then
            (
			    function (response) {
			        $scope.frameworkResponseList = response;
			        //collects header for the table
			        $scope.keyRing = Object.keys(response[0]);
			    }
            );
        }
    }
})();