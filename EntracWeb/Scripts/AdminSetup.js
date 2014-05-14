$(document).ready(function () {

    $('#divCollapsiblePanelTab').click(function () {
        alert("hi");
        $.ajax({
            url: '/AdminSetup/AdminSetup',
            type: 'GET',
            contentType: "application/json; charset=utf-8",
           
            success: function (data) {
                alert("sucess");
               
            }
        })
    });

});