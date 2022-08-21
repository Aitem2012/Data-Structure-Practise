// See https://aka.ms/new-console-template for more information

var myLinked = new LinkedList.LinkedList<int>();

myLinked.AddTail(1);
myLinked.AddHead(2);
myLinked.AddTail(3);
myLinked.AddHead(4);
myLinked.AddTail(5);
Console.WriteLine("Before removal");
myLinked.List();
Console.WriteLine("After removal");
myLinked.RemoveHead();
myLinked.List();
Console.WriteLine("After tail removal");
myLinked.RemoveTail();
myLinked.List();

Console.WriteLine(myLinked.Contains(1));
//Console.WriteLine(myLinked.Count);