// Quick sort works by selecting a 'pivot' element from the array and partitioning the other elements into two sub-arrays, 
// according to whether they are less than or greater than the pivot. The sub-arrays are then sorted recursively.

// https://www.doabledanny.com/quick-sort-in-javascript

// complexity, effiency, speed

function partition(arr, start, end) {
    const pivotValue = arr[start]
    let swapIndex = start
    for (let i = start + 1; i <= end; i++) {
      if (pivotValue > arr[i]) {
        swapIndex++
        if (i !== swapIndex) {
          // SWAP
          [arr[i], arr[swapIndex]] = [arr[swapIndex], arr[i]]
        }
      }
    }
    if (swapIndex !== start) {
      // Swap pivot into correct place
      [arr[swapIndex], arr[start]] = [arr[start], arr[swapIndex]]
    }
    return swapIndex
  }

function quickSort(arr, start = 0, end = arr.length - 1) {
    // Base case
    if (start >= end) return
    let pivotIndex = partition(arr, start, end)
    // Left
    quickSort(arr, start, pivotIndex - 1)
    // Right
    quickSort(arr, pivotIndex + 1, end)
    return arr
  }


  console.log( quickSort([3, 5, 8, 5, 99, 1])); // [1, 3, 5, 5, 8, 99]);
