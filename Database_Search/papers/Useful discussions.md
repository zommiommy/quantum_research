# Useful discussions to understand Grover Search utility field

### How is the oracle in Grover's search algorithm implemented?

https://quantumcomputing.stackexchange.com/questions/175/how-is-the-oracle-in-grovers-search-algorithm-implemented

> Grover's search is not concerned about the implementability, but the polynomial reduction in what's called a query complexity

### Grover's algorithm: what to input to Oracle?

https://quantumcomputing.stackexchange.com/questions/2149/grovers-algorithm-what-to-input-to-oracle

> Although popular explanations of Grover's algorithm talk about searching over a list, in actuality you use it to search over possible inputs 0..N-1 to a function. The cost of the algorithm is O(√N ⋅ F) where N is the number of inputs you want to search over and F is the cost of evaluating the function. If you want that function to search over a list, you must hardcode the list into the function.

### Grover's algorithm: where is the list?

https://quantumcomputing.stackexchange.com/questions/2110/grovers-algorithm-where-is-the-list

> Grover's algorithm is just searching for what the oracle knows": not necessarily. The oracle may be checking for only some specific property of the input, so that the result one gets at the end contains more information than that encoded in the oracle itsef. A typical example is searching in a phone book. The oracle "asks" for a record attached to a specific name, but once the correct record is found, one also gains the additional information of the phone number attached to that record, which was not encoded at all in the oracle

### [Paper] Using Grover's quantum algorithm for searching actual databases

https://www.researchgate.net/publication/234446163_Using_Grover's_quantum_algorithm_for_searching_actual_databases

> I investigate whether it would technologically and economically make sense to build database search engines based on Grover's quantum search algorithm. The answer is not fully conclusive but in my judgement rather negative.
