/*
const list = document.getElementsByTagName("li");
const rainbow = ["red", "orange", "yellow", "green", "blue", "indigo", "violet"];

for(i=0; i < list.length; i++) {
    list[i].style.color = rainbow[i % rainbow.length];
}
*/

const listEven = document.querySelectorAll("li:nth-child(even)");
for(i=0; i < listEven.length; i++) {
    listEven[i].style.color = "lightgreen";
}   