﻿$(document).ready(function () {
    $("#form1").validate(
        focusInvalid: false,
            txtSupplierEmail: { required: true, email: true },

            txtSupplierEmail: { required: "Please Enter a Registered Email ", email: " Please use the correct email format" },

        },

            form.submit();
        }
    });
});