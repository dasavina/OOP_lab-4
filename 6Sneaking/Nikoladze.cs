class Nikoladze
{

    public int row { get; set; }
    public char symbol { get; set; } = 'N';
    public void die()
    {
        symbol = 'X';
    }

    public Nikoladze(int row)
    {
        this.row = row;
        symbol = 'N';
    }
}