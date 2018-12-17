
# MST:
	https://en.wikipedia.org/wiki/Minimum_spanning_tree#cite_note-11

# MST Finding algorithm:
	https://en.wikipedia.org/wiki/Bor%C5%AFvka%27s_algorithm

##Other equivalents algorithms:

	https://en.wikipedia.org/wiki/Prim%27s_algorithm

	https://en.wikipedia.org/wiki/Kruskal%27s_algorithm

### Complexities
they all can be implemented having similar complexities
O(|V|log(|V|))
O(|E|log(|V|))
O(|E| + |V|log(|V|))

### Faster Algorithms but not usable for our goals:
Theoretically doable in O(|E|) [https://dl.acm.org/citation.cfm?doid=201019.201022] which is a derivate of the Boruvka algorithm

Or using a number of threads proportional to the number of vertices(TO CHECK) it can be done in O(log(|V|))
[http://web.eecs.umich.edu/~pettie/papers/sicomp-randmst.pdf]

# Groover's search algorithm

Research algorithm:
	https://it.wikipedia.org/wiki/Algoritmo_di_ricerca_di_Grover