$("#add-submit").click(function(){
    if($("#county").val() != "" && $("#district").val() != "" && $("#street").val() != "" && $("#centername").val() != "" && $("#category").val()){
        $("#loading").fadeIn();
        $.ajax({
            url: "https://geocode.maps.co/search?q=" + $("#district").val().toLowerCase() + "-" + $("#street").val().toLowerCase() + "-" + $("#county").val().toLowerCase() + "-bursa",
            type: "GET",
            success: function(response){
                $.ajax({
                    url: "https://api.baya.one/HelpCenter/AddHelpCenter",
                    type: "POST",
                    contentType: "application/json",
                    data: JSON.stringify({
                        "name": $("#centername").val(),
                        "latidude": response[0].lat,
                        "longitude": response[0].lon,
                        "truth": null,
                        "categoryId": $("#category").val(),
                    }),
                    success: function(){
                        $("#loading").fadeOut();
                        $("#success").fadeIn();
                        setTimeout(function(){
                            $("#success").fadeOut();
                        }, 3000);
                    },
                    error: function(){
                        $("#error").fadeIn();
                        setTimeout(function(){
                            $("#error").fadeOut();
                        }, 3000);
                    },
                });
            },
            error: function(){
        
            }
        });
    }
});