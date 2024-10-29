using _010_StrategyExample;

Context context = new Context();

Console.WriteLine("Shuffled Array");
context.PrintArray();

context.Sort(new SelectionSort());
Console.WriteLine("After Selection Sort");
context.PrintArray();

context.Shuffle();
Console.WriteLine("Shuffled Array");
context.PrintArray();

context.Sort(new BubbleSort());
Console.WriteLine("After Bubble Sort");
context.PrintArray();