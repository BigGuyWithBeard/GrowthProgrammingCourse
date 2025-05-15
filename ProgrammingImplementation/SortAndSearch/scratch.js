// https://www.enjoyalgorithms.com/blog/comparison-of-sorting-algorithms


/*
/// simple linear search
function linearSearch(arr,target)
{
    for (let i in arr) {
         if (arr[i] === target) return i
    }
     
    return -1;
}
 
console.log(linearSearch([1,2,3,4],1));// 0
console.log(linearSearch([1,2,3,4],4));// 3
console.log(linearSearch([1,2,3,4],6));// -1
console.log(linearSearch([3,4,1,6,3],6));// 3
*/

/*
// simple binary search (non-recursive)
const binarySearch = (array, target) => {
     // Define Start and End Index
     let startIndex = 0;
     let endIndex = array.length - 1;
     // While Start Index is less than or equal to End Index
     while(startIndex <= endIndex) {
       // Define Middle Index (This will change when comparing )
       let middleIndex = Math.floor((startIndex + endIndex) / 2);
       // Compare Middle Index with Target for match
       if(target === array[middleIndex]) {
         return console.log("Target was found at index " + middleIndex);
       }
       // Search Right Side Of Array
       if(target > array[middleIndex]) {
         console.log("Searching the right side of Array")
         // Assign Start Index and increase the Index by 1 to narrow search
         startIndex = middleIndex + 1;
       }
       // Search Left Side Of Array
       if(target < array[middleIndex]) {
         // Assign End Index and increase the Index by 1 to narrow search
         console.log("Searching the left side of array")
         endIndex = middleIndex - 1;
       }
       // Not found in this iteration of the loop. Looping again.
       else {
         console.log("Not Found this loop iteration. Looping another iteration.")
       }
     }
     // If Target Is Not Found
     console.log("Target value not found in array");
     return -1;

   }
  
   console.log(binarySearch([1,2,3,4],1));// 0
   console.log(binarySearch([1,2,3,4],4));// 3
   console.log(binarySearch([1,2,3,4],6));// -1
   console.log(binarySearch([3,4,1,6,3],6));// 3
  */


   /*
   // bubble sort
    
function bblSort(arr) {
 
     console.log(arr);

     for (var i = 0; i < arr.length; i++) {
  
         // Last i elements are already in place  
         for (var j = 0; j < (arr.length - i - 1); j++) {
  
             // Checking if the item at present iteration
             // is greater than the next iteration
             if (arr[j] > arr[j + 1]) {
  
                 // If the condition is true
                 // then swap them
                 var temp = arr[j]
                 arr[j] = arr[j + 1]
                 arr[j + 1] = temp
             }
         }
     }
  
     // Print the sorted array
     console.log(arr);
 }
  
 // This is our unsorted array
 var arr = [234, 43, 55, 63, 5, 6, 235, 547];
  
 // Now pass this array to the bblSort() function
 bblSort(arr);
  
*/
  

//Alternate version using swaps to decide when to end.  
function bubbleSort(arr) {
    let n = arr.length;
    let swapped;
 
    do {
      swapped = false;
      for (let i = 0; i < n - 1; i++) {
        if (arr[i] > arr[i + 1]) {
          // Swap elements
          [arr[i], arr[i + 1]] = [arr[i + 1], arr[i]];
          swapped = true;
        }
      }
      // Reduce the range of comparison since the last element is in place
      n--;
    } while (swapped);
 
    return arr;
  }
 
  // Example usage
  const numbers = [64, 34, 25, 12, 22, 11, 90];
  console.log("Sorted array:", bubbleSort(numbers))
 