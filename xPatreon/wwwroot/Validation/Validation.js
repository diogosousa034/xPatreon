const form = document.getElementById('form');
const username = document.getElementById('UserNameText');
const email = document.getElementById('EmailText');
const password = document.getElementById('Password');
const confirPassword = document.getElementById('ConfirmPass');


form.addEventListener('submit', e => {
    e.preventDefault();

    validateInputs();
});



const setError = (element, message) => {
    const inputControl = element.parentElement;
    const errorDisplay = inputControl.querySelector('.error');

    errorDisplay.innerText = message;
    inputControl.classList.add('error');
    inputControl.classList.remove('success');
};

const setSuccess = element => {
    const inputControl = element.parentElement;
    const errorDisplay = inputControl.querySelector('.error');

    errorDisplay.innerText = '';
    inputControl.classList.add('success');
    inputControl.classList.remove('error');
};



const validateInputs = () => {
    const usernameValue = username.value.trim();
    const emailValue = email.value.trim();
    const passwordValue = password.value.trim();
    const confirmPassValue = confirPassword.value.trim();

    if (usernameValue === '') {
        setError(username, 'Username  is required');
    }
    else {
        setSuccess(username)
    }

    if (emailValue === '') {
        setError(email, 'Email  is required');
    }
    else {
        setSuccess(email)
    }

    if (passwordValue === '') {
        setError(password, 'Password  is required');
    }
    else {
        setSuccess(password)
    }


    if (confirmPassValue != passwordValue) {
        setError(confirPassword, 'Password and confirm password must be equals');
    }
    else if (confirmPassValue === '') {
        setError(confirPassword, 'Please confirm your passwords');
    }
    else {
        setSuccess(confirPassword)
    }

};