List<int> input = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

List<int> output = new List<int>();


for (int i = 0; i < input.Count / 2; i++) // 1,2,3,4,5,6,7 --> 7/2 =3 --> loop will continue until i = 2 < 3
{
    int sum = input[0 + i] + input[input.Count - 1 - i]; // 1. 0 + 0 + input[7-1-0]--> number at 0. position + number at 6. position= 7==>
    output.Add(sum);                                                    // 1 + 7 =8 
                                                         // 2.number at position [ 0+1] -> 2  + number at position [6-1] ->5 ==> 2+6= 8
                                                         // 3. number at position [0 + 2]->3 + number at position [6 -2]->4 ==>3+4=7
                                                         // number i == 3 loop should break


}
Console.WriteLine(string.Join(" ", output));


