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
audioFiles.set("buttoncall", new Audio("./sounds/tone-ringing.wav")); 
audioFiles.set("error", new Audio("./sounds/tone-error.wav"))
const display = document.getElementById("numberdisplay");

var callInProgress=false;
var callAudio;

function showButtonPress(key){
        document.getElementById(key).classList.add("pressed");
        setTimeout(function(){
            document.getElementById(key).classList.remove("pressed");
        }, 200);     
}

function makeCall(){
   showButtonPress("button-call");
    if(!callInProgress){

        if( display.innerHTML.length < 5){
            // too short
            // play an error noise
            audioFiles.get("error").play();
        }else{
            // cloe enough to a phone number...
            // dial it

            // pick a random dial or busy tone
            if (Math.random()> 0.3){
                callAudio = audioFiles.get("buttoncall");
                display.innerHTML = "Calling...";                
            }else{
                callAudio = audioFiles.get("tone-busy");
                display.innerHTML = "Busy...";                
            }
            callAudio.loop = true;
            callInProgress = true;

            callAudio.play();
        }

    }
}

function stopCall(){
    showButtonPress("button-hangup");

    if(callInProgress){
        callAudio.pause();
        display.innerHTML="";
        callInProgress=false;
    }
}

function buttonPress(key) {

    //animate the button
    showButtonPress(key);

    // add the number to the display
    addNumberToDisplay(key);

    // play the associated audio file
    audioFiles.get(key).play();  

}

function addNumberToDisplay(key){
    var number = key.slice(-1);
    display.innerHTML = display.innerHTML +  number;
}

// attach click event listeners to all elements with the class 'phone-button'
document.querySelectorAll(".phone-button").forEach((element) => {
  switch (element.dataset.key) {
    case "buttoncall":
        element.addEventListener("click", () => {
            makeCall();
        });
        break;
    case "buttonhangup":
        element.addEventListener("click", () => {
            stopCall();
        });        
        break;
    default:
      // these are the numeric buttons
      element.addEventListener("click", () => {
        addNumberToDisplay(element.dataset.key);
        buttonPress(element.dataset.key);
      });
      break;
    }
});

// attach events to key presses
document.addEventListener("keydown", (event) => {

    console.log(event.key);
      switch (event.key) {
        case "Enter":
            makeCall();
            break;
        case "Escape":
            stopCall();
            break;
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
