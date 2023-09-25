int capacity = Convert.ToInt32(Console.ReadLine());
Bag bag = new Bag(capacity);
string[] safe = Console.ReadLine().Split(" ");
for  (int i = 1; i < safe.Length; i++)
{    
    Item newItem = new Item(safe[i - 1], Convert.ToInt32(safe[i]));
    i++;
    newItem = newItem.getType();
    bag.AddItem(newItem);
}
Console.WriteLine(bag.printItems());

