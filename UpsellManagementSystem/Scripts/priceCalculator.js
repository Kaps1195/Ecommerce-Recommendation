function calculatePrice() {
    var productPrice = document.getElementById('product').value;
    var salesTax = 5; //Default Price for Sales Tax
    var finalPrice = productPrice + salesTax;
    document.getElementById("price").innerHTML = "<p>" + finalPrice + "</p>";
}