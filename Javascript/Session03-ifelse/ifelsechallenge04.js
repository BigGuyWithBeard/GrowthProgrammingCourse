// Challenge 4: 
// Create a variable called num. // If num is divisible by 3 log "fizz" to the console, if it's divisible by 5 log "buzz" to the 
// console, if it's divisible by both 3 and 5 log "fizz buzz" to the console. Otherwise log 
// num to the console. 

num = 15;
output = "";

if(num %3 === 0) {
    output+= "Fizz";
}
if(num %5 === 0) {
    if (output.length > 0) {
        output += " ";
    }
    output += "Buzz";
}
if(output === "") {
    output = num;
}
console.log(output);