var app = angular.module("IndexApp", []);

app.controller("CarroesController", ($scope, $http) => {
    $http({
        method: "get",
        url: "/Carroes/BuscaDados"
    }).then((dados) => {
        $scope.lista = dados.data;
    });
    $scope.EnviaDados = () => {
        $http({
            method:"POST",
            url: "/Carroes/Add",
            data: $scope.dados
        }).then(function (d) {
            //alert(d.data);
            window.location.reload();
        });
    };
});