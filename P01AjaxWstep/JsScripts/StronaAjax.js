

$(document).ready(function () {

    $("#btnPolicz").click(function () {

        var liczb1 = $("#txtLiczba1").val();
        var liczb2 = $("#txtLiczba2").val();

        $.ajax({
            method: "GET", // POST, PUT, DELETE
            url: "ObliczeniaAPI.aspx",
            data:
            {
                liczba1: liczb1,
                liczba2: liczb2
            }
        })
            .done(function (msg) {

                $("#txtWynik").val(msg);

            });


    });

});