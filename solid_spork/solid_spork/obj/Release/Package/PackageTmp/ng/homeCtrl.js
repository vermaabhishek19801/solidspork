app.controller('homeCtrl', _homeCtrl);

function _homeCtrl($scope, $http, $rootScope) {    
    $rootScope.msg = "";
    $scope.loadFeeds = function () {        
        var searchQuery = {};
        searchQuery.searchText = $scope.searchText;
        var req = {
            method: 'POST', url: '/Home/GetQueries', data: JSON.stringify(searchQuery)
        };
        $http(req).then(function successCallback(response) {            
            if (response.data == "0") {
                $rootScope.msg = "Please login...";
            }
            else if (!response.data) {
                $rootScope.msg = "We are unable to process your request.";
            }
            else {
                $scope.feedData = response.data;
                $rootScope.msg = "";
            }
        }, function errorCallback(response) {
            $rootScope.msg = "We are unable to process your request.";
        });
    };
}
