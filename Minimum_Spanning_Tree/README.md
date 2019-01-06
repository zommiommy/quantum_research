
# MST:
https://en.wikipedia.org/wiki/Minimum_spanning_tree#cite_note-11

# MST Finding algorithm:
https://en.wikipedia.org/wiki/Bor%C5%AFvka%27s_algorithm

## Other equivalents algorithms:

https://en.wikipedia.org/wiki/Prim%27s_algorithm

https://en.wikipedia.org/wiki/Kruskal%27s_algorithm

### Complexities
they all can be implemented having similar complexities

![](https://latex.codecogs.com/gif.latex?O%28%7CV%7Clog%28%7CV%7C%29%29)

![](https://latex.codecogs.com/gif.latex?O%28%7CE%7Clog%28%7CV%7C%29%29)

![](https://latex.codecogs.com/gif.latex?O%28%7CE%7C%20&plus;%20%7CV%7Clog%28%7CV%7C%29%29)

#### Lemma :
![](https://latex.codecogs.com/gif.latex?%7CE%7C%20%5Cle%20%5Cfrac%7B%7CV%7C%5E2%7D%7B2%7D%20%5Clongrightarrow%7CE%7C%5Csim%20%7CV%7C%5E2%20%5Clongrightarrow%20log%28%7CE%7C%29%20%5Csim%20log%28%7CV%7C%5E2%29%20%3D%202log%28%7CV%7C%29)

this implies

![](https://latex.codecogs.com/gif.latex?O%28log%28%7CE%7C%29%29%20%5Csim%20O%28log%28%7CV%7C%29%29)

![](https://latex.codecogs.com/gif.latex?O%28%7CE%7C%29%20%5Csim%20O%28%7CV%7C%5E2%29)


### Faster Algorithms
I don't think those are usable for our problem.

Theoretically doable in 
![](https://latex.codecogs.com/gif.latex?O%28%7CE%7C%29)
which is a derivate of the Boruvka algorithm
https://dl.acm.org/citation.cfm?doid=201019.201022


Or using a number of threads proportional to the number of vertices(TO CHECK) it can be done in 
![](https://latex.codecogs.com/gif.latex?O%28log%28%7CV%7C%29)
http://web.eecs.umich.edu/~pettie/papers/sicomp-randmst.pdf

# Groover's search algorithm

https://it.wikipedia.org/wiki/Algoritmo_di_ricerca_di_Grover
