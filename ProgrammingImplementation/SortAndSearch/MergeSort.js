// Merge sort works by recursively dividing the array into halves until each half has one element, and then merging the sorted halves back together.
// https://www.doabledanny.com/merge-sort-javascript


// complexity, effiency, speed??


function mergeSort(arr) {
    // Base case
    if (arr.length <= 1) return arr
    let mid = Math.floor(arr.length / 2)
    // Recursive calls
    let left = mergeSort(arr.slice(0, mid))
    let right = mergeSort(arr.slice(mid))
    return merge(left, right)
  }

  function merge(left, right) {
    let sortedArr = [] // the sorted items will go here
    while (left.length && right.length) {
      // Insert the smallest item into sortedArr
      if (left[0] < right[0]) {
        sortedArr.push(left.shift())
      } else {
        sortedArr.push(right.shift())
      }
    }
    // Use spread operators to create a new array, combining the three arrays
    return [...sortedArr, ...left, ...right]
  }


 console.log( mergeSort([3, 5, 8, 5, 99, 1])); // [1, 3, 5, 5, 8, 99]);