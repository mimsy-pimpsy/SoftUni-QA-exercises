using System.Linq.Expressions;
using System.Windows.Input;

string command = Console.ReadLine();
List<Box>boxes = new List<Box>();

while  (command != "end") //"{Serial Number} {Item Name} {Item Quantity} {itemPrice}
{
 string[] boxInfo = command.Split(" ");
    
    string serialNumber = boxInfo[0];
    string itemName = boxInfo[1];
    int itemQuantity = int.Parse(boxInfo[2]);
    decimal itemPrice = decimal.Parse(boxInfo[3]);

    Item currentItem = new Item(itemName, itemPrice);
    Box currentBox = new Box(serialNumber, currentItem, itemQuantity);

    boxes.Add(currentBox);

    command = Console.ReadLine();
}
boxes = boxes.OrderByDescending(box => box.PriceForABox).ToList();  

foreach (Box box in boxes)
{
    Console.WriteLine($"{box.SerialNumber}");
    Console.WriteLine($"-- {box.Item.Name:F2} - ${box.Item.Price:F2}: {box.ItemQuantity}");
    Console.WriteLine($"-- ${box.PriceForABox:F2}");
}

public class Item
{
    public Item(string name, decimal price)
    {
        Name = name;
        Price = price;
    }
    public string Name { get; set; }
    public decimal Price { get; set; }
}
public class Box
{
    public Box(string serialNumber, Item item, int itemQuantity)
    {
        SerialNumber = serialNumber;
        Item = item;
        ItemQuantity = itemQuantity;
        PriceForABox = item.Price * itemQuantity;

    }

    public string SerialNumber { get; set; }
    public Item Item { get; set; }
    public int ItemQuantity { get; set; }
    public decimal PriceForABox { get; set; }

}





