$(function () {

    $(".HideRow").hide();

    $(".HideonClick").on('click', function () {
        var id = $(this).attr("data-HideID");
        $("#" + id).fadeToggle(200);
    });

})