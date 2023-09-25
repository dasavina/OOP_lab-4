﻿class Item
{
    public string name {  get; set; }
    public int value {  get; set; }
    public int priority {  get; set; }
    public Item getType(Item item)
    {
        if (item.name.Equals("gold", StringComparison.OrdinalIgnoreCase))
        {
            Gold gold = new Gold(item.name, item.value);
            return gold;
        }
        else if (item.name.Length==3)
        {
            Gem gem = new Gem(item.name, item.value);
            return gem;

        }
        else if (item.name.EndsWith("gem", StringComparison.OrdinalIgnoreCase))
        {
            Cash cash = new Cash(item.name, item.value);
            return cash;
        }
        else
        {
            return null;
        }
    }

    public Item(string name, int value)
    {
        this.name = name;
        this.value = value;
    }
}

class Gold : Item
{
    public string name { get;} = "gold";
    public int priority { get; } = 1;

    public Gold(string name, int value) : base(name, value)
    { }
}
class Gem : Item
{
    public int priority { get; } = 2;
    public Gem(string name, int value) : base(name, value )
    { }
}

class Cash : Item
{
    public int priority { get; } = 3;
    public Cash(string name, int value) : base(name, value)
    { }
}

