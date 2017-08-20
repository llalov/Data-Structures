Visualization foe BST: https://visualgo.net/en/bst

Trees and tree-like structures:
	(terminology: Node, Internal node, Edge, Root, Children, Parent, Siblings, Descendant, Predecessor, Successor, Leaf, Depth, Height, Sub-tree)
	Tree: A single node is a tree. Can have zero or multiple children that are also trees.
		Traversing:
			DFS(Depth-First Search): descendants -> node
			BFS(Breadth-First Search): node -> neighbours -> neighbours of neighbours, etc. 
	Binary search tree: Each node has at most 2 children (left and right).
		Traversing:
			Pre-Order: Root, Left, Right
			In-Order: Left, Root, Right
			Post-Order: Left, Right, Root