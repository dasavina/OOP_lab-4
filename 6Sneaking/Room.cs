class Room
{
    public int width { get; set; }
    public int height { get; set; }
    public string[] room { get; set; }
    List<Enemy> enemies { get; set; }
    public Sam sam { get; set; }
    public Nikoladze n { get; set; }



    public Room(string[] room)
    {
        this.room = room;
        width = room[0].Length;
        height = room.Length;
        enemies = new List<Enemy>();

        for (int i = 0; i < room.Length; i++)
        {
            if (room[i].Contains('S'))
            { sam = new Sam(i, room[i].IndexOf('S')); }
            else if (room[i].Contains('d'))
            {
                Enemy enemy = new Enemy(i, room[i].IndexOf('d'), 'd');
                enemies.Add(enemy);

            }
            else if (room[i].Contains('b'))
            { Enemy enemy = new Enemy(i, room[i].IndexOf('b'), 'b'); enemies.Add(enemy); }
            else if (room[i].Contains('N'))
            { n = new Nikoladze(i, room[i].IndexOf('N')); }
        }

        if (sam.row == n.row)
        { throw new Exception("Nikoladze and Sam are on the same row"); }

    }

    public void move(string directions)
    {
        enemies.OrderBy(x => x.row);
        if (sam.row > n.row)
        {
            enemies.Reverse();
        }

        for (int i = 0; i < directions.Length; i++)
        {
            sam.Move(directions[i]);
            if (sam.symbol.Equals('X') || n.symbol.Equals('X'))
            { break; }


            if (sam.row > height || sam.row < 0 || sam.col < 0 || sam.col > width)
            { Console.WriteLine("out of room!"); Environment.Exit(0); }

            for (int j = 0; j < enemies.Count; j++)
            {

                if (enemies[j].col == 0 && !enemies[j].rightDirection || enemies[j].col == width - 1 && enemies[j].rightDirection)
                { enemies[j].ChangeDirection(); }
                else
                { enemies[j].Move(); }

                if (enemies[j].row == sam.row)
                {
                    if (enemies[j].col == sam.col)
                    { enemies[j].die(); }
                    else if ((enemies[j].col < sam.col && enemies[j].rightDirection || enemies[j].col > sam.col && !enemies[j].rightDirection)
                        && (!enemies[j].dead))
                    { sam.die(); break; }
                }
                else if (n.row == sam.row)
                { n.die(); break; }

            }
        }

    }
    public void returnRoom()
    {
        string emptyRow = new string('.', width);
        string[] Room = new string[height];
        Array.Fill(Room, emptyRow);

        for (int i = 0; i < height; i++)
        {

            if (enemies.Any(x => x.row == i))
            {
                Room[i] = Room[i].Remove(enemies.Find(x => x.row == i).col, 1);
                Room[i] = Room[i].Insert(enemies.Find(x => x.row == i).col, enemies.Find(x => x.row == i).symbol.ToString());
            }
            if (i == sam.row)
            {
                Room[i] = Room[i].Remove(sam.col, 1);
                Room[i] = Room[i].Insert(sam.col, sam.symbol.ToString());
            }
            if (i == n.row)
            {
                Room[i] = Room[i].Remove(n.col, 1);
                Room[i] = Room[i].Insert(n.col, n.symbol.ToString());
            }

            Console.WriteLine(Room[i]);
        }


    }
}