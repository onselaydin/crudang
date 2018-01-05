var myApp = angular.module('myApp', []);
myApp.controller('employeeCtrl', function ($scope, $http) {

    $scope.employees = "";
    $http.get("/Employee/GetEmployee")
    .success(function (result) {
        $scope.employees = result;
    })
    .error(function (result) {
        console.log(result);
    });

    $scope.savedata=function(employee)
    {
        debugger;
        $http.post("/Employee/SaveEmployee", { _oEmployee: employee })
        .success(function (result) {
            $scope.employees = result;
        })
        .error(function (result) {
            console.log(result);
        })
    }

    $scope.employee = "";
    $scope.selectedEmployee=function(id)
    {
        $http.post("/Employee/GetemployeeByID", { id: id })
        .success(function (result) {
            $scope.employee = result;
        })
        .error(function (result) {
            console.log(result);
        })
    }

    $scope.updateData=function(employee)
    {
        $http.post("/Employee/UpdateData", { _oEmployee: employee })
        .success(function (result) {
            debugger;
            $scope.employees = result;
        })

        .error(function (result) {
            console.log(result);
        });

    }

    $scope.DeleteData=function(id)
    {
        $http.post("/Employee/DeleteData", { ID: id })
        .success(function (result) {
            debugger;
            $scope.employees = result;

        })

        .error(function (result) {
            console.log(result);
        });
    }

});

