$(document).ready(function () {
    $("#SponserID").click(function () {
        var id = $("#SponserID").val();
        $(".preloader").show();
        $.ajax({
            url: '/Account/VerifySponsor',
            type: 'GET',
            data: { "SponsorId": id },
            success: function (objResponse) {
                if (objResponse != null && objResponse.result == "") {
                    $("#SponserName").html(objResponse.name);
                }
                else {
                    $("#SponsorErrorTxt").html(objResponse.name);
                }
            },
            error: function (xhr, data) {

                console.log(xhr);
                console.log("Error:", data);
            }
        });
    });

    $("form[name=RegistrationForm]").bind('submit', function (e) {
        $("#RegisterSubmit").attr("disabled", true);

        var formdata = new FormData($("#RegistrationForm")[0]);
        $.ajax({
            url: '/Account/PartialInsertReg',
            type: 'POST',
            data: formdata,
            success: function (objResponse) {
                $("#RegisterSubmit").attr("disabled", false);
            },
            error: function (xhr, data) {

                console.log(xhr);
                console.log("Error:", data);
            }
        });
    });
});