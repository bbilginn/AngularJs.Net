﻿function SanatciController($scope, $http) {

    $http.get("http://localhost:8651/api/values")
    .success(function (data, status, headers, config) {
        $scope.Sanatcilar = data.Data;
    }).error(function (data, status, headers, config) {
        alert(status);
    });

    $scope.YeniSanatci = function () {
        $("form").fadeIn("slow");
    };
    $scope.YeniSanatciIptal = function () {
        $("form").fadeOut("slow");
    };

    $scope.SanatciSil = function (ind) {
        //Post metoddan sonra
        $scope.Sanatcilar.splice(ind, 1);
    };

    $scope.SanatciKaydet = function () {
        //Post metoddan sonra
        if ($scope.Ad.length > 0) {
            $scope.Sanatcilar.push({ Ad: $scope.Ad, Albums: [] });
            FormSifirla();
        }
    };

    function FormSifirla() {
        $scope.Ad = null;
        //$("form").fadeOut("slow");
    }
}