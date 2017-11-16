$(function () {

    var isAtTopOfPage = $(window).scrollTop() <= 0;

    $(window).scroll(function (event) {
        if ($(window).scrollTop() > 0) {
            isAtTopOfPage = false;
        }
        else {
            isAtTopOfPage = true;
        }
    };


    $('#main-menu').hover(function (event) {
        console.log('Hover');

    }, function (event) {
        console.log('Finish Hover');
    });


    $('#buy-tickets').hover(function (event) {
        console.log('Hover');

    }, function (event) {
        console.log('Finish Hover');
    });
});