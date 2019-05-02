function calculatePrice() {
    var productPrice = parseInt(document.getElementById('product').value);
    var salesTax = 5; //Default Price for Sales Tax
    var finalPrice = productPrice + salesTax;
    document.getElementById('price').innerHTML = finalPrice;
}