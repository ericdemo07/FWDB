(function ()
{
    angular.module('fwdbApp', ['ui.router']).config(config);
    console.log("Hello");
    config.$inject = ['$stateProvider', '$urlRouterProvider'];
    //using angular ui router can be expanded for additional states
    function config($stateProvider, $urlRouterProvider)
    {
        $urlRouterProvider.otherwise("/Default/Static");
        
        $stateProvider.state('listAllFrameworks',
		{
		    url: '/Default/Static',
		    templateUrl: '/Default/Index',
		    controllerAs: 'vm'
		})
        .state('listAllFrameworksOnClick', 
		{
			url : '/Default/Ajax',
			controller: 'FrameworkDetailController',
			templateUrl: 'Scripts/FrameworkDetailPage/frameworkDetail.view.html',
			controllerAs : 'vm'
		});
    }
})();