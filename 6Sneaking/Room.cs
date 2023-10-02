class Room
{
    public int width { get; set; }
    public int height { get; set; }
    string[] room {  get; set; }
    List<Enemy> enemies { get; set; }
    Sam sam { get; set; }
    Nikoladze n {  get; set; }

 
    public Room(string[] room)
    {
        this.room = room;
        width = room[0].Length;
        height = room.Length;

        for (int i = 0; i<room.Length; i++)
        {
            if (room[i].Contains('S'))
            { sam = new Sam(i, room[i].IndexOf('S')); }
            else if (room[i].Contains('d'))
            { Enemy enemy = new Enemy(i, room[i].IndexOf('d'), 'd'); enemies.Add(enemy); }
            else if (room[i].Contains("b"))
            { Enemy enemy = new Enemy(i, room[i].IndexOf('b'), 'b'); enemies.Add(enemy); }
            else if (room[i].Contains("N"))
            { n = new Nikoladze(i); }
        }


    }

}