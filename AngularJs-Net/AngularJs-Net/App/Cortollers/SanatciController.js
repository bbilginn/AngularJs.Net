﻿function SanatciController($scope, $http) {

    $http.get("http://localhost:8651/api/values")
    .success(function (data, status, headers, config) {
        $scope.Sanatcilar = data.Data;
    }).error(function (data, status, headers, config) {
        alert(status);
    });

    $scope.SanatciSil = function (id, index) {
        $http.delete("http://localhost:8651/api/values/" + id)
        .success(function (data, status, headers, config) {
            $scope.Sanatcilar.splice(index, 1);
        }).error(function (data, status, headers, config) {
            alert(status);
        });
    };

    $scope.SanatciKaydet = function () {
        //Post metoddan sonra
        if ($scope.Ad.length > 0) {
            $http.post("http://localhost:8651/api/values", { Ad: $scope.Ad, Albums: [] })
            .success(function (data, status, headers, config) {
                $scope.Sanatcilar.push({ Ad: $scope.Ad, Albums: [] });
                FormSifirla();
            }).error(function (data, status, headers, config) {
                alert(status);
            });
        }
    };

    $scope.YeniSanatci = function () {
        $("form").fadeIn("slow");
    };
    $scope.YeniSanatciIptal = function () {
        $("form").fadeOut("slow");
    };
    function FormSifirla() {
        $scope.Ad = null;
        //$("form").fadeOut("slow");
    }
}