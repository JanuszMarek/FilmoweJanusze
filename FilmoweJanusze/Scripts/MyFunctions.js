﻿

function UnHide() {
    var x = document.getElementsByName("editcast");
    for (var i = 0; i < x.length; i++) {
        if (x[i].style.display === "none") {
            x[i].style.display = "block";
        }
        else {
            x[i].style.display = "none";
        }
    }
}
