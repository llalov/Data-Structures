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
<td>0(log N)</td>
<td>0(log N)</td>
<td> - </td>
</tr>
</tbody>
</table>





## Data Structures Overview

### **Array T[]**
A collection of elements of the same type, stored in contiguous memory locations.  
- **Key Feature**: Fast access by index.  
- **Limitation**: Fixed size after creation.

### **List<T>**
A dynamic collection that resizes as needed.  
- **Key Feature**: Flexible resizing and fast index access.  
- **Limitation**: Slower insertions and deletions in the middle.

### **LinkedList<T>**
A collection of nodes where each node points to the next.  
- **Key Feature**: Efficient insertions and deletions.  
- **Limitation**: Slower indexed access.

### **Stack<T>**
A last-in, first-out (LIFO) collection.  
- **Key Feature**: Ideal for undo operations or reversing sequences.  
- **Limitation**: Limited to top element access.

### **Queue<T>**
A first-in, first-out (FIFO) collection.  
- **Key Feature**: Useful for task scheduling or handling requests.  
- **Limitation**: Limited to first element access.

### **Dictionary<K,V>**
A collection of key-value pairs.  
- **Key Feature**: Fast lookups, additions, and deletions by key.  
- **Limitation**: Keys must be unique.

### **SortedDictionary<K,V>**
A dictionary that maintains keys in sorted order.  
- **Key Feature**: Sorted keys for efficient range queries.  
- **Limitation**: Slower insertions and deletions due to sorting.

### **MultiDictionary<K,V>**
A dictionary that allows multiple values per key.  
- **Key Feature**: Maps one key to many values.  
- **Limitation**: No sorting.

### **SortedMultiDictionary<K,V>**
A sorted version of the `MultiDictionary`.  
- **Key Feature**: Maintains sorting while allowing multiple values per key.  
- **Limitation**: More complex than a basic `MultiDictionary`.

### **HashSet<T>**
A collection that ensures all elements are unique.  
- **Key Feature**: Fast lookups and ensures no duplicates.  
- **Limitation**: No order preservation.

### **SortedSet<T>**
A set that maintains unique elements in sorted order.  
- **Key Feature**: Efficient lookup and ordered elements.  
- **Limitation**: Sorting adds overhead during insertion and deletion.

### **Bag<T>**
A collection that allows duplicate elements.  
- **Key Feature**: Count of elements matters.  
- **Limitation**: No ordering.

### **OrderedBag<T>**
A bag that maintains the insertion order of elements.  
- **Key Feature**: Allows duplicates while preserving insertion order.  
- **Limitation**: Slightly slower due to maintaining order.
