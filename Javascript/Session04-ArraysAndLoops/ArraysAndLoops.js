let arr=["Zero","One","Two","Three"];
/*
console.log(arr);
arr.push("Many");
console.log(arr);
arr.pop();
console.log(arr);
arr.unshift("minus one");
console.log(arr);
arr.shift();
console.log(arr);
*/

/*
// iterate using forEach
arr.forEach(function(item, index){
    console.log("forEach: " + index + " : " + item);
});

// iterate using for loop
for (let i=0; i<arr.length; i++){
    console.log("for: " + arr[i]);
}   

// use an "arrow function"....
// map() processes all elements in the array and returns a new array with the results of calling a function on each element
let arr2 = arr.map((item, index) => item.toUpperCase());
console.log("Map: " + arr2);

// filter() processes all elements in the array and returns a new array with only those that match the condition
// starts with letter 'O' or 'T'
let arr3 = arr.filter((item,index) => item[0]=="O" || item[0]=="T");
console.log("Filter: " + arr3);

// lambda function
const array = [1, 2, 3, 4, 5];
const isEven = (element) => element % 2 === 0;
console.log("isEven: " + array.some(isEven));
*/


// more array functions
arr = [1,2,3,4,5,6,7,8,9,10];
//console.log("includes: " + arr.includes(45)); 
//console.log("indexOf: " + arr.indexOf(97));
//console.log("indexOf: " + arr.indexOf(3));
console.log("sort: " + arr.sort()); 
console.log("numeric sort: " + arr.sort(function(a,b){return b-a}))
console.log("numeric sort2: " + arr.sort(function(a,b){return a-b}))
console.log("reverse: " + arr.reverse()); 

// transformation
console.log(arr);
console.log("slice: " + arr.slice(2,5)); 
console.log("splice : " + arr.splice(2,3));
console.log("concat: " + arr.concat([11,12,13]));

