int number = int.Parse(Console.ReadLine()); // prodict count 

List<string> products =  new List<string>(); // products

for (int product = 1; product <= number; product++)
{
    string currentProuct = (Console.ReadLine());
    products.Add(currentProuct);
}
products.Sort();

int position = 1;
foreach (string product in products)
{
    Console.WriteLine($"{position}.{product}");
    position++;
}

