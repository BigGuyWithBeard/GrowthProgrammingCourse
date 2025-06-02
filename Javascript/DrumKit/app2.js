const sounds = new Map();
setUpSounds();

hitHandler = (event) => {
  // play the audio object that matches the id of the clicked element
  sounds.get(event.target.id).play();

  return false; // prevent default action
};

setUpToggleButton();
setUpSounds();

// bind elements to event handlers
const drumKitElements = [
  document.getElementById("boom"),
  document.getElementById("hihat"),
  document.getElementById("tom"),
  document.getElementById("openHatF"),
  document.getElementById("boomG"),
  document.getElementById("rideH"),
  document.getElementById("snareJ"),
  document.getElementById("tomK"),
  document.getElementById("tinkL"),

  //,   document.getElementById("crashZ")
];

drumKitElements.forEach((element) => {
  element.addEventListener("click", hitHandler);
});

function setUpToggleButton() {
  toggleButton = document.getElementById("toggleButton");
  helpMessage = document.getElementById("helpMessage");

  toggleButton.addEventListener("click", () => {
    helpMessage.classList.toggle("hidden");
    if (helpMessage.classList.contains("hidden")) {
      toggleButton.textContent = "Show How To";
    } else {
      toggleButton.textContent = "Hide How To";
    }
  });
}

function setUpSounds() {
  sounds.set("boom", new Audio("sounds/boom.wav"));
  sounds.set("clap", new Audio("sounds/clap.wav"));
  sounds.set("hihat", new Audio("sounds/hihat.wav"));
  sounds.set("kick", new Audio("sounds/kick.wav"));
  sounds.set("openhat", new Audio("sounds/openhat.wav"));
  sounds.set("ride", new Audio("sounds/ride.wav"));
  sounds.set("snare", new Audio("sounds/snare.wav"));
  sounds.set("tink", new Audio("sounds/tink.wav"));
  sounds.set("tom", new Audio("sounds/tom.wav"));
}
