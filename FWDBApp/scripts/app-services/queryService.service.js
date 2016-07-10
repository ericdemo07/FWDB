(function () {
    //this file keeps all ajax services 
    angular.module('fwdbApp').factory('QueryService', QueryService);

    QueryService.$inject = ['$http'];

    function QueryService($http) {
        var service = {};
        service.DisplayFrameworkAsList = DisplayFrameworkAsList;

        return service;

        function DisplayFrameworkAsList() {
            var request = $http({
                method: "post",
                url: "/Default/GetFrameworkDetail",
            });
            return request.then(handleSuccess, handleError('Faliure'));
        }
        function handleSuccess(data) {
            response = data.data;
            return response;
        }
        function handleError(error) {
            return function () {
                return
                {
                    success: false
                }
                ;
            };
        }
    }
})();