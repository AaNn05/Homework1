using Homework1;

int[] array = { 64, 34, 25, 12, 22, 11, 90 };

int[] arr = { 65, 35, 26, 13, 13, 12, 91 };

SortingAlgorithms.SelectionSort(array);
SortingAlgorithms.PrintArray(array);

Console.WriteLine();

SortingAlgorithms.InsertionSort(arr);
SortingAlgorithms.PrintArray(arr);

Console.WriteLine();
Console.WriteLine();

CustomQueue<int> Queue = new CustomQueue<int>();

Queue.EnQueue(2);
Queue.EnQueue(25);
Queue.EnQueue(20);
Queue.EnQueue(21);
Queue.EnQueue(22);

Queue.DeQueue();
Queue.DeQueue();
Queue.DeQueue();
   
Console.WriteLine(Queue.Peek());