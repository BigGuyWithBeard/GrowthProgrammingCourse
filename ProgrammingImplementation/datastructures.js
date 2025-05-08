// data structures
// variables, linked lists, arrays, stacks and queues
// anything that holds data is a data structure

/*
// in Js can do:
for (i in cars) {
    console.log(cars[i]);
} 
    */

/*
//stacks
* LIFO (Last In First Out)
uses a single Pointer
points to top of the stack
push() // adds an element to the top of the stack
pop()   // adds an element to the top of the stack
peek() // returns the top element without removing it
*/
/*
// queues
FIFO (First In First Out)
uses 2 pointers
one to the front of the queue
one to the back of the queue
enqueue() // adds an element to the back of the queue
dequeue() // removes an element from the front of the queue
peek() // returns the front element without removing it
push() // adds an element to the back of the queue
shift() // removes an element from the front of the queue
// unshift() // adds an element to the front of the queue
// pop() // removes an element from the back of the queue
// splice() // removes an element from the middle of the queue
*/


/*
linked lists - a data structure that consists of a sequence of nodes    
each node contains a value and a pointer to the next node in the sequence
the first node is called the head and the last node is called the tail
the tail points to null
the head points to the first node in the list
the list can be traversed by following the pointers from the head to the tail
the list can be traversed in reverse by following the pointers from the tail to the head
the list can be traversed in both directions by using a doubly linked list

1. what is a linked list
    - a data structure that consists of a sequence of nodes. each node contains a value and a pointer to the next node in the sequence.
    - the first node is called the head and the last node is called the tail. the tail points to null. the head points to the first node in the list. the list can be traversed by following the pointers from the head to the tail. the list can be traversed in reverse by following the pointers from the tail to the head. the list can be traversed in both directions by using a doubly linked list.
2. how do they work
 - memory allocation - array = contigous, LL = not.each node can be anywhere is mem.
3. what are the advantages and disadvantages compare to an array?
    * dynamic size, arrays are static when created.  some langs support changing but is expensive
    * efficient insertion and deletion,  -> arrays require shifting elements 
    * memory efficiency, a single node can fit in smaller blocks of memory
    * * higher memory ussage
    * slower access in loops, lots of pointers to iterte teh list.
    * cant just jump to a single element by index
    * more complicted to implement than arrays
    * allows different data types in a node, arrays are all the same type
    * traversal is slower than arrays -> lots of pointers!

https://www.wscubetech.com/resources/dsa/array-vs-linked-list


single linked list
double linked list
circular linked list

examples of use
playlists
browser history
DOM model?
undo
waiting queues where people can join and leave at any time

*/