// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$("#getEmployeesBtn").on('click', function (event) {
    event.preventDefault();
    $("#thanks").hide();
    $(this).hide();
    $("#loadingGif").show();
    $.ajax({
        type: "GET",
        url: "/Home/ViewEmployees",
        async: true,
        data:
        {
        },

        dataFilter: function (data) { return data; },
        success: function (data) {
            if (!data.result) {
                $("#divEmployeeList").html(data);
            } else {
                alert(data.rsltMsg);
            }
        },
        error: function (xhr, textStatus, errorThrown) {
        },
        complete: function () {
            $("#loadingGif").hide();
        }
    });
});


$(".clsEmployeeTr").click(function (event) {
    event.preventDefault();
    var employeeId = $(this).find(".clsEmployeeIdTd").html();
    $("#divEmployeeList").hide();
    $("#loadingGif").show();
    $.ajax({
        type: "GET",
        url: "/Home/ViewEmployee",
        async: true,
        data:
        {
            id: employeeId
        },

        dataFilter: function (data) { return data; },
        success: function (data) {
            if (!data.result) {
                $("#divEmployee").html(data);
            } else {
                alert(data.rsltMsg);
            }
        },
        error: function (xhr, textStatus, errorThrown) {
        },
        complete: function () {
            $("#loadingGif").hide();
        }
    });
});

$("#backBtn").click(function (event) {
    $("#divEmployeeList").show();
    $("#divEmployee").html("");
});