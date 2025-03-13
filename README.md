# Data-Structures
Exercises on most common used data structures in programming

<table>
<tbody>
<tr>
<th colspan="5">
Data Structure Efficiency 
</th>
</tr>
<tr>
<td><b>Data structure</b></td>
<td><b>Add</b></td>
<td><b>Find</b></td>
<td><b>Delete</b></td>
<td><b>Get by Index</b></td>
</tr>
<tr>
<td>Array T []</td>
<td>0(n)</td>
<td>0(n)</td>
<td>0(n)</td>
<td>0(1)</td>
</tr>
<tr>
<td>List&#60;T&#62;</td>
<td>0(1)</td>
<td>0(n)</td>
<td>0(n)</td>
<td>0(1)</td>
</tr>
<tr>
<td>LinkedList&#60;T&#62;</td>
<td>0(1)</td>
<td>0(n)</td>
<td>0(n)</td>
<td>0(n)</td>
</tr>
<tr>
<td>Stack&#60;T&#62;</td>
<td>0(1)</td>
<td> - </td>
<td>0(1)</td>
<td> - </td>
</tr>
<tr>
<td>Queue&#60;T&#62;</td>
<td>0(1)</td>
<td> - </td>
<td>0(1)</td>
<td> - </td>
</tr>
<tr>
<td>Dictionary&#60;K,V&#62;</td>
<td>0(1)</td>
<td>0(1)</td>
<td>0(1)</td>
<td> - </td>
</tr>
<tr>
<td>SortedDictionary&#60;K,V&#62;</td>
<td>0(log N)</td>
<td>0(log N)</td>
<td>0(log N)</td>
<td> - </td>
</tr>
<tr>
<td>MultiDictionary&#60;K,V&#62;</td>
<td>0(1)</td>
<td>0(1)</td>
<td>0(1)</td>
<td> - </td>
</tr>
<tr>
<td>SortedMultiDictionary&#60;K,V&#62;</td>
<td>0(log N)</td>
<td>0(log N)</td>
<td>0(log N)</td>
<td> - </td>
</tr>
<tr>
<td>HashSet&#60;T&#62;</td>
<td>0(1)</td>
<td>0(1)</td>
<td>0(1)</td>
<td> - </td>
</tr>
<tr>
<td>SortedSet&#60;T&#62;</td>
<td>0(log N)</td>
<td>0(log N)</td>
<td>0(log N)</td>
<td> - </td>
</tr>
  <tr>
<td>Bag&#60;T&#62;</td>
<td>0(1)</td>
<td>0(1)</td>
<td>0(1)</td>
<td> - </td>
</tr>
  <tr>
<td>OrderedBag&#60;T&#62;</td>
<td>0(log N)</td>


## Data Structures Overview

### Array T[]
A collection of elements of the same type, stored in contiguous memory locations. Offers fast access by index but is fixed in size after creation.

### List<T>
A collection of elements that can dynamically resize. Provides fast access by index but is less efficient for adding or removing elements from the middle.

### LinkedList<T>
A collection of nodes where each node points to the next. Useful for frequent insertions and deletions but slower for indexed access.

### Stack<T>
A last-in, first-out (LIFO) collection. Useful for reversing operations, where elements are added and removed from the top.

### Queue<T>
A first-in, first-out (FIFO) collection. Ideal for scenarios like task scheduling or handling requests.

### Dictionary<K,V>
A collection of key-value pairs. Allows fast lookups, additions, and deletions by key.

### SortedDictionary<K,V>
A dictionary that maintains keys in sorted order. Supports fast lookups but slower insertions and deletions due to sorting.

### MultiDictionary<K,V>
Allows multiple values per key, making it suitable for scenarios where one key maps to many values.

### SortedMultiDictionary<K,V>
A sorted version of `MultiDictionary`, maintaining order while allowing multiple values per key.

### HashSet<T>
A collection that stores unique elements without duplicates. Provides fast lookups and ensures element uniqueness.

### SortedSet<T>
A set that stores unique elements in sorted order. Provides efficient lookup and maintains order.

### Bag<T>
A collection that allows duplicates. Used when the count of elements matters, but order is not important.

### OrderedBag<T>
A bag that maintains the insertion order of elements while allowing duplicates.
<td>0(log N)</td>
<td>0(log N)</td>
<td> - </td>
</tr>
</tbody>
</table>
