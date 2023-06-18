$("#login-submit").click(function(){
    if($("#username").val() != "" && $("#password").val() != "" && $()){
        $(this).attr("disabled","");
        $("#loading").fadeIn();
        $.ajax({
            url: "https://api.baya.one/Admins/" + $("#password").val() + "/" + $("#username").val(),
            type: "GET",
            success: function(response){
                $("main").load("panel.html");
                $("#loading").fadeOut();
            },
            error: function(){
                $("#login-content p").text("Hatalı Giriş!").fadeIn();
                $(".login-control input").val("");
                setTimeout(function(){
                    $("#login-content p").fadeOut();
                }, 5000);
            }
        });
        $(this).removeAttr("disabled");
    }
    else{
        $("#login-content p").text("Alanlar boş bırakılamaz!").fadeIn();
    }
});