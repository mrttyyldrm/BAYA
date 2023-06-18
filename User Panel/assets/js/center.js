$.ajax({
    url: "https://api.baya.one/HelpCenter/GetAllHelpCenter",
    type: "GET",
    success: function(response){
        $("#loading").fadeOut();
        $.each(response, function(i, location){
            if(i == 0){
                $(".center").attr("data", location.id);
                
                if(location.categoryId == 1){
                    $(".center").find(".center-icon img").attr("src","assets/img/clothes.svg");
                }
                else if(location.categoryId == 2){
                    $(".center").find(".center-icon img").attr("src","assets/img/box.svg");
                }
                else if(location.categoryId == 3){
                    $(".center").find(".center-icon img").attr("src","assets/img/health.svg");
                }
                else{
                    $(".center").find(".center-icon img").attr("src","assets/img/location.svg");
                }

                $(".center").find(".center-text").children("h3").text(location.name);
                $(".center").find(".center-buttons").children("a").attr("href","https://maps.google.com/maps?q=" + location.latitude + "," + location.longitude);
                $(".center").find(".center-buttons #delete").attr("onclick","deleteCenter(" + location.id +");")
            }
            else{
                var newCenter = $(".center").first().clone();
                newCenter.attr("data", location.id);
                if(location.categoryId == 1){
                    newCenter.find(".center-icon img").attr("src","assets/img/clothes.svg");
                }
                else if(location.categoryId == 2){
                    newCenter.find(".center-icon img").attr("src","assets/img/box.svg");
                }
                else if(location.categoryId == 3){
                    newCenter.find(".center-icon img").attr("src","assets/img/health.svg");;
                }
                else{
                    newCenter.find(".center-icon img").attr("src","assets/img/location.svg");
                }
                newCenter.find(".center-text").children("h3").text(location.name);
                newCenter.find(".center-buttons").children("a").attr("href","https://maps.google.com/maps?q=" + location.latitude + "," + location.longitude);
                newCenter.find(".center-buttons #delete").attr("onclick","deleteCenter(" + location.id +");")
                
                $("#center-content").append(newCenter);
            }
        });
    },
    error: function(){
    }
});

function deleteCenter(id){
    $("#loading").fadeOut();
    $.ajax({
        url: "https://api.baya.one/HelpCenter/DeleteHelpCenter/" + id,
        type: "GET",
        success: function(response){
            $("main").load("panel.html");
            $("#loading").fadeOut();
            $("#success").fadeIn();
            setTimeout(function(){
                $("#success").fadeIn();
            },3000);
        },
        error: function(){
            $("#loading").fadeOut();
            $("#error").fadeIn();
            setTimeout(function(){
                $("#error").fadeIn();
            },3000);
        }
    });
}

$("#add-center-btn").click(function(){
    $("#panel-content").load("add.html");
});