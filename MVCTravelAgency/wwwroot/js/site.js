//Show name after choose image

$(document).ready(function () {
    $(".custom-file-input").on("load", function () {
        var fileName = $(this).val().split("\\").pop();
        $(this).next(".custom-file-label").html(fileName);
    })
});

