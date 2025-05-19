const form = document.getElementById('myForm');

let userInput = document.getElementById('username');
let submitButton = document.getElementById('submit');
let userName = document.getElementById('username');


form.addEventListener('submit', function(event) {
    // reinstate the default action of the form submission handler
    if(!form.checkValidity()) {
        event.preventDefault();
        form.reportValidity();
    }else{
        alert("form submitted");
        clearInputs();
    }
});

function disableSubmitToggle(){

    if(form.checkValidity()){;
        submitButton.removeAttribute('disabled');   
    }else{
        submitButton.setAttribute('disabled', true);    
    }   
}

userInput.addEventListener('input', function() {
    if(userInput.value.length < 3){
        userInput.setCustomValidity('too short... 3 characters minimum. Gimmme MORE!');
    } else {
        userInput.setCustomValidity('');
    }
    userInput.reportValidity();
    disableSubmitToggle();
});


let passwordInput = document.getElementById('password');
passwordInput.addEventListener('input', function() {
    if(passwordInput.value.length < 6){
        passwordInput.setCustomValidity('Password is too short. 6 characters minimum. Gimmme MORE!');
    } else {
        passwordInput.setCustomValidity('');
    }
    passwordInput.reportValidity();
    disableSubmitToggle();  
});


document.getElementById('open-new-tab').addEventListener('click', function() {

    let message = !userName.value ? 'no user name': 'Hello ' + userName.value + '!';
    let newWindow = window.open('', '_blank');
    newWindow.document.write(`
        <!DOCTYPE html>
        <html>
            <head>
                <meta charset="UTF-8">
                <meta name="viewport" content="width=device-width, initial-scale=1.0"></meta>
                <link href="./main.css" rel="stylesheet">
                <title>Form Output</title>
            </head>
            <body>
                <div class="container">
                    <h1>Welcome</h1>
                    <p>User Name: ${message}</p>
                </div>
            </body>
        </html>
    `);
    newWindow.focus();
    newWindow.document.close();
});


    
    
function clearInputs() {
    userInput.value = '';
    passwordInput.value = '';
    disableSubmitToggle();
}