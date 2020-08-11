$(document).ready(function () {
    $("#SponserID").focusout(function () {
        var id = $("#SponserID").val();
        $(".preloader").show();
        $.ajax({
            url: '/Account/VerifySponsor',
            type: 'GET',
            async:false,
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


    $("#RegistrationForm").on("submit", function () {
        $("#RegisterSubmit").attr("disabled", true);
        $("#UserNo").val(Uniqid());
        //$('#Registerinfo').modal('toggle');
        var formdata = new FormData($("#RegistrationForm")[0]);
        $.ajax({
            url: '/Account/PartialInsertReg',
            type: 'POST',
            dataType: 'json',
            async: false,
            processData: false,
            contentType: false,
            data: formdata,
            success: function (objResponse) {
                $("#RegisterSubmit").attr("disabled", false);
                if (objResponse != null) {
                    alert(objResponse.Message);
                }
                else {
                    alert('Registration Failed Please try again');
                }

                //$('#Registerinfo').modal('toggle');
            },
            error: function (xhr, data) {

                console.log(xhr);
                console.log("Error:", data);
            }
        });
        return false;
    });


    $("#LoginForm").on("submit", function () {
        $("#LoginSubmit").attr("disabled", true);
        $("#UserNo").val(Uniqid());
        $("#LoginError").html("");
        var formdata = new FormData($("#LoginForm")[0]);
        $.ajax({
            url: '/Account/Login',
            type: 'POST',
            dataType: 'json',
            async: false,
            processData: false,
            contentType: false,
            data: formdata,
            success: function (objResponse) {
                $("#LoginSubmit").attr("disabled", false);
                if (objResponse != null && objResponse.Message == "success") {
                    window.location.href = "/Home/Index";
                }
				else{
                    $("#LoginError").html(objResponse.Message);
				}
            },

            error: function (xhr, data) {

                console.log(xhr);
                console.log("Error:", data);
            }

        });
        return false;
    });


    $("#cnfPassword").change(function () {
        var cnfPass = $("#cnfPassword").val();
        var Pass = $("#Password").val();
        if (cnfPass != null && cnfPass != undefined && cnfPass != '') {
            if (Pass != cnfPass) {
                {
                    alert("Password and Confirm Password Not Match");
                }
            }
        }
    }); 

   
});

function Uniqid() {
    var text = "";
    var possible = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

    for (var i = 0; i < 20; i++)
        text += possible.charAt(Math.floor(Math.random() * possible.length));

    return text;
}