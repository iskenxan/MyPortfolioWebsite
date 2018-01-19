$(document).ready(function () {

    //Scroll the page to the content on the pointer click
    $(".scroll-down-pointer").click(function () {
        $('html,body').animate({
            scrollTop: $(".body-inner-container").offset().top
        },
            'slow');
    });

    $(".project-container").mouseover(function () {
        $(this).find(".project-info-container").css("display", "block");
        $(this).find(".project-overlay").css("background", "rgba(0,0,0,0.97)");
    });

    $(".project-container").mouseout(function () {
        $(this).find(".project-info-container").css("display", "none");
        $(this).find(".project-overlay").css("background", "transparent");
    });

    var target = $(".top-content-bottom").offset().top;
    $(window).scroll(function (event) {
        var scroll = $(window).scrollTop();
        if (scroll >= (target+200)) {
            $("#review-btn-sticky").css("display", "inline-block");
        }
        else {
            $("#review-btn-sticky").css("display", "none");
        }
    });



    $("#rating1").click(function () {
        var whiteIcon = "/Content/Images/star_icon_white.png";
        var yellow = "/Content/Images/star_icon.png";

        $("#rating1").attr("src", yellow);
        $("#rating2").attr("src", whiteIcon);
        $("#rating3").attr("src", whiteIcon);
        $("#rating4").attr("src", whiteIcon);
        $("#rating5").attr("src", whiteIcon);
    });

    $("#rating2").click(function () {
        var whiteIcon = "/Content/Images/star_icon_white.png";
        var yellow = "/Content/Images/star_icon.png";

        $("#rating1").attr("src", yellow);
        $("#rating2").attr("src", yellow);
        $("#rating3").attr("src", whiteIcon);
        $("#rating4").attr("src", whiteIcon);
        $("#rating5").attr("src", whiteIcon);
    });

    $("#rating3").click(function () {
        var whiteIcon = "/Content/Images/star_icon_white.png";
        var yellow = "/Content/Images/star_icon.png";

        $("#rating1").attr("src", yellow);
        $("#rating2").attr("src", yellow);
        $("#rating3").attr("src", yellow);
        $("#rating4").attr("src", whiteIcon);
        $("#rating5").attr("src", whiteIcon);
    });

    $("#rating4").click(function () {
        var whiteIcon = "/Content/Images/star_icon_white.png";
        var yellow = "/Content/Images/star_icon.png";

        $("#rating1").attr("src", yellow);
        $("#rating2").attr("src", yellow);
        $("#rating3").attr("src", yellow);
        $("#rating4").attr("src", yellow);
        $("#rating5").attr("src", whiteIcon);
    });

    $("#rating5").click(function () {
        var whiteIcon = "/Content/Images/star_icon_white.png";
        var yellow = "/Content/Images/star_icon.png";

        $("#rating1").attr("src", yellow);
        $("#rating2").attr("src", yellow);
        $("#rating3").attr("src", yellow);
        $("#rating4").attr("src", yellow);
        $("#rating5").attr("src", yellow);
    });
});


