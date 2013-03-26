<div ng-controller="SanatciController">

    <p>Sayfada {{Sanatcilar.length}} sanatçı bulunmaktadır.</p>

    [<a href="#" ng-click="YeniSanatci()">Yeni Sanatçı</a>]

    <table>
        <tr>
            <th>Ad</th>
            <th>Album</th>
            <th>İşlemler</th>
        </tr>
        <tr ng-repeat="item in Sanatcilar">
            <td style="width:65%">{{item.Ad}}</td>
            <td>{{item.Albums.length}}</td>
            <td><a href="#" ng-click="SanatciDetay(item._id, $index)">Detay</a> | <a href="#" ng-click="SanatciDuzenle(item._id, $index)">Düzenle</a> | <a href="#" ng-click="SanatciSil(item._id, $index)">Sil</a></td>
        </tr>
    </table>


    <form ng-submit="SanatciKaydet()">
        <p><h3>Sanatçı Adı</h3></p>
        <input type="text" ng-model="Ad" /><br>
        <input type="submit" value="Kaydet">
        <input type="button" value="Kapat" ng-click="YeniSanatciIptal()">
    </form>

</div>
