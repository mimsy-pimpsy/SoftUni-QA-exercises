//12,22,34,56,67
int[] numbers = { 12, 22, 34, 56, 67 };

//all numbers have specific positions called index --> index 0 -->12
// index 1-->22 etc.

//lentgh of array == count of characters==5

Console.WriteLine(numbers.Length);

// first charater of aray 
Console.WriteLine(numbers[0]);
// last character of array 
Console.WriteLine(numbers.Length - 1);

//get 10 int numbers
int[] prices = new int[10];
prices[0] = 5;
prices[1] = 34;
prices[2] = 56;
prices[3] = 98;

for ( int index = 0; index <=prices.Length- 1;  index++)
{
    Console.WriteLine(prices[index]); 
}


