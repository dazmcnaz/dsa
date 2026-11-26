# Data Structures and Algorithms in C#

This repository covers the data structures and algorithms used in C# programs.

They were done while doing revision on my degree module. The linked list, stack, queue and BST were built from scratch. The hashing and BFS use `Dictionary`, `HashSet` and `Queue`.

It focuses on Big-O. The `Program.cs` runs a demo of all of them.

## What's inside

| Folder / file | What it is | Key operations | Big-O (time) |
| --- | --- | --- | --- |
| `Searching/BinarySearch.cs` | Iterative and recursive binary search on a sorted array | Search | O(log n); space O(1) iterative, O(log n) recursive |
| `Sorting/InsertionSort.cs` | In-place insertion sort | Sort | O(n²) worst, O(n) on sorted data |
| `LinkedLists/MyLinkedList.cs` | Linked list with `head` and `tail` | AddFirst, AddLast, Remove | O(1), O(1), O(n) |
| `StacksQueues/MyStack.cs` | Generic array-backed stack, doubles when full | Push, Pop, Peek | O(1) amortised |
| `StacksQueues/IntQueue.cs` | Circular-array queue with `Grow()` | Enqueue, Dequeue | O(1) amortised |
| `Trees/BST.cs` | Generic binary search tree (`where T : IComparable<T>`) | Insert, Contains, InOrder | O(log n) balanced, O(n) worst; InOrder O(n) |
| `Graphs/GraphSearch.cs` | BFS on an adjacency list | BFS | O(V + E) |
| `Hashing/HashingExamples.cs` | TwoSum and FirstUnique with `Dictionary` | One or two passes | O(n) |
| `Recursion/RecursionExamples.cs` | Factorial and SumTo | Recursive calls | O(n) time, O(n) stack space |

## How to run

```bash
git clone https://github.com/dazmcnaz/dsa.git
cd dsa
dotnet run
```

`Program.cs` runs a short demo of each structure and prints the results.

## Design notes

- **Generics:** `MyStack<T>` and `BST<T>` work for any type. The BST constrains `T` to `IComparable<T>` so it can call `CompareTo`.
- **Growth:** the stack and queue double their array when full, so a single resize is O(n) but the average cost per operation stays O(1).
- **Memory:** `Pop` clears the old slot (`default!`) so the garbage collector can reclaim the object.
- **Hashing:** `HashSet.Add` returns `bool`, which BFS uses to mark a node visited and queue it in one step.

## Tech Stack

.NET 10, console app. No external packages.
