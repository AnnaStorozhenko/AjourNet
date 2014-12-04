function bindLoginValidationHandlers() {
    $("#loginForm .form-control").on("change", function () {
        displayErrorBar();
    });

    $("#Email").on("focusout", function () {
        displayErrorBar();
    });

    $("#loginForm").on("submit", function () {
        displayErrorBar();
    });

    $("#loginForm").on("load", function () {
        displayErrorBar();
    });


    function displayErrorBar() {
        if ($('#loginForm .field-validation-error')) {
            $("#loginErrorBar").show();
        }
        else {
            $("#loginErrorBar").hide();
        }
    }
}