class Nikoladze
{

    public int row { get; set; }
    public int col { get; set; }
    public char symbol { get; set; }
    public void die()
    {
        symbol = 'X';
        Console.WriteLine("Nikoladze died");
    }

    public Nikoladze(int row, int col)
    {
        this.row = row;
        this.col = col;
        symbol = 'N';
    }
}