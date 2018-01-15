$(document).ready(function () {

    //Scroll the page to the content on the pointer click
    $(".scroll-down-pointer").click(function () {
        $('html,body').animate({
            scrollTop: $(".body-inner-container").offset().top
        },
            'slow');
    });
});
