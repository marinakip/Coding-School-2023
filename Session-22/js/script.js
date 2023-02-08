
/* Help Function for Exercise 1 and 2 */
function reverse(input) {
    let splittedInput = input.split("");
    let reversedArray = splittedInput.reverse();
    let result = reversedArray.join("");
    return result;
}

/* Exercise 1: Reverse String */
function reverseInput() {
    let inputString = document.getElementById("input-reverse").value;
    let reversedInput = reverse(inputString);
    document.getElementById("output-reverse").value = reversedInput;
}

/* Exercise 2: Palindrome Check */
function checkPalindrome() {
    let inputPalindrome = document.getElementById("input-palindrome").value;
    let reversedString = reverse(inputPalindrome);
    if (inputPalindrome == reversedString) {
        document.getElementById("output-palindrome").value = "It is palindrome"
    } else {
        document.getElementById("output-palindrome").value = "It is not palindrome"
    }
}

/* Exercise 3: Customer Details */

// let submitButton = document.getElementById("submit-button");
// submitButton.addEventListener('click', submitDetails());

function submitDetails() {
    let name = document.getElementById("input-name");
    let surname = document.getElementById("input-surname");
    let age = document.getElementById("input-age");
    let gender = getGender();

    testOutput(name, surname, age, gender);
}

function getGender() {
    var selection = document.querySelector('input[name="radio"]:checked').value;
    return selection;
}

function testOutput(name, surname, age, gender) {
    document.getElementById("output-name").value = name;
    document.getElementById("output-surname").value = surname;
    document.getElementById("output-age").value = age;
    setGender(gender);
}

function setGender(gender) {
    switch (gender) {
        case "Male":
            document.getElementById("radio-gender-male-output").checked = true;
            break;
        case "Female":
            document.getElementById("radio-gender-female-output").checked = true;
            break;
        case "Other":
            document.getElementById("radio-gender-other-output").checked = true;
            break;
        default:
            console.error("Invalid selection");
    }
}




/* TODO: TO BE COMPLETED */

/* Exercise 4: Multiplication */
function multiplyInputs() {
    let a = document.getElementById("input-first").value;
    let b = document.getElementById("input-second").value;
    document.getElementById("output-multiply").value = multiply(a, b);

}

function multiply(a, b) {
    // console.log(`First Number is type: ${typeof firstNumber}, Second Number is type: ${typeof secondNumber}`);
    // At the beginning they are undefined so we are going to convert them to number
    firstNumber = Number(a);
    secondNumber = Number(b);

    // We are going to add a check that both these values are numbers, since JS is weakly typed
    if ((typeof firstNumber === "number") && (typeof secondNumber === "number")) {
        // console.log("Both values are numbers proceed multiplication");
        return a * b;
    } else {
        return NaN;
    }
}

/* Exercise 5: Last Character Incrementation */
function incrementString() {
    let stringToIncrement = document.getElementById("input-increment").value;
    let incremantedString = incrementLastCharacter(stringToIncrement);
    document.getElementById("output-increment").value = incremantedString;
}


function incrementLastCharacter(stringToIncrement) {
    let lastCharacter = stringToIncrement.substr(-1);
    lastCharacter = Number(lastCharacter);
    if (lastCharacterIsNaN(lastCharacter)) {
        let newString = `${stringToIncrement}1`
        return newString;
    } else {
        let newLastCharacter = lastCharacter + 1;
        let stringWithoutLastCharacter = stringToIncrement.substring(0, stringToIncrement.length - 1);
        let concatanatedString = `${stringWithoutLastCharacter}${newLastCharacter}`
        return concatanatedString;
    }
}

function lastCharacterIsNaN(character) {
    return isNaN(character);
}

