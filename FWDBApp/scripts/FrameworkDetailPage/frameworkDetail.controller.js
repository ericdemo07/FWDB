(function ()
{
    angular.module('fwdbApp').controller('FrameworkDetailController', FrameworkDetailController);
    FrameworkDetailController.$inject = ['$scope','QueryService'];

    function FrameworkDetailController($scope,QueryService)
    {
        $scope.getFrameworksAsList = function ()
        {
            console.log("Param : [ " + "Doomsday133");
            
            QueryService.DisplayFrameworkAsList().then
            (
			    function (response)
			    {
			        console.log("Response : ["+response);
			    }
            );
        }
    }
})();