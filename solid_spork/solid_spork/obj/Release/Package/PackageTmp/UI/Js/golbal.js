setInterval(hidemsg, 5000);
var ishidden = false;
function hidemsg() {
    if ($("#top-msg").html() != "" && ishidden) {
        ishidden = false;
        $("#top-msg").html("")
    }
    if ($("#top-msg").html() != "") {
        ishidden = true;
    }
}