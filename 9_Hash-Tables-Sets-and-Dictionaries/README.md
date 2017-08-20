	Hash Table visualisation: https://visualgo.net/en/hashtable
	
	Maps: (associative arrays)
		Hash tables: (array holding key-value pairs) 
			Use hash functions to search / insert
			The process of mapping a key to a position in a table is called hashing
			A hash function converts keys into array indices
			Modular hashing (GetHashCode() % Array.Length)
			Very fast Add, Find, Delete - 0(1)
			Collision resolution strategies:
				Chaining - collided keys(+ values) in a list
				Open addressing - using other slots in the table
					Linear probing - take the next empty slot just after the collision (h(key,i) = h(key) + i)
					Quadratic probing - the i-th next slot calculated by a quadratic polynomial (h(key,i) = h(key)+c1*i + c2*i2). 
						Rehashing use separate hash function for collisions.
						
		Dictionaries: 
			Dictionary<K,V>: (Fast add key-value pairs + fast search by key – O(1) )
				Hash table based
				Hold pairs ( holds key, value pairs)
				Add(key,value); Remove(key); this[key] = value; Keys; Values; ContainsKey(key); ContainsValue(value); TryGetValue(key, out value)
				SortedDictionary<TKey, TValue> implements the ADT "dictionary" as self-balancing search tree
			OrderedDictionary<K,V>: (Fast add key-value pairs + fast search by key + fast sub-range)
				Balanced Tree based
				Keys should be IComparable<T>
			MultiDictionary<K,V>:(Fast add key-value + fast search by key + multiple values by key)
				Hash table based
				Add by existing key appends a new value for the same key
				Keys have no particular order
			OrderedMultiDictionary<K,V>: (Fast add key-value + fast search by key + fast sub-range)
				Tree based 
				Keys are ordered by key
				Add by existing key appends a new value for the same key
				
 		Sets:(collection of unique elements)
			HashSet<T>:(Unique values + fast add + fast contains)
				Hash table based
				Elements have no particular order
				Elements should implement GetHashCode(...) and Equals(...)
			SortedSet<T>:(Fast add + fast contains + fast sub-range)
				Balanced tree based
				Unique values + sorted order
				Elements should be IComparable<T>
				
		Bags:(collection of non-unique elements)
			Bag<T>: (Fast add + fast find + fast contains)
				Hash table based
				Elements have no particular order
			OrderedBag<T>:(Fast add + fast find + fast contains)
				Balanced Tree based
				Sorted order
				Access by sorted index + exact sub-range