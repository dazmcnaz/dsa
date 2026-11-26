using dsa_repo.Graphs;
using dsa_repo.Hashing;
using dsa_repo.LinkedLists;
using dsa_repo.StacksQueues;
using dsa_repo.Trees;
using dsa_repo.Searching;
using dsa_repo.Sorting;
using dsa_repo.Recursion;

Console.WriteLine("Data Structures and Algorithms:\r\n===============================\r\n");

// === Searching and sorting ===
Console.WriteLine("Searching and Sorting checks:\r\n");

int[] numbers = { 5, 2, 4, 1, 9, 7 };

InsertionSort.Sort(numbers);

Console.WriteLine($"Insertion sort: {string.Join(", ", numbers)}");
Console.WriteLine($"Binary search for 7 (iterative): index {BinarySearch.Search(numbers, 7)}");
Console.WriteLine($"Binary search for 7 (recursive): index {BinarySearch.SearchRecursive(numbers, 7)}");
Console.WriteLine($"Binary search for 3: index {BinarySearch.Search(numbers, 3)}\n");

Console.WriteLine("End of searching and sorting.\r\n===============================\r\n");
// === End of searching and sorting ===

// === Linked list ===
Console.WriteLine("Linked list checks:\r\n");

var list = new MyLinkedList();

list.AddLast(2);
list.AddLast(3);
list.AddFirst(1);
list.Remove(3);

Console.WriteLine($"Linked list: {list} (count {list.Count})\n");

Console.WriteLine("End of linked list.\r\n===============================\r\n");
// === End of linked list ===

// === Stack and queue ===
Console.WriteLine("Stack and queue checks:\r\n");

var stack = new MyStack<string>();

var actions = new[] { "type", "bold", "delete" };

foreach (var action in actions)
{
    stack.Push(action);
}

Console.WriteLine($"Stack pop (undo): {stack.Pop()}, then peek: {stack.Peek()}");


var queue = new IntQueue();

for (int i = 1; i <= 6; i++)
{
    queue.Enqueue(i);
}

Console.WriteLine($"Queue dequeue: {queue.Dequeue()}, {queue.Dequeue()} (count {queue.Count})\n");

Console.WriteLine("End of stack and queue.\r\n===============================\r\n");
// === End of stack and queue ===

// === BST ===
Console.WriteLine("BST checks:\r\n");

var bst = new BST<int>();

var values = new[] { 50, 30, 70, 20, 40, 60, 80 };

foreach (int v in values)
{
    bst.Insert(v);
}

Console.WriteLine($"BST in-order: {string.Join(", ", bst.InOrder())}");
Console.WriteLine($"BST contains 60: {bst.Contains(60)}, contains 65: {bst.Contains(65)}");
Console.WriteLine($"BST height: {bst.Height()}\n");

Console.WriteLine("End of BST.\r\n===============================\r\n");
// === End of BST ===

// === Graph ===
Console.WriteLine("Graph checks:\r\n");

var graph = new Dictionary<string, List<string>>
{
    ["A"] = new() { "B", "C" },
    ["B"] = new() { "D" },
    ["C"] = new() { "D", "E" },
    ["D"] = new() { "F" },
    ["E"] = new() { "F" },
    ["F"] = new() { }
};

Console.WriteLine($"BFS from A: {string.Join(", ", GraphSearch.Bfs(graph, "A"))}\n");

Console.WriteLine("End of graph.\r\n===============================\r\n");
// === End of graph ===

// === Hashing ===
Console.WriteLine("Hashing checks:\r\n");

var pair = HashingExamples.TwoSum(new[] { 2, 7, 11, 15 }, 9);

Console.WriteLine($"TwoSum([2, 7, 11, 15], 9): [{string.Join(", ", pair)}]");
Console.WriteLine($"FirstUnique(\"swiss\"): {HashingExamples.FirstUnique("swiss")}");
Console.WriteLine($"FirstUnique(\"aaab\"): {HashingExamples.FirstUnique("aaab")}\n");

Console.WriteLine("End of hashing.\r\n===============================\r\n");
// === End of hashing ===

// === Recursion ===
Console.WriteLine("Recursion checks:\r\n");

Console.WriteLine($"Factorial(5): {RecursionExamples.Factorial(5)}");
Console.WriteLine($"SumTo(3): {RecursionExamples.SumTo(3)}");

Console.WriteLine("End of recursion.\r\n===============================\r\n");
// === End of recursion ===