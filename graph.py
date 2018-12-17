# Boruvka's algorithm to find Minimum Spanning 
# Tree of a given connected, undirected and weighted graph 

from collections import defaultdict 

#Class to represent a graph 
class Graph: 

	def __init__(self,vertices): 
		self.V= vertices #No. of vertices 
		self.graph = [] # default dictionary to store graph 
		

	# function to add an edge to graph 
	def addEdge(self,u,v,w): 
		self.graph.append([u,v,w]) 

	# A utility function to find set of an element i 
	# (uses path compression technique) 
	def find(self, parent, i): 
		if parent[i] == i: 
			return i 
		return self.find(parent, parent[i]) 

	# A function that does union of two sets of x and y 
	# (uses union by rank) 
	def union(self, parent, rank, x, y): 
		xroot = self.find(parent, x) 
		yroot = self.find(parent, y) 

		# Attach smaller rank tree under root of high rank tree 
		# (Union by Rank) 
		if rank[xroot] < rank[yroot]: 
			parent[xroot] = yroot 
		elif rank[xroot] > rank[yroot]: 
			parent[yroot] = xroot 
		#If ranks are same, then make one as root and increment 
		# its rank by one 
		else : 
			parent[yroot] = xroot 
			rank[xroot] += 1