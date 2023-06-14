// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function showAttributes(productId) {
    $.getJSON(`api/Products/${productId}/Attributes`, function (data) {
        $("#product-attribute-tbl>tbody").empty();
        if (data.length == 0) {
            $("#product-attribute-tbl>tbody").append(`<tr><td colspan="4">No Product Attributes Found</td></tr>`);
            return;
        } 
        for (const item of data) {
            $("#product-attribute-tbl>tbody").append(`<tr><td>${item.productAttributeId}</td><td>${item.color}</td><td>${item.width}</td><td>${item.height}</td></tr>`);
        }
       
    })

}