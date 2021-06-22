
function changeAreYouVaccinatedYes() {
    $("#vaccinatednoblock").hide();
}

function changeAreYouVaccinatedNo() {
    $("#vaccinatednoblock").show();
}

function changeAreYouWillingToGetVaccine() {
    var select = document.getElementById("areyouwillingtogetvaccine");
    var answer = select.options[select.selectedIndex].value;
    if (answer == "Yes") {
        $("#nearestclusterblock").show();
    } else {
        $("#nearestclusterblock").hide();
    }
}