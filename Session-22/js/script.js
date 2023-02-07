function reverse() {
    let input = document.getElementById("input-reverse").value;
    let splittedInput = input.split("");
    let reversedArray = splittedInput.reverse();
    let result = reversedArray.join("");
    document.getElementById("output-reverse").value = result;

}