
// extract elements to variables
const form = document.getElementById('myForm');

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
