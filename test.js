
console.log("JavaScript Loaded");
alert("JavaScript Connected");
function filterEvenNumbers(numbers) {
    return numbers.filter(number => number % 2 !== 0);
}

let result = filterEvenNumbers([1, 2, 3, 4, 5, 6]);

console.log(result);


function celsiusToFahrenheit(celsius) {
    return (celsius * 9 / 5) + 32;
}

function fahrenheitToCelsius(fahrenheit) {
    return (fahrenheit - 32) * 5 / 9;
}

console.log("50°C is " + celsiusToFahrenheit(50) + "°F");

console.log("78°F is " + fahrenheitToCelsius(78).toFixed(3) + "°C");



