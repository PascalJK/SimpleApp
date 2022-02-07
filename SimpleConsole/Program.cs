using SimpleConsole;

// Common
var numbers = Test.Add(new int[] { 1, 2, 3, 4, 5, 6, 0 });
// Cleaner
var nums = Test.Add(1, 2, 3, 4, 5, 6, 0 );

var person = new Person(new(1998, 06, 18));

//023 Up+down casting
Base baseC = person;
person.Shape = "round";
baseC.Shape = "oval";

// downcating demos

object sender = person;
// Use this when you're sure of the object class
var person1 = (Person)sender;
Console.WriteLine($"\n{person1.BirthDate}");
// else if you are ! sure use this
var person2 = sender as Test;
if (person2 != null)
    Console.WriteLine("\ndownCating passed.");
else
    Console.WriteLine("\ndownCasting failed.");

Console.WriteLine($"Shape == {person.Shape}\n");

// Indexers
var cookie = new HttpCookie();
Console.WriteLine("Indexers:");
cookie["name"] = "Pascal";
Console.WriteLine($"My name is {cookie["name"]} and my age is {person.Age}");

//Ex uno
var stopWatch = new Stopwatch();
Thread.Sleep(1100);
Console.WriteLine("\n\nEx uno:");
Console.WriteLine($"Elapsed time = {stopWatch.Duration}");

// Ex dois
Console.WriteLine("\n\nEx dois:");
var post = new Post();
post.UpVote();
Console.WriteLine($"1.Votes: {post.Votes}");
post.DownVote();
Console.WriteLine($"2.Votes: {post.Votes}");
post.DownVote(3);
Console.WriteLine($"3.Votes: {post.Votes}");
post.DownVote(8);
Console.WriteLine($"4.Votes: {post.Votes}");
post.UpVote();
Console.WriteLine($"5.Votes: {post.Votes}");

Console.WriteLine("\n\nmethod params:");
Console.WriteLine(numbers);
Console.WriteLine(nums);

// Playing
Test.Names("Pascal", "Jhon", "Liz", "James", "Sharon", "DizzyTree");
Console.ReadKey();
