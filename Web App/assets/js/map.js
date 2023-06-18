$(document).ready(function(){

    var map = L.map('map').setView([40.19743950459321, 29.060427693117518], 14);
    L.tileLayer('https://tile.openstreetmap.org/{z}/{x}/{y}.png', {
        attribution: '&copy; 2023 &middot; <a href="https://maps.omniscale.com/">Omniscale</a> ' +
        '&middot; Map data: <a href="https://www.openstreetmap.org/copyright">OpenStreetMap  (Lizenz:ODbL)</a>'
    }).addTo(map);

    var healthIcon = L.icon({
        iconUrl: 'assets/img/health-marker.svg',
        iconSize:     [53, 76], 
        iconAnchor:   [22, 94],
        popupAnchor:  [-3, -76],
    });
    var boxIcon = L.icon({
        iconUrl: 'assets/img/box-marker.svg',
        iconSize:     [53, 76], 
        iconAnchor:   [22, 94],
        popupAnchor:  [-3, -76],
    });
    var clothesIcon = L.icon({
        iconUrl: 'assets/img/clothes-marker.svg',
        iconSize:     [53, 76], 
        iconAnchor:   [22, 94],
        popupAnchor:  [-3, -76],
    });
    var locationIcon = L.icon({
        iconUrl: 'assets/img/location-marker.svg',
        iconSize:     [53, 76], 
        iconAnchor:   [22, 94],
        popupAnchor:  [-3, -76],
    });
    var yourLocation = L.icon({
        iconUrl: 'assets/img/your-location.svg',
        iconSize:     [30, 53], 
        iconAnchor:   [22, 94],
        popupAnchor:  [-3, -76],
    });

    $.ajax({
        url: "https://api.baya.one/HelpCenter/GetAllHelpCenter",
        type: "GET",
        success: function(response){
            $.each(response, function(i, item){
                if(item.categoryId == 1){
                    L.marker([item.latitude, item.longitude], {icon: clothesIcon}).addTo(map);
                }
                else if(item.categoryId == 2){
                    L.marker([item.latitude, item.longitude], {icon: boxIcon}).addTo(map);
                }
                else if(item.categoryId == 3){
                    L.marker([item.latitude, item.longitude], {icon: healthIcon}).addTo(map);
                }
                else{
                    L.marker([item.latitude, item.longitude], {icon: locationIcon}).addTo(map);
                }
            });
            $("#loading").fadeOut();
        },
        error: function(){
        }
    });

    var isLocated = false;
    $("#map-location").click(function(){
        if(isLocated == false){
            navigator.geolocation.getCurrentPosition(getLocation);
            function getLocation(location){
                L.marker([location.coords.latitude, location.coords.longitude], {icon: yourLocation}).addTo(map);
                map.panTo(new L.LatLng(location.coords.latitude, location.coords.longitude));
            }
            isLocated = true;
        }
    });
});