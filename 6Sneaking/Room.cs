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
            { Enemy enemy = new Enemy(i, room[i].IndexOf('d'), 'd'); enemies.Add(enemy); }
            else if (room[i].Contains('b'))
            { Enemy enemy = new Enemy(i, room[i].IndexOf('b'), 'b'); enemies.Add(enemy); }
            else if (room[i].Contains('N'))
            { n = new Nikoladze(i, room[i].IndexOf('N')); }
        }


    }

    public void move(char command)
    {

        sam.Move(command);
        foreach (Enemy enemy in enemies)
        {
            
            
                if ((!enemy.dead) &&(enemy.col == 0 || enemy.col == width - 1 ))
                { enemy.ChangeDirection(); }
                else
                {
                    enemy.Move();
                    if (enemy.row == sam.row)
                    {
                        if (enemy.col == sam.col) { enemy.die(); }
                        if ((enemy.col < sam.col && enemy.rightDirection || enemy.col > sam.col && !enemy.rightDirection) && (!enemy.dead)) { sam.die(); break; }
                    }
                    else if (n.row == sam.row) { n.die(); break; }
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
                Room[i] = Room[i].Remove(enemies.Find(x => x.row == i).col);
                Room[i] = Room[i].Insert(enemies.Find(x => x.row == i).col, enemies.Find(x => x.row == i).symbol.ToString());
            }
            if (i == sam.row)
            {
                Room[i] = Room[i].Remove(sam.col);
                Room[i] = Room[i].Insert(sam.col, sam.symbol.ToString());
            }
            if (i == n.row)
            {
                Room[i] = Room[i].Remove(n.col);
                Room[i] = Room[i].Insert(n.col, n.symbol.ToString());
            }

            Console.WriteLine(Room[i]);
        }


    }
}