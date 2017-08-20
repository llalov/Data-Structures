Special tree structures
	Trie:(fast prefix search)
		(prefix tree)
		An ordered tree data structure
		Special tree structure used for fast multi-pattern matching
		Used to store a dynamic set where the keys are usually strings. Used for creating Dictionaries, Text searching, Compression.

	Rope:(fast add/remove by index)
		(Wintellect BigList<T>)
		Balanced tree for indexed items with fast insert/delete. Allows fast string edit operations on very long strings.
		Rope is a binary tree having leaf nodes
		Each node holds a short string
		Each node has a weight value equal to length of its string