function ArsivController($scope) {

    $scope.Sanatcilar = [];

    $scope.YeniSanatci = function () {
        $("form").show();
    };
    $scope.YeniSanatciIptal = function () {
        $("form").hide();
    };

    $scope.SanatciSil = function (ind) {
        //Post metoddan sonra
        $scope.Sanatcilar.splice(ind, 1);
    };

    $scope.SanatciKaydet = function () {
        //Post metoddan sonra
        $scope.Sanatcilar.push({ Ad: $scope.Ad });
        FormSifirla();
    };

    function FormSifirla() {
        $scope.Ad = null;
        $("form").hide();
    }
}
