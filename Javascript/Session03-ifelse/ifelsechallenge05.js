// Challenge 5: 
// Create a variable called num. 
// Check if the number is a palindrome (looks the same forward as it does backwards 
// e.g. 1001 or 20202). 

var num = 1201;
var strNum = num.toString();    
var reversedNum = strNum.split("").reverse().join("");
var isPalindrome = strNum === reversedNum;

console.log(isPalindrome ? "The number is a palindrome." : "The number is not a palindrome.");