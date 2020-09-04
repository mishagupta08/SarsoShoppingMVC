function AddProductInCart(ProductCode, Qunatity)
{
    alert("in");
    $.ajax({
        url: '/Shop/AddProductInToCart',        
        type: 'GET',
        async: false,
        data: { ProductCode: ProductCode, Qty: Qunatity }
    }).done(function (result) {        
            $("#cartCount").html(result);                
    }).fail(function (error) {
        alert(error.statusText);
        $(".preloader").hide();
    });

    return false;
}