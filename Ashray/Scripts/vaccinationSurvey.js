
function changeAreYouVaccinatedYes() {
    $("#vaccinatednoblock").hide();
    $("#persondetailsblock").show();
}

function changeAreYouVaccinatedNo() {
    $("#vaccinatednoblock").show();
    $("#persondetailsblock").hide();
}

function changeAreYouWillingToGetVaccinated() {
    var select = document.getElementById("ddlareyouwillingtogetvaccinated");
    var answer = select.options[select.selectedIndex].value;
    if (answer == "True") {
        $("#nearestclusterblock").show();
    } else {
        $("#nearestclusterblock").hide();
    }
}