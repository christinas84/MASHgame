$(document).ready(function(){
    $(".container2").hide();
        $(".container3").hide();
        $("#play").click(function () {
            $(".container").hide();
            $(".container1").hide();
            $(".container2").show();
        });
        $("#fortune").click(function () {
            $(".container2").hide();
            $(".container3").show();
        });
        //$('#reset').click(function () {
        //    location.reload();
        //});
    });