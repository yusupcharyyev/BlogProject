
    // id al
    var modal = document.getElementById('id01');

    // modal açıksa kapat
    window.onclick = function (event) {
        if (event.target == modal) {
        modal.style.display = "none";
        }
}

$("input[data-limit-input]").keyup(function () {
    var charLength = $(this).val().length;
    var charLimit = $(this).attr("data-limit-input");
    // Displays count
    $(this).next("span").html(charLength + " ile " + charLimit + " karakter arası giriniz");
    // Alert when max is reached
    if ($(this).val().length > charLimit) {
        $(this).next("span").html("<strong>En fazla " + charLimit + " karakter giriniz.</strong>");
    }
});

$("textarea[data-limit-input]").keyup(function () {
    var charLength = $(this).val().length;
    var charLimit = $(this).attr("data-limit-input");
    // Displays count
    $(this).next("span").html(charLength + " ile " + charLimit + " karakter arası giriniz");
    // Alert when max is reached
    if ($(this).val().length > charLimit) {
        $(this).next("span").html("<strong>En fazla " + charLimit + " karakter giriniz.</strong>");
    }
});