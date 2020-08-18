// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$("#getEmployeesBtn").on('click', function (event) {
    event.preventDefault();

    $.ajax({
        type: "POST",
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

        }
    });
});