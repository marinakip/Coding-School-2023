
/* Help Functions */
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