$(document).ready(function () {
    if (isUndefinedOrNull(window.sessionStorage.getItem("SCUniqid")) == '') {
        window.sessionStorage.setItem("SCUniqid", Uniqid());
    }
});

    

function CheckLogin()
{   
    $.ajax({
        url: '/Shop/CheckLogin',
        type: 'GET',
        async: false,
        data: { }
    }).done(function (result) {        
        if (result == 'Yes') {
            getItemCode();
        }
        else {
            $("#LoginPopUp").modal();            
        }
    }).fail(function (error) {
        alert(error.statusText);
        $(".preloader").hide();
    });
    return false;
}

function getItemCode() {
    var ProductCode = $('input[name="ProductCode"]').val();
    var Fields = $('select[name="AttributeField"]').val();
    var Quantity = $('input[name="Quantity"]').val();
    $.ajax({
        url: '/Shop/GetItemCode',
        type: 'GET',
        async: false,
        data: { ProductCode: ProductCode, Fields: Fields }
    }).done(function (result) {
        AddProductInCart(ProductCode, Quantity, result);
    }).fail(function (error) {
        alert(error.statusText);
        $(".preloader").hide();
    });
    return false;
}


function AddProductInCart(ProductCode, Quantity, ItemCode)
{
    var UniqId = window.sessionStorage.getItem("SCUniqid");

    $.ajax({
        url: '/Shop/AddProductInToCart',        
        type: 'GET',
        async: false,
        data: { ProductCode: ProductCode, Qty: Quantity, ItemCode: ItemCode, UniqId: UniqId }
    }).done(function (Message) {
       var res = Message.split("-");
         if (res[0] == "") {
            alert("Added Successfully");
        }
        else {
            alert(res[0]);
        }
        $("#cartCount").html(res[1]);
    }).fail(function (error) {
        alert(error.statusText);
        $(".preloader").hide();
    });
    return false;
}

function GetCartProducts()
{
    var UniqId = window.sessionStorage.getItem("SCUniqid"); 
    var ScRegid = window.sessionStorage.getItem("ScRegid");

    $.ajax({
        url: '/Shop/CartProducts',
        type: 'GET',
        async: false,
        data: { Actiontype: 'Rpt', UNQId: UniqId, ScRegid: ScRegid }
    }).done(function (result) {
        $("#cartProducts").html(result);
    }).fail(function (error) {
        alert(error.statusText);
        $(".preloader").hide();
    });
    return false;
}


function GetOrderProducts() {
    var UniqId = window.sessionStorage.getItem("SCUniqid");
    var ScRegid = window.sessionStorage.getItem("ScRegid");

    $.ajax({
        url: '/Shop/OrderProducts',
        type: 'GET',
        async: false,
        data: { Actiontype: 'Rpt', UNQId: UniqId, ScRegid: ScRegid }
    }).done(function (result) {
        $("#OrderInfo").html(result);
    }).fail(function (error) {
        alert(error.statusText);
        $(".preloader").hide();
    });
    return false;
}


function CheckOut()
{
   
    var UniqId = window.sessionStorage.getItem("SCUniqid");
    var ScRegid = window.sessionStorage.getItem("ScRegid");
    var mop = "PaytmOnLine";
    var mopamt = 1;//$("#inputamt").val();
    var Fname = $("#inputfname").val();
    var LName= $("#inputlname").val();
    var Mobile = $("#inputphone").val();
    var Address= $("#inputaddress").val();
    var City= $("#inputcity").val();
    var District= $("#inputdistrict").val();
    var state = $("#inputstate").val();
    var PiCode = $("#inputpostcode").val();


    $.ajax({
        url: '/Shop/PlaceOrder',
        type: 'POST',
        async: false,
        data: {
            UNQId: UniqId,
            regid: ScRegid,
            downlineid: "",
            mop:mop,
            mopamt: mopamt,
            Fname: Fname,
            LName: LName,
            Mobile: Mobile,
            Address: Address,
            City: City,
            District: District,
            state: state,
            PiCode: PiCode
        }
    }).done(function (response) {
        var scorderresult = response;
        if (parseInt(scorderresult) > 0) {
            var patmparams = 'UniQID:' + UniqId + ',regid:' + ScRegid + ',amount:' + mopamt + ',Mobile:' + Mobile + ',shpcharge:' + 0 + ',scmemtype:' + '' + ',email:' + 'support@sarsomail.net' + ',coupon:' + isUndefinedOrNull(null);
            postwithCode('_self', 'payPaytm', patmparams);
        }
    }).fail(function (error) {
        alert(error.statusText);
        $(".preloader").hide();
    });
    return false;
}


function postwithCode(tar, to, p) {
    var myForm = document.createElement("form");
    myForm.method = "post";
    myForm.target = tar;
    myForm.action = to;
    var arr = p.split(",");
    for (var i = 0; i < arr.length; i++) {
        var inArr = arr[i];
        var secArr = inArr.split(":");
        var myInput = document.createElement("input");
        myInput.setAttribute("name", replaceAll(secArr[0].replace("{", ""), "'", ""));
        myInput.setAttribute("value", replaceAll(secArr[1].replace("}", ""), "'", ""));
        myForm.appendChild(myInput);
    }
    document.body.appendChild(myForm);
    myForm.submit();
    document.body.removeChild(myForm);
}
