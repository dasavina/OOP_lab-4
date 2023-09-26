Bag trial = new Bag(100);
Gold gold = new Gold("gold", 40);
Gem gem = new Gem("somegem", 30);
Cash cash = new Cash("USD", 10);
trial.items.Add(gold); trial.items.Add(gem); trial.items.Add(cash);
foreach (string str in trial.printItems())
{
    Console.WriteLine(str);
}




int capacity = Convert.ToInt32(Console.ReadLine());
Bag bag = new Bag(capacity);
string[] info = Console.ReadLine().Split(" ");
List<Item> safe = new List<Item>();
for  (int i = 1; i < info.Length; i++)
{    
    Item newItem = new Item(info[i - 1], Convert.ToInt32(info[i]));
    i++;
    newItem = newItem.getType();
    if (!(newItem is null)) { safe.Add(newItem); }
}

bag.SortAndTake(safe);
Console.WriteLine(bag.printItems());

