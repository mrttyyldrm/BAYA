$(document).ready(function(){
    $("#loading").fadeOut();
    var category="null",subcategory="null",county,district,street;

    navigator.geolocation.getCurrentPosition(getLocation);
    function getLocation(location){
        $.ajax({
            url: "https://geocode.maps.co/reverse?lat=" + location.coords.latitude+ "&lon=" + location.coords.longitude,
            type: "GET",
            success: function(response){
                if(response.address.neighbourhood != undefined){
                    district = response.address.neighbourhood.replace("Mahallesi","");
                }
                else if(response.address.suburb != undefined){
                    district = response.address.suburb.replace("Mahallesi","");
                }

                county = response.address.town;
                street = response.address.road.replace("Sokağı","Sk.").replace("Caddesi", "");

                $("#location-result").text(district + " Mah. " + street + " Sk. " + county + "/" + "BURSA");
                $("#location-result").fadeIn();
                $("#search-location-btn").hide();
                $("#search-next-btn").show();
            },
            error: function(){
                $("main").load("error.html");
            },
        });
    }

    if(location.href.includes("?step=2")){
        $("#location").show();
        $("#request-navigation .step").removeClass("active");
        $("#request-navigation .step:nth-child(2)").addClass("active");
    }
    else{
        $("#category").show();
    }

    $("article.category").click(function(){
        category = $(this).children("h3").text();
        
        $(".subcategory-group").each(function(){
            if($(this).attr("type") != category){
                $(this).remove();
            }
        }); 
        $("#subcategory").fadeIn();
    });

    $("#category-button").click(function(){
        category = "Enkaz";
        $("#location").fadeIn();
        $("#category").fadeOut();
    });
    
    $(".subcategory").click(function(){
        subcategory = $(this).text();
        $("#location").fadeIn();
        $("#category").fadeOut();
        $("#request-navigation .step").removeClass("active");
        $("#request-navigation .step:nth-child(2)").addClass("active");
    });

    $("#search-next-btn").click(function(){
        $("#loading").fadeIn();
        $.ajax({
            url: "https://api.baya.one/AddAidNotice/AddDataAitNotion",
            type: "POST",
            contentType: "application/json",
            data: JSON.stringify({
                "county": county,
                "districts": district,
                "street": street,
                "categoryname": category,
                "subcategoryname": subcategory,
            }),
            success: function(){
                $("main").load("success.html", function(){
                    $("#loading").fadeOut();
                });
            },
            error: function(){
                $("main").load("error.html", function(){
                    $("#loading").fadeOut();
                });
            },
        });
    });

    $("#search-location-btn").click(function(){
        $("#county").fadeIn();
    });

    $("article.county").click(function(){
        county = $(this).text();
        $("#district").fadeIn(500);
        setTimeout(function(){
            $("#county").fadeOut();
        }, 500);
        $("#request-navigation .step").removeClass("active");
        $("#request-navigation .step:nth-child(3)").addClass("active");
    });

    $("article.district").click(function(){
        district = $(this).text().replace(" Mah.","");
        $("#street").fadeIn(500);
        setTimeout(function(){
            $("#district").fadeOut();
        }, 500);
        $("#request-navigation .step").removeClass("active");
        $("#request-navigation .step:nth-child(4)").addClass("active");
    });

    $("article.street").click(function(){
        street = $(this).text().replace(" Sk.","");
        $("#loading").fadeIn();
        $.ajax({
            url: "https://api.baya.one/AidNotice/AddDataAitNotion",
            type: "POST",
            contentType: "application/json",
            data: JSON.stringify({
                "county": county,
                "districts": district,
                "street": street,
                "categoryname": category,
                "subcategoryname": subcategory,
            }),
            success: function(){
                $("main").load("success.html", function(){
                    $("#loading").fadeOut();
                });
            },
            error: function(){
                $("main").load("error.html", function(){
                    $("#loading").fadeOut();
                });
            },
        });
    });
});