class Room
{
    public int width { get; set; }
    public int height { get; set; }
    char[] room {  get; set; }
    List<Enemy> enemies { get; set; }
    Sam sam { get; set; }

    public Room(char[] room)
    {
        this.room = room;
    }
}