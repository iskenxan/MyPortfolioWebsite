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
});


