class Room
{
    public int width { get; set; }
    public int height { get; set; }
    string[] room { get; set; }
    List<Enemy> enemies { get; set; }
    Sam sam { get; set; }
    Nikoladze n { get; set; }


    public Room(string[] room)
    {
        this.room = room;
        width = room[0].Length;
        height = room.Length;

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

    public void move(string command)
    {
        for (int i = 0; i < command.Length; i++)
        {
            sam.Move(command[i]);
            foreach (Enemy enemy in enemies)
            {
                if (enemy.col == 0 || enemy.col == width - 1)
                { enemy.ChangeDirection(); }
                else
                {
                    enemy.Move();
                    if (enemy.row == sam.row)
                    {
                        if (enemy.col == sam.col) { enemies.Remove(enemy); }
                        if (enemy.col < sam.col && enemy.rightDirection || enemy.col > sam.col && !enemy.rightDirection) { sam.die(); i = command.Length; break; }
                    }
                    else if (n.row == sam.row) { n.die(); i = command.Length; break; }
                }
            }
        }

    }
    public string[] returnRoom()
    {
        string emptyRow = new string('.', width);
        Array.Fill(room, emptyRow);

        for (int i = 0; i < room.Length; i++)
        {
            if (enemies.Any(x => x.row == i))
            { room[i].Replace(room[i][(enemies.Find(x => x.row == i).col)], enemies.Find(x => x.row == i).symbol); }
            if (i == sam.row)
            { room[i].Replace(room[i][sam.col], sam.symbol); }
            if (i == n.row)
            { room[i].Replace(room[i][n.col], n.symbol); }
        }

        return room;
    }
}
