// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.
function hymn(button) {
    var h = document.getElementById(button.id).value;
    if (h % 1 > 0) {
        var input = "error" + button.id;
        document.getElementById(button.id).value = "";
        document.getElementById(input).innerHTML = "That is not an valid hymn number";
    } else {
        var input = "hymn" + button.id;
        var e = "error" + button.id;
        document.getElementById(e).innerHTML = "";

        var xhr = new XMLHttpRequest();
        xhr.open("GET", "https://raw.githubusercontent.com/pseudosavant/LDSHymns/master/hymns.json", true);
        xhr.send();

        xhr.addEventListener("readystatechange", processRequest, false);

        function processRequest(x) {
            if (xhr.readyState == 4 && xhr.status == 200) {
                var notify = JSON.parse(xhr.responseText);
                document.getElementById(input).value = notify[h].name;

            }
        }
    }
}
