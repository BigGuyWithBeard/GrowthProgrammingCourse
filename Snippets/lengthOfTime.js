let stime = performance.now();     // started time
executeSomething()                      
let ftime = performance.now();     // finished time

let elapsed_time = ftime - stime;  
console.log(`Execution time: ${elapsed_time} ms`); 