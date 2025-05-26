const form = document.getElementById('myForm');
const userInput = document.getElementById('username');
const submitButton = document.getElementById('submit');
const userName = document.getElementById('username');
const passwordInput = document.getElementById('password');

// add event listeners
document.getElementById('open-new-tab').addEventListener('click', function() {
    openNewWindow();
});
form.addEventListener('submit', function(event) {
    submitForm(event);
});
userInput.addEventListener('input', function() {
    validateUserName();
});
passwordInput.addEventListener('input', function() {
    validatePassword();
});


// event handlers:
function submitForm(event){
    if(!form.checkValidity()) {
        event.preventDefault();
        form.reportValidity();
    }else{
        alert("form submitted");
        clearInputs();
    }
}
function disableSubmitToggle(){

    if(form.checkValidity()){;
        submitButton.removeAttribute('disabled');   
    }else{
        submitButton.setAttribute('disabled', true);    
    }   
}
function validateUserName() {
        if(userInput.value.length < 3){
        userInput.setCustomValidity('too short... 3 characters minimum. Gimmme MORE!');
    } else {
        userInput.setCustomValidity('');
    }
    userInput.reportValidity();
    disableSubmitToggle();
};
function validatePassword() {
    if(passwordInput.value.length < 6){
        passwordInput.setCustomValidity('Password is too short. 6 characters minimum. Gimmme MORE!');
    } else {
        passwordInput.setCustomValidity('');
    }
    passwordInput.reportValidity();
    disableSubmitToggle();  
}
function clearInputs() {
    userInput.value = '';
    passwordInput.value = '';
    disableSubmitToggle();
}

// other functions
function openNewWindow(){

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
};

