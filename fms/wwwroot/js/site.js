




$(document).ready(function () {
    $("#myInput").keyup(function () {
        var input, filter, ul, li, a, i, txtValue;
        input = $("#myInput");
        filter = input.val().toUpperCase()
        li = $(".rw");
        a = $(".files");
        for (i = 0; i < li.length; i++) {
           
            txtValue = a[i].innerText;
            if (txtValue.toUpperCase().indexOf(filter) > -1) {
                li[i].style.display = "";
            } else {
                li[i].style.display = "none";
             }
        }
    });



    $("#myInput1").keyup(function () {
        var input, filter, ul, li, a, i, txtValue;
        input = $("#myInput1");
        filter = input.val().toUpperCase()
        li = $(".rw");
        a = $(".users");
        for (i = 0; i < li.length; i++) {

            txtValue = a[i].innerText;
            if (txtValue.toUpperCase().indexOf(filter) > -1) {
                li[i].style.display = "";
            } else {
                li[i].style.display = "none";
            }
        }
    });
});