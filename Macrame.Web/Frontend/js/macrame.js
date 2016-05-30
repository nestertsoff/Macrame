$(document).ready(function() {
    var categoryTextBox = $("input.category-control");
    var categoryInputGroup = categoryTextBox.parent().parent();
    var categoryHtml = '<span class="label label-default">%CONTENT%</span>';
    var $categoryAddBtn = $(".category-add-btn");
    $categoryAddBtn.on("click", function() {
        alert("g");
        if (categoryTextBox.text !== "") {
            categoryInputGroup.append(categoryHtml.replace("%CONTENT%", categoryTextBox.text));
        }
    });
});

$(".panel >>").keypress(function(e) {
    var $backColor = $(this).css("background-color");
    $(this).css("background-color", "yellow");
}, function() {
    var $backColor = $(this).css("background-color");
    $(this).css("background-color", "yellow");
});