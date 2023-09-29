class Bag
{
    public int capacity { get; set; }
    public List<Item> items
    {
        get; set;
    }


    public Bag(int capacity)
    {
        this.capacity = capacity;
        items = new List<Item>();
    }

    public void SortAndTake(List<Item> safeItems)
    {
        int initialCapacity = capacity;
        int goldCount = 0, gemCount = 0, cashCount = 0;
        safeItems.OrderBy(x => x.priority).ThenBy(x => x.value);
        
        for (int i = 0; i < safeItems.Count; i++)
        {
            if (safeItems[i].priority==3 && capacity > 0)// через пріоритет і у методі виводу теж
            {
                items.Add(safeItems[i]);
                goldCount += safeItems[i].value;
                capacity -= safeItems[i].value;
            }
            else if (safeItems[i].priority ==2 && (capacity -safeItems[i].value) > 0 && (gemCount + safeItems[i].value) <= goldCount)
            {
                items.Add(safeItems[i]);
                gemCount += safeItems[i].value;
                capacity -= safeItems[i].value; ;
            }
            else
            {
                if ((capacity - safeItems[i].value) > 0 && (cashCount + safeItems[i].value) <= gemCount)
                {
                    items.Add(safeItems[i]);
                    cashCount += safeItems[i].value;
                    capacity -= safeItems[i].value;
                }
            }



        }
        capacity = initialCapacity;

    }


    public List<string> printItems()
    {
        List<string> result  = new List<string>();
        items.OrderBy(x => x.priority).ThenBy(x => x.value);
        int[] total = { 0, 0, 0 };
        total[0] = items[0].value;
        int totalcounter = 0;
        int newTypePosition = 0;
        for (int i = 1; i < items.Count; i++)
        {
            if (items[i].priority.Equals(items[i-1].priority))
            {
                total[totalcounter] += items[i].value;
                if (!(items[i].priority==3))
                { string toAdd = String.Format("\n\t##{0} - ${1}", items[i].name, items[i].value );  result.Add( toAdd ); }

            }
            else
            {
                if (items[i - 1].priority == 3)
                {string goldInsertion = String.Format("\n<{0}>  ${1}", items[i - 1].name, total[totalcounter]);
                    result.Insert(newTypePosition, goldInsertion);
                }
                string insertion = String.Format("\n<{0}>  ${1}", items[i-1].GetType(), total[totalcounter]);
                result.Insert(newTypePosition, insertion);

                newTypePosition = result.Count;
                totalcounter++;
            }

        }



        return result;
    }
}