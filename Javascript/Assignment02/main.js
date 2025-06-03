
// extract elements to variables
const form = document.getElementById('myForm');

//attach an event handler for help button clicks
document.getElementById('help').addEventListener('click', () => {
    //create a new window with some really helpful information.
    const helpWindow = window.open('', 'Help', 'width=400,height=300');
    helpWindow.document.write('<h1>Help Information</h1>');
    helpWindow.document.write('<p>This form collects your name, age, and a message.</p>');
    helpWindow.document.write('<p>Please fill out all fields before submitting.</p>');

});

// attach an event handler to submit on the form
form.addEventListener('submit', (event) => submitForm(event));

// event handlers:
function submitForm(event){

    // prevent submission as everything will be handled by the javascript
    event.preventDefault();

    if(form.checkValidity()) {
        // form is valid, display the data
        document.getElementById('nameDisplay').innerHTML = document.getElementById('name').value;
        document.getElementById('ageDisplay').innerHTML = document.getElementById('age').value;
        document.getElementById('messageDisplay').innerHTML = document.getElementById('message').value;
        document.getElementById("formContainer").style.display="none";
        document.getElementById("displayContainer").style.display="block";
    }else{
        // form is invalid
        form.reportValidity();
    }
 
function writeWelcomeMessage(){
    alert("Welcome to the page");
    document.write("<h1>Welcome to the page</h1>");
}
}


//TODO add some explicit document.write calls
//TODO Validate name
//TODO validate age
//TODO validate message
