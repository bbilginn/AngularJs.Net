<div ng-controller="ArsivController">

    <p>Film Sayısı : {{Sanatcilar.length}}</p>

    [<a href="#" ng-click="YeniSanatci()">Yeni Sanatçı</a>]

    <table>
        <tr>
            <th>Ad</th>
            <th>Album</th>
            <th>İşlemler</th>
        </tr>
        <tr ng-repeat="item in Sanatcilar">
            <td style="width:65%">{{item.Ad}}</td>
            <td>0</td>
            <td><a href="#" ng-click="SanatciDetay($index)">Detay</a> | <a href="#" ng-click="SanatciDuzenle($index)">Düzenle</a> | <a href="#" ng-click="SanatciSil($index)">Sil</a></td>
        </tr>
    </table>


    <form ng-submit="SanatciKaydet()">
        Ad :
        <input type="text" ng-model="Ad" /><br>
        <input type="submit" value="Kaydet">
        <input type="button" value="Vazgeç" ng-click="YeniSanatciIptal()">
    </form>

</div>
