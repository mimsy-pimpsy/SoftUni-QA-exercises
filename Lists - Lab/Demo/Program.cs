// 3, 45, 67, 89
List<int> numbers = new List<int>(); // empty list 

//add element to List
numbers.Add(69); // was added to the first free position of the list /last position /
numbers.Add(34);
numbers.Add(62);
numbers.Add(89);

//get the list's size
//arrays have length ,but lists have size/count

Console.WriteLine(numbers.Count);

//first element of the list is always on the  0 index
Console.WriteLine(numbers[0]);

//last element

Console.WriteLine(numbers[numbers.Count - 1]);

//remove element from List
numbers.Remove(62);

List<int> numbers2 = new List<int>() { 3, 4, 5, 6 };
numbers2.Add(3);
numbers2.Add(4);
numbers2.Add(35);
numbers2.Add(32);
numbers2.Add(30);
// inert an element to an specific index
numbers.Insert(1, 245);
numbers2.Insert(2, 378);
// heck if a specific elemnt is in th list
Console.WriteLine(numbers.Contains(123));
numbers.Add(123);
Console.WriteLine(numbers.Contains(123));

int result = numbers[0] + numbers[4];
Console.WriteLine(result);
// print a list
//1. for loop--> when we need the indices ot the elements
for (int index = 0; index < numbers.Count; index++)
{
    Console.WriteLine(numbers[index]);
}
//2.foreach loop --> indices does not matter
foreach (int number in numbers2)
{
    Console.WriteLine(number);
}
//3. string.Join
Console.WriteLine(string.Join(" ", numbers));

// Arrays vs Lists
//1. array--> when e have an aggregate of common elements, which wiil not be modified

int[] numbersArray = { 2, 3, 4, 5, 6, };

//2. list--> when we need an aggregate of elements, that need to be modified /remove, add, insert etc/
List<int> prices = new List<int>() { 3, 2, 13, 9, 34 };
// sorts th list in ascending order
//{ 3, 2, 13, 9, 34 };
// prices.Sort(); // --> {2,3,9 ,13, 34}
//how to sot in descending order 
prices.Sort();
Console.WriteLine(string.Join(" ", prices));
prices.Reverse();
Console.WriteLine(string.Join(" ", prices)) ;

List<string> names = new List<string>() { "Ivan", "Georgi", "Anatoli", "Stefan", "Pesho" };
names.Sort();
Console.WriteLine(string.Join(" ", names)); // alpahbetical







