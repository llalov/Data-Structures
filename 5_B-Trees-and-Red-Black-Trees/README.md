Balanced binary search trees:
	B-Trees:
		Generalization of the concept of ordered binary search trees.
		The keys in each node are ordered increasingly
		All keys in a child node have values between their left and right parent keys
		The count of nodes from the root to any null node is the same
	Red-black Trees: (fast insertion/deletion)
		binary search tree with red and black nodes. 
		Not perfectly balanced but has height of O(log(n)). Used in C# and Java: ( https://www.cs.usfca.edu/~gallevisualization/RedBlack.html )
		All leaves are black
		The root is black
		No node has two red links connected to it
		Every path from a given node to its descendant leaf nodes contains the same number of black nodes
		Red links lean left