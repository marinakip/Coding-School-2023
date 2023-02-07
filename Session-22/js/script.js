
function reverse(input) {
    let splittedInput = input.split("");
    let reversedArray = splittedInput.reverse();
    let result = reversedArray.join("");
    return result;
}

function reverseInput() {
    let inputString = document.getElementById("input-reverse").value;
    let reversedInput = reverse(inputString);
    document.getElementById("output-reverse").value = reversedInput;
}

function checkPalindrome() {
    let inputPalindrome = document.getElementById("input-palindrome").value;
    let reversedString = reverse(inputPalindrome);
    if (inputPalindrome == reversedString) {
        document.getElementById("output-palindrome").value = "It is palindrome"
    } else {
        document.getElementById("output-palindrome").value = "It is not palindrome"
    }
}