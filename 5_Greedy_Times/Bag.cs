class Bag
{
    public int capacity { get; set; }
    List<Item> items
    {
        get; set;
    }


    public Bag(int capacity)
    {
        this.capacity = capacity;
        items = new List<Item>();
    }

    public void AddItem(Item item)
    { items.Add(item);}

    public void SortAndRemove()
    {
        int goldCount, gemCount, cashCount;
        //sort by Type; goldcount++; capacity-- till capacity is less than gold; continue the same with gems, add to if gemcount<=goldcount, same with cashcount
    }

    public List<string> printItems()
    {
        List<string> result  = new List<string>();
        items.OrderBy(x => x.priority);
        int[] total = new int[3];
        total[0] = items[0].value;
        int totalcounter = 0;
        int newTypePosition = 0;
        for (int i = 1; i < items.Count; i++)
        {
            if (items[i].GetType().Equals(items[i-1].GetType()))
            {
                total[totalcounter] += items[i].value;
                if (!(items[i].getType() is Gold))
                { string toAdd = String.Format("\n\t##{0} - ${1}", items[i].name, (items[i].value) );  result.Add( toAdd ); }

            }
            else
            {
                if (items.GetType() is Gold)
                {string goldInsertion = String.Format("\n<{0}>  ${1}", items[i - 1].name, total[totalcounter]);
                    result.Insert(newTypePosition, " ");
                }
                string insertion = String.Format("\n<{0}>  ${1}", items[i-1].GetType, total[totalcounter]);
                result.Insert(newTypePosition, insertion);

                newTypePosition = result.Count;
                totalcounter++;
            }

        }



        return result;
    }
}