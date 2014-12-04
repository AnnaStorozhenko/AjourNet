src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.1/jquery.min.js"
src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.1/js/bootstrap.min.js"
  type="text/javascript"

      $(document).ready(function () {
       $("#myModal").modal('show');
       $("#CreateUserProfile").click(function (event) {
           event.preventDefault();
           $("#createProfileForm").validate();
           if ($("#createProfileForm").valid()) {
               createEmp = $('#createProfileForm').serialize();
               $.ajax({
                   type: "POST",
                   url: "/UserProfile/CreateUserProfile",
                   data: createEmp,
                   success: function (data) {
                       if (data.error) {
                           $("#ModelError").html(data.error);
                       }
                       else {
                           $(dialogEmpCreate).dialog("close");
                       }
                   },
                   error: function (data) {
                       alert('Server not responding');
                   }
               });
           }
       },
        function (event, ui) {
            $(this).dialog("destroy");
            $(this).remove();

        });
       $.validator.unobtrusive.parse(this);
   });

