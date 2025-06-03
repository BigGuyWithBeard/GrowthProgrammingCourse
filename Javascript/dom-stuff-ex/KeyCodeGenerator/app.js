document.addEventListener("keypress", function (event) {
  document.getElementById("eventKey").innerHTML = "Key: <br/>" + event.key;
  document.getElementById("eventCode").innerHTML = "Code: <br/>" + event.code;
  document.getElementById("eventWhich").innerHTML = "KeyCode: <br/>" + event.keyCode;

  document.getElementById("container").style.display = "block";
});
