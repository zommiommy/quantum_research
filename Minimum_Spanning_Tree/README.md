
# Minimum Spanning Tree Problem:
https://en.wikipedia.org/wiki/Minimum_spanning_tree#cite_note-11
Given a graph ![](https://latex.codecogs.com/gif.latex?G%20%3D%20%5C%7BV%2CE%5C%7D)
we define MST as the subset of edges ![](https://latex.codecogs.com/gif.latex?MST%20%5Csubseteq%20E) that **minimize** the sum of the weight of the edges **that** cover all the Vertices ![](https://latex.codecogs.com/gif.latex?V) of the graph.


# MST Finding algorithm:
![Borůvka's algorithm](https://en.wikipedia.org/wiki/Bor%C5%AFvka%27s_algorithm)

![Prim's algorithm](https://en.wikipedia.org/wiki/Prim%27s_algorithm)

![Kuskal algorithm](https://en.wikipedia.org/wiki/Kruskal%27s_algorithm)

### Complexities
they all can be implemented having similar complexities

Borůvka's algorithm: ![](https://latex.codecogs.com/gif.latex?O%28%7CE%7Clog%28%7CV%7C%29%29)

Prim's algorithm: ![](https://latex.codecogs.com/gif.latex?O%28%7CE%7C%20&plus;%20%7CV%7Clog%28%7CV%7C%29%29)

Kuskal algorithm: ![](https://latex.codecogs.com/gif.latex?O%28%7CV%7Clog%28%7CV%7C%29%29)

#### Lemma :
Given a graph 
![](https://latex.codecogs.com/gif.latex?G%20%3D%20%5C%7BV%2CE%5C%7D)
the following properties holds:

![](https://latex.codecogs.com/gif.latex?O%28log%28%7CE%7C%29%29%20%5Csim%20O%28log%28%7CV%7C%29%29)

![](https://latex.codecogs.com/gif.latex?O%28%7CE%7C%29%20%5Csim%20O%28%7CV%7C%5E2%29)

#### Dim:
Since the maximum number of edges are the one of a connected graph it follows

![](https://latex.codecogs.com/gif.latex?%7CE%7C%20%5Cle%20%5Cfrac%7B%7CV%7C%5E2%7D%7B2%7D%20%5Clongrightarrow%7CE%7C%5Csim%20%7CV%7C%5E2%20%5Clongrightarrow%20log%28%7CE%7C%29%20%5Csim%20log%28%7CV%7C%5E2%29%20%3D%202log%28%7CV%7C%29)

this implies the lemma.


### Faster Parallel Algorithms
I don't think those are usable for our problem.

Theoretically doable in 
![](https://latex.codecogs.com/gif.latex?O%28%7CE%7C%29)
which is a derivate of the Boruvka algorithm
![as described in this paper](https://dl.acm.org/citation.cfm?doid=201019.201022)


Or using a number of threads proportional to the number of vertices(TO CHECK) it can be done in 
![](https://latex.codecogs.com/gif.latex?O%28log%28%7CV%7C%29)
![as described in this paper](http://web.eecs.umich.edu/~pettie/papers/sicomp-randmst.pdf)

# Groover's search algorithm

https://it.wikipedia.org/wiki/Algoritmo_di_ricerca_di_Grover
