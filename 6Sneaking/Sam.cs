class Sam
{
    public int row { get; set; }
    public int col { get; set; }
    public string[] commands { get; set; }
    public char symbol { get; set; } = 'S';

    public Sam(int row, int col)
    {
        this.row = row;
        symbol = 'S';
        this.col = col;
    }

    public void KillEnemy()
    {

    }

    public void KillNikoladze()
    {

    }

    public void die()
    {
        symbol = 'X';
    }
}