class Safe
{
    List<Item> items
    {
        get; set;
    }

    public Safe()
    {
        items = new List<Item>();
    }

    public void AddItem(Item item)
    { items.Add(item); }
    public Bag SortAndTake(Bag bag)
    {
        int goldCount = 0, gemCount = 0, cashCount = 0;
        items.OrderBy(x => x.priority).ThenBy(x => x.value);
        //sort by Type; goldcount++; capacity-- till capacity is less than gold; continue the same with gems, add to if gemcount<=goldcount, same with cashcount
        for (int i = 1; i < items.Count; i++)
        {
            if (items[i].GetType() is Gold && bag.capacity > 0)
            {
                bag.AddItem(items[i]);
                goldCount += items[i].value;
                bag.capacity-= items[i].value;
            }
            else if (items[i].GetType() is Gem && (bag.capacity-= items[i].value) > 0 && (gemCount += items[i].value) <= goldCount)
            {
                bag.AddItem(items[i]);
                gemCount += items[i].value;
                bag.capacity-= items[i].value; ;
            }
            else
            {
                if ((bag.capacity -= items[i].value) > 0 && (cashCount+= items[i].value) <= gemCount)
                {
                    bag.AddItem(items[i]);
                    cashCount += items[i].value;
                    bag.capacity -= items[i].value;
                }
            }

            

        }
        return bag;
    }

}