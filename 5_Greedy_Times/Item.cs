class Item
{
    public string name {  get; set; }
    public int value {  get; set; }
    public int priority {  get; set; }
    public Item getType()
    {
        if ( name.Equals("gold", StringComparison.OrdinalIgnoreCase))
        {
            Gold gold = new Gold(  name, value);
            return gold;
        }
        else if ( name.Length==3)
        {
            Gem gem = new Gem(name, value);
            return gem;

        }
        else if (name.EndsWith("gem", StringComparison.OrdinalIgnoreCase))
        {
            Cash cash = new Cash(name, value);
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


