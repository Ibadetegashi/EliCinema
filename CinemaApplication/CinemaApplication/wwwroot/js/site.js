$(function () {

    if ($("a.confirmDeletion").length) {
        $("a.confirmDeletion").click(() => {
            if (!confirm("Confirm deletion")) return false;
        });
    }

    if ($("div.alert.notification").length) {
        setTimeout(() => {
            $("div.alert.notification").fadeOut();
        }, 2000);
    }

});
$(function () {

    if ($("a.confirmAdmin").length) {
        $("a.confirmAdmin").click(() => {
            if (!confirm("Are you sure you want to make this user admin, cause you can not undo anymore")) return false;
        });
    }

    if ($("div.alert.notification").length) {
        setTimeout(() => {
            $("div.alert.notification").fadeOut();
        }, 2000);
    }

});

function readURL(input) {
    if (input.files && input.files[0]) {
        let reader = new FileReader();

        reader.onload = function (e) {
            $("img#imgpreview").attr("src", e.target.result).width(200).height(200);
        };

        reader.readAsDataURL(input.files[0]);
    }
}

$(document).ready(function () {
    $('#myTable').DataTable({
        //"scrollY": "600px",
       // "scrollCollapse": false,
        "paging": true,
       //"columnDefs": [{ "orderable": false, "targets": [4] }],

        "lengthMenu": [[5, 10, 25, 50, -1], [5, 10, 25, 50, "All"]]

    });
});

$(document).ready(function () {
    $('#myUser').DataTable({
        "scrollY": "600px",
        // "scrollCollapse": false,
        "paging": true,
        //"columnDefs": [{ "orderable": false, "targets": [4] }],

        "lengthMenu": [[5, 10, 25, 50, -1], [5, 10, 25, 50, "All"]]

    });
});

$(document).ready(function () {
    $('#myActorTable').DataTable({
        //"scrollY": "600px",
        //"scrollCollapse": true,
        "paging": true,
        "columnDefs": [{ "orderable": false, "targets": [1, 3] }],
        "lengthMenu": [[5, 10, 25, 50, -1], [5, 10, 25, 50, "All"]]


    });
});
$(document).ready(function () {
    $('#myMovieTable').DataTable({
        //"scrollY": "600px",
        //"scrollCollapse": true,
        "paging": true,
        "columnDefs": [{ "orderable": false, "targets": [0, 5] }],
        "lengthMenu": [[5,10, 25, 50, -1], [5,10, 25, 50, "All"]]


    });
});
$(document).ready(function () {
    $('#myGenreTable').DataTable({
        //"scrollY": "600px",
        //"scrollCollapse": true,
        "paging": true,
        "columnDefs": [{ "orderable": false, "targets": [0, 2] }],
        "lengthMenu": [[5, 10, 25, 50, -1], [5, 10, 25, 50, "All"]]


    });
});

$(document).ready(function () {
    $('#myUserTable').DataTable({
        //"scrollY": "600px",
        //"scrollCollapse": true,
        "paging": true,
        "columnDefs": [{ "orderable": false, "targets": [ 3] }],
        "lengthMenu": [[5, 10, 25, 50, -1], [5, 10, 25, 50, "All"]]


    });
});

$(document).ready(function () {
    $('#youOrderTable').DataTable({
        //"scrollY": "600px",
        //"scrollCollapse": true,
        "paging": true,
        "columnDefs": [{ "orderable": false, "targets": [4] }],
        "lengthMenu": [[3,5, 10, 25, 50, -1], [3,5, 10, 25, 50, "All"]]


    });
});