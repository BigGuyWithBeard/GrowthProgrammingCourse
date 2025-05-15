/*
// functions
function greeting() {
    console.log("hello");
}   
greeting();
*/
/*
// arrow functions
const greeting = () => {
    console.log("hello");
}
greeting(); // call the functio
*/
/*
// anonymous functions
const greeting = function() {
    console.log("hello");
}
    */
// comparison https://www.boardinfinity.com/blog/understanding-anonymous-function-in-javascript/#:~:text=Anonymous%20functions%20are%20functions%20defined,are%20assigned%20to%20a%20variable.

/*
// parameters
function greeting(firstName, lastName) {
    return `hello ${firstName} ${lastName}`;
}
let message = greeting('John-Paul', "Smith");
console.log(message); 
*/

// challenges //////////////////////////////////////////////////////////////////////////
var number = 5;

// 1. write a function tht calculates the area of a rectangle
function areaOfRectangle(length, width) {
    return length * width;
}
console.log(`Area = ${areaOfRectangle(number, number * 2)}`);

// 2. create a function that checks if a number i odd or even
function isOddOrEven(number) {
    if (number % 2 === 0) {
        return `${number} is even`;
    } else {
        return `${number} is odd`;
    }
}
console.log(isOddOrEven(number)); 

// 3. you must create two functions, convert the degree in Fahrenheit to Celsius
function fahrenheitToCelsius(fahrenheit) {
    return (fahrenheit - 32) * 5 / 9;
}
number = 32;
console.log(`${number}F =${fahrenheitToCelsius(32)}C`);
    
function celsiusToFahrenheit(celsius) {
    return (celsius * 9 / 5) + 32;
}
console.log(`${number}C =${celsiusToFahrenheit(32)}F`);

// 4. write a function that finds the maximum number in an arry
function findMax(arr) {    
    let max = arr[0];
    for (let i = 1; i < arr.length; i++) {
        if (arr[i] > max) {
            max = arr[i];
        }
    }
    return max;
}
console.log(`Max =${findMax(['blue', 1, 75, 2, 3, 56, 5, -1, 'red'])}`);
