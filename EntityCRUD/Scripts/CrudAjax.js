myapp = {};

myapp.pageLoad = function () {
    "use strict";

    var request = new XMLHttpRequest();
    request.open('GET', '/Order/AjaxListOrder', false);

    request.onload = function () {
        var data,
            i;

        if (this.status >= 200 && this.status < 400) {
            data = JSON.parse(this.response);
            for (i = 0; i < data.length; i++) {
                document.getElementById("container-div").innerHTML += data[i].Description + " - " + moment(data[i].OrderDate).format("MMMM Do YYYY h:mm:ss a") + " - " + data[i].OrderTotal + "<br />";
            }
        } else {
            document.getElementById("container-div").innerHTML += "There was an error loading the orders.";
        }
    }

    request.onerror = function () {
        document.getElementById("container-div").innerHTML += "We couldn't connect to the server. Sorry!"
    }

    request.send();

}
myapp.pageLoad();