Special tree structures:
	Interval tree:(fast interval search)
		modified BST that stores intervals
		Efficient search for any or all intervals that overlap a given interval
		Each node stores sub-tree max endpoint
		Nodes are ordered by interval start
	K-d Tree:(fast geometric distance search and retrieval of multidimensional data)
		space partitioning data structure 	
		Still a BST
		Every node splits it's own plane in two parts
		The nodes values are points (x, y)