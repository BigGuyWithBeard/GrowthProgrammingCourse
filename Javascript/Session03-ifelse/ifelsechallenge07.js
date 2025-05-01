// Challenge 7:
// Take the string "jrfndklhgfndjkjlkgperfijfhdknsadcvjhiiohjfkledsopiuhgtyujwsdxcvhgfdjhiopiwquhejkdsoiufghedjwshi".
// Find the index of a last vowel in the string.

var gobbledegoop =   "jrfndklhgfndjkjlkgperfijfhdknsadcvjhiiohjfkledsopiuhgtyujwsdxcvhgfdjhiopiwquhejkdsoiufghedjwshi";
//var gobbledegoop =   "jrfndklhgfndjkjlkgprfjfhdknsdcvjhhjfkldsphgtyjwsdxcvhgfdjhpwqhjkdsfghdjwsh"; // no vowels!
var index=-1;

for (var i=gobbledegoop.length -1; i>=0; i--) {  
    if (gobbledegoop[i] === "a" || gobbledegoop[i] === "e" || gobbledegoop[i] === "i" || gobbledegoop[i] === "o" || gobbledegoop[i] === "u") {
        index = i ; // index of the last vowel
        break;
    }
}

if (index !== -1) {
  console.log("The index of the last vowel is: %s (zero based)", index.toString());
  console.log(gobbledegoop.at(index)); // prints the last vowel
} else {
  console.log("No vowels found in the string.");
}
