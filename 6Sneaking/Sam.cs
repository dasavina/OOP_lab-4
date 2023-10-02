class Sam
{
    public int row { get; set; }
    public int col { get; set; }
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

    public void Move(char command)
    {
        switch (command)
        {
            case 'U': { row--; }; break;
            case 'D': { row++; }; break;
            case 'R': { col++; }; break;
            case 'L': { col--; }; break;
            case 'W': { }; break;
            default: { }; break;

        }


    }
}