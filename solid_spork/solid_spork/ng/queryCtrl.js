app.controller('queryCtrl', _queryCtrl);

function _queryCtrl($scope, $http, $rootScope) {
    $rootScope.msg = "";
    $scope._queryFormSubmit = function () {
        //hit query save service ajax      
        var Query = {};
        Query.Query = $scope.query;
        Query.QueryDescription = $scope.queryDescrption;
        var req = {
            method: 'POST', url: '/Query/CreateNewQuery', data: JSON.stringify(Query)
        };
        $http(req).then(function successCallback(response) {
            if (response.data == "0") {
                $rootScope.msg = "Please login...";
            }
            else if (!response.data) {
                $rootScope.msg = "We are unable to process your request.";
            }
            else {
                $scope.query = "";
                $scope.queryDescrption = "";
                $rootScope.msg = "Your query had been created successfully.";
            }
        }, function errorCallback(response) {
            $rootScope.msg = "We are unable to process your request.";
        });
    };
}
