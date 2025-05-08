let array = ["The Empire Strikes Back", "Wizard of Oz", "Harry Potter"]; 
//console.log(array);

/*
for (let i = 0; i < array.length; i++) {
    console.log(array[i]);
}
for (i in array) {
    console.log(array[i]);
}
*/
/*
console.log("Using a While loop:");
let i =0;
while (i < array.length) {
    console.log(array[i]);
    i++;
}
*/
/*
console.log("Reverse order:");
for (let i = array.length -1; i >= 0; i--) {
    console.log(array[i]);
}
*/

/*
let multiplesOfTwo=[];
for (let i = 0; i < 20; i++) {
    if (i % 2 == 0) {
        multiplesOfTwo.push(i);
    }
}
console.log(`numbers divisible by 2 are ${multiplesOfTwo}`); // NOTE must used backticks!
*/
/*
let age =15;
while(age < 18) {
    console.log("You're a child");
    age++;
}
console.log("You're an adult");
*/

/*
let cards = ["diamond", "spade", "heart", "club"];  // available card suits
let currentCard = "club"; // set the current card to club

// loop while currentCard is not a spade
while(currentCard != "spade") {
    console.log(currentCard); // print the current card
    currentCard = cards[Math.floor(Math.random() * 4)]; // get a random card from the array
}
console.log(currentCard); // print the last card
*/


/*
Try - Array Manipulation 
• Create an array of numbers and use the push() 
method to add an element to the end of the array. 
• Use the pop() method to remove the last element 
from the array. 
• Use the unshift() method to add an element to 
the beginning of the array. 
• Use the shift() method to remove the first element 
from the array. 
*/
/*
let numbers = [1, 2, 3, 4, 5]; // create an array of numbers
console.log("Original array:", numbers); // print the original array
numbers.push(6); // add an element to the end of the array  
console.log("After push:", numbers); // print the array after push
numbers.pop(); // remove the last element from the array
console.log("After pop:", numbers); // print the array after pop    
numbers.unshift(666); // add an element to the beginning of the array
console.log("After unshift:", numbers); // print the array after unshift        
numbers.shift(); // remove the first element from the array 
console.log("After shift:", numbers); // print the array after shift
*/

/*
Challenge 1:
Create an array that lists your favourite films, up to 5 elements.
Add 2 more using a method.
Use a loop to cycle through the array and console log each item
*/
console.log("Challenge 1:");
let arrFilms=["Wizard of Oz", "Star Wars", "Deadpool", "Lord of the Rings", "Harry Potter" ];
arrFilms.push("Batman", "Titfield Thunderbolt");
for(i in arrFilms){
    console.log(arrFilms[i]);
}


/*
Challenge 2:
Generate 6 random numbers between 1-50 and log them to the console
*/
console.log("Challenge 2:");
for (let i = 0; i < 6; i++) {
    let randomNumber = Math.floor(Math.random() * 50) +1; 
    console.log(randomNumber); 
}
/*
Challenge 3:
If we can create a loop to put 0-9 on the screen, how can we count from 9-0? Create a program that does this.
*/
console.log("Challenge 3:");
for (let i = 9; i >= 0; i--) {
    console.log(i); 
}
/*
Challenge 4:
Displays 4 films stored in an array.
Use a for loop to show each film in the array.
Use an if statement to check if the 3rd film in the array is Ghostbusters.
If it is, log “Yay it’s Ghostbusters”. If it isn’t log “Boo! we want Ghostbusters!
*/
console.log("Challenge 4:");
let arrFilms2=["Wizard of Oz", "Star Wars", "Deadpool", "Lord of the Rings", "Harry Potter" ];
for(i in arrFilms2){
    console.log(arrFilms2[i]);
}   
if (arrFilms2[2] == "Ghostbusters") {
    console.log("Yay it's Ghostbusters");
}else {
    console.log("Boo! we want Ghostbusters!");
}

/*
Challenge 5:
Generate a random number between 1 and 30 six times.
For each random number generated, check if this number of divisible by 7 or not.
Log out a message to the console if it is divisible by 7 or not.
*/
console.log("Challenge 5:");
for(let i = 0; i < 6; i++) {
    let randomNumber = Math.floor(Math.random() * 30) +1; 
    if (randomNumber % 7 == 0) {
        console.log(`${randomNumber} is divisible by 7`); 
    } else {
        console.log(`${randomNumber} is not divisible by 7`); 
    }
}

/*
Challenge 6:

Imagine you’re a programmer for a social media platform! You have been tasked with building a prototype for a mutual followers program.

Create 2 arrays of followers e.g. bobsFollowers & hannahsFollowers. In these arrays place 4 names as strings. 
Make sure there are 2 names that are in BOTH arrays.

Using a nested loop iterate over both arrays and console.log out the matching follower.
*/
 console.log("Challenge 6:");
let bobsFollowers = ["Alice", "Bob", "Charlie", "David"];
let hannahsFollowers = ["Eve", "Frank", "Charlie", "David"];
let matchingFollowers = [];   
for (let i = 0; i < bobsFollowers.length; i++) {
    for (let j = 0; j < hannahsFollowers.length; j++) {
        if (bobsFollowers[i] === hannahsFollowers[j]) {
            matchingFollowers.push(bobsFollowers[i]);
        }
    }
}
console.log("Matching followers are: " + matchingFollowers.join(", ")); 

 


