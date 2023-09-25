int capacity = Convert.ToInt32(Console.ReadLine());
Bag bag = new Bag(capacity);
Safe safe = new Safe();
string[] info = Console.ReadLine().Split(" ");
for  (int i = 1; i < info.Length; i++)
{    
    Item newItem = new Item(info[i - 1], Convert.ToInt32(info[i]));
    i++;
    newItem = newItem.getType();
    safe.AddItem(newItem);
}
bag = safe.SortAndTake(bag);
Console.WriteLine(bag.printItems());

