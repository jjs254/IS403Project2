/* Set mission background to serbia.jpg on list hover */
document.getElementById("3").addEventListener("mouseover", mouseOverAdriatic);
document.getElementById("3").addEventListener("mouseout", mouseOutAdriatic);

function mouseOverAdriatic() {
    document.getElementById("missionBackground").style.backgroundImage = "url('../Content/images/serbia.jpg')";
}

function mouseOutAdriatic() {
    document.getElementById("missionBackground").style.backgroundImage = "url('../Content/images/worldMap.jpg')";
}

/* Set mission background to japan.jpg on list hover */
document.getElementById("1").addEventListener("mouseover", mouseOverJapan);
document.getElementById("1").addEventListener("mouseout", mouseOutJapan);

function mouseOverJapan() {
    document.getElementById("missionBackground").style.backgroundImage = "url('../Content/images/japan.jpg')";
}

function mouseOutJapan() {
    document.getElementById("missionBackground").style.backgroundImage = "url('../Content/images/worldMap.jpg')";
}

/* Set mission background to mexico.jpg on list hover */
document.getElementById("2").addEventListener("mouseover", mouseOverMexico);
document.getElementById("2").addEventListener("mouseout", mouseOutMexico);

function mouseOverMexico() {
    document.getElementById("missionBackground").style.backgroundImage = "url('../Content/images/mexico.jpg')";
}

function mouseOutMexico() {
    document.getElementById("missionBackground").style.backgroundImage = "url('../Content/images/worldMap.jpg')";
}