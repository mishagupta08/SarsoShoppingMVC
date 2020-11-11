var SearchProducts;
var ItemList;

$(document).ready(function () {
    if (isUndefinedOrNull(window.sessionStorage.getItem("SCUniqid")) == '') {
        window.sessionStorage.setItem("SCUniqid", Uniqid());
    }

    $("#QuickBuy").click(function () {
        var Product = $("#myInput").val();
        var ProductDetail = $.grep(SearchProducts, function (e) {
            return e.product == Product;
        });
        GetProductQuickView(ProductDetail[0].pcode);
        return false;
    });

});    

function CheckLogin(ProductAddFrom)
{   
    $.ajax({
        url: '/Shop/CheckLogin',
        type: 'GET',
        async: false,
        data: { }
    }).done(function (result) {        
        if (result == 'Yes') {
            getItemCode(ProductAddFrom);
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

function getItemCode(ProductAddFrom) {
    var ProductCode = $('input[name="ProductCode"]').val();
    var Fields = $('select[name="AttributeField"]').val();
    var Quantity = $('input[name="Quantity"]').val();
    $.ajax({
        url: '/Shop/GetItemCode',
        type: 'GET',
        async: false,
        data: { ProductCode: ProductCode, Fields: Fields }
    }).done(function (result) {
        AddProductInCart(ProductCode, Quantity, result, ProductAddFrom);
    }).fail(function (error) {
        alert(error.statusText);
        $(".preloader").hide();
    });
    return false;
}


function AddProductInCart(ProductCode, Quantity, ItemCode, AddProductInCart)
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

         if (AddProductInCart == "QuickBuy")
         {
             GetCartProducts();
             $('#ProductQuickView').modal('toggle');
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
    var mopamt = $("#OrderTotal").val();
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
            var patmparams = 'UniQID:' + UniqId + ',regid:' + ScRegid + ',amount:' + '1' + ',Mobile:' + Mobile + ',shpcharge:' + 0 + ',scmemtype:' + '' + ',email:' + 'support@sarsomail.net' + ',coupon:' + isUndefinedOrNull(null);
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


function GetQuickSearchProducts() {
    $.ajax({
        url: '/Shop/GetQuickSearchProducts',
        type: 'GET',
        async: false,
        data: { Actiontype: 'SCProducts' }
    }).done(function (result) {
        SearchProducts = result;
        ItemList = result.map(a => a.product);
        autocomplete(document.getElementById("myInput"), ItemList);
    }).fail(function (error) {
        alert(error.statusText);
        $(".preloader").hide();
    });
    return false;
}


function autocomplete(inp, arr) {
    /*the autocomplete function takes two arguments,
    the text field element and an array of possible autocompleted values:*/
    var currentFocus;
    /*execute a function when someone writes in the text field:*/
    inp.addEventListener("input", function (e) {
        var a, b, i, val = this.value;
        /*close any already open lists of autocompleted values*/
        closeAllLists();
        if (!val) { return false; }
        currentFocus = -1;
        /*create a DIV element that will contain the items (values):*/
        a = document.createElement("DIV");
        a.setAttribute("id", this.id + "autocomplete-list");
        a.setAttribute("class", "autocomplete-items");
        /*append the DIV element as a child of the autocomplete container:*/
        this.parentNode.appendChild(a);
        /*for each item in the array...*/
        for (i = 0; i < arr.length; i++) {
            /*check if the item starts with the same letters as the text field value:*/
            if (arr[i].toUpperCase().indexOf( val.toUpperCase()) != -1) {
                /*create a DIV element for each matching element:*/
                b = document.createElement("DIV");
                /*make the matching letters bold:*/
                b.innerHTML =  arr[i]  ;
                
                /*insert a input field that will hold the current array item's value:*/
                b.innerHTML += "<input type='hidden' value='" + arr[i] + "'>";
                /*execute a function when someone clicks on the item value (DIV element):*/
                b.addEventListener("click", function (e) {
                    /*insert the value for the autocomplete text field:*/
                    inp.value = this.getElementsByTagName("input")[0].value;
                    /*close the list of autocompleted values,
                    (or any other open lists of autocompleted values:*/
                    closeAllLists();
                });
                a.appendChild(b);
            }
        }
    });
    /*execute a function presses a key on the keyboard:*/
    inp.addEventListener("keydown", function (e) {
        var x = document.getElementById(this.id + "autocomplete-list");
        if (x) x = x.getElementsByTagName("div");
        if (e.keyCode == 40) {
            /*If the arrow DOWN key is pressed,
            increase the currentFocus variable:*/
            currentFocus++;
            /*and and make the current item more visible:*/
            addActive(x);
        } else if (e.keyCode == 38) { //up
            /*If the arrow UP key is pressed,
            decrease the currentFocus variable:*/
            currentFocus--;
            /*and and make the current item more visible:*/
            addActive(x);
        } else if (e.keyCode == 13) {
            /*If the ENTER key is pressed, prevent the form from being submitted,*/
            e.preventDefault();
            if (currentFocus > -1) {
                /*and simulate a click on the "active" item:*/
                if (x) x[currentFocus].click();
            }
        }
    });
    function addActive(x) {
        /*a function to classify an item as "active":*/
        if (!x) return false;
        /*start by removing the "active" class on all items:*/
        removeActive(x);
        if (currentFocus >= x.length) currentFocus = 0;
        if (currentFocus < 0) currentFocus = (x.length - 1);
        /*add class "autocomplete-active":*/
        x[currentFocus].classList.add("autocomplete-active");
    }
    function removeActive(x) {
        /*a function to remove the "active" class from all autocomplete items:*/
        for (var i = 0; i < x.length; i++) {
            x[i].classList.remove("autocomplete-active");
        }
    }
    function closeAllLists(elmnt) {
        /*close all autocomplete lists in the document,
        except the one passed as an argument:*/
        var x = document.getElementsByClassName("autocomplete-items");
        for (var i = 0; i < x.length; i++) {
            if (elmnt != x[i] && elmnt != inp) {
                x[i].parentNode.removeChild(x[i]);
            }
        }
    }
    /*execute a function when someone clicks in the document:*/
    document.addEventListener("click", function (e) {
        closeAllLists(e.target);
    });
}

function GetProductQuickView(ProdID)
{
    $.ajax({
        url: '/Shop/GetProductQuickView',
        type: 'GET',
        async: false,
        data: { ProdID: ProdID}
    }).done(function (result) {
        $("#ProductQuickView").html(result);
        $('#ProductQuickView').modal('toggle');
    }).fail(function (error) {
        alert(error.statusText);
        $(".preloader").hide();
    });
    return false;
}


function DeleteCartProduct(ProdID,ItemCode) {
    var UniqId = window.sessionStorage.getItem("SCUniqid");
    $.ajax({
        url: '/Shop/DeleteCartProduct',
        type: 'GET',
        async: false,
        data: { ProductCode: ProdID, ItemCode: ItemCode, UniqId: UniqId }
    }).done(function (result) {
        GetCartProducts();
    }).fail(function (error) {
        alert(error.statusText);
        $(".preloader").hide();
    });
    return false;
}



