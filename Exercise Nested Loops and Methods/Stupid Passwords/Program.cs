int number = int.Parse(Console.ReadLine());

for (int even = 2; even <= number; even++)
{
    if (even % 2 == 0)
    {
        for (int odd = 1; odd <= number; odd++)
        {
            if (odd % 2 != 0)
            {
                Console.Write($"{even}{odd}{odd * even} ");
            }
            
            
        }
    }
}
        
    

        //for (int even = 2; even <= number; even += 2)
        //{

        //    for (int odd =1; odd <= number; odd+= 2)
        //    {
        //        Console.Write($"{even}{odd}{odd * even} ");
        //    }
    


   