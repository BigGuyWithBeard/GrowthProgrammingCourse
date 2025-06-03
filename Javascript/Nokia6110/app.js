// create audio objects, store them in a keyed collection:
const audioFiles = new Map();
audioFiles.set("button0", new Audio("./sounds/DTMF0.wav"));
audioFiles.set("button1", new Audio("./sounds/DTMF1.wav"));
audioFiles.set("button2", new Audio("./sounds/DTMF2.wav"));
audioFiles.set("button3", new Audio("./sounds/DTMF3.wav"));
audioFiles.set("button4", new Audio("./sounds/DTMF4.wav"));
audioFiles.set("button5", new Audio("./sounds/DTMF5.wav"));   
audioFiles.set("button6", new Audio("./sounds/DTMF6.wav"));
audioFiles.set("button7", new Audio("./sounds/DTMF7.wav"));   
audioFiles.set("button8", new Audio("./sounds/DTMF8.wav"));   
audioFiles.set("button9", new Audio("./sounds/DTMF9.wav"));
audioFiles.set("tone-busy", new Audio("./sounds/tone-busy.wav"));
audioFiles.set("tone-ringing", new Audio("./sounds/tone-ringing.wav")); 



function buttonPress(key) {
  

    console.log("Button pressed: " + key);

    // play the audio and do the animation
    audioFiles.get(key).play();

    //'bump' the button
    document.getElementById(key).classList.add("pressed");

    setTimeout(function(){
        document.getElementById(key).classList.remove("pressed");
    }, 200);

}

// attach event listeners to all elements with the class 'phone-button'
document.querySelectorAll(".phone-button").forEach((element) => {
  switch (element.dataset.key) {
    /*
  case x:
    // code block
    break;
  case y:
    // code block
    break;
    */
    default:
      // use the audio object matching the data-key attribute.
      element.addEventListener("click", () => {
        buttonPress(element.dataset.key);
      });
  }

});

// attach events to key presses
document.addEventListener("keydown", (event) => {


// check if the pressed key is a number or a specific key
      switch (event.key) {
    /*
  case x:
    // code block
    break;
  case y:
    // code block
    break;
    */
        case "0":
        case "1":
        case "2":
        case "3":
        case "4":
        case "5":
        case "6":
        case "7":
        case "8":
        case "9":
            // if the key is a number, play the corresponding audio file
            buttonPress("button" + event.key);
            break;
  }



});
