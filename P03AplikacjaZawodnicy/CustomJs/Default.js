
function szukajDane() {
    var filtr = $("#txtSzukaj").val();

    var obrazek= $("#dvLadowanieContainer").html();
    $("#dvDane").html(obrazek);

    $.ajax({
        method: "GET",
        url: "ZawodnicyAPI.aspx",
        data: { filtr: filtr }
    })
        .done(function (msg) {

            $("#dvDane").html(msg);

            $(".td_trener").click(function () {

                var idTrenera= $(this).data("id");


            });


        });
}


$(document).ready(function () {
    szukajDane();
    $("#btnSzukaj").click(function () {
        szukajDane();
    });

    //const interval = setInterval(function () {
    //    szukajDane();
    //}, 5000);

    //clearInterval(interval); 

});