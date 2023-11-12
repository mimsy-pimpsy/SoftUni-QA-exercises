namespace ConditionalAndNestedConditional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            string operation = Console.ReadLine();

            int result = 0;
            string remainder = "";

            switch (operation)
            {
                case "+":
                case "-":
                case "*":
                    switch (operation)
                    {
                        case "+":
                            result = firstNumber + secondNumber; break;
                        case "-":
                            result = firstNumber - secondNumber; break;
                        case "*":
                            result = firstNumber * secondNumber; break;

                    }
                    if (result % 2 == 0)
                    {
                        remainder = "even";
                    }
                    else
                    {
                        remainder = "odd";
                    }
                    Console.WriteLine($"{firstNumber} {operation} {secondNumber} = {result} - {remainder}"); break;
                case "%":
                case "/":
                    if (secondNumber != 0)
                    {
                        if (operation == "/")
                        {
                            double doubledResult = (firstNumber * 1.0) / secondNumber;
                            Console.WriteLine($"{firstNumber} / {secondNumber} = {doubledResult:f2}");
                        }
                        else
                        {
                            Console.WriteLine($"{firstNumber} % {secondNumber} = {firstNumber % secondNumber}");
                        }

                    }
                    else
                    {
                        Console.WriteLine($"Cannot divide {firstNumber} by zero");
                    } break;
                    
            }
        }


        }
}