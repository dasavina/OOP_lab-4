class Enemy
{
    public int row { get; set; }
    public int col { get; set; }
    public bool rightDirection { get; set; }
    public char symbol { get; set; }

    public Enemy(int row, int col, char symbol)
    {
        this.row = row;
        this.col = col;
        this.symbol = symbol;
        if (symbol == 'b')
        { rightDirection = true; }
        else { rightDirection = false; }
    }

    public void ChangeDirection()
    {
        if (rightDirection)
        { symbol = 'b'; }
        else { symbol = 'd'; }
        
    }

    public void Move()
    {
        if (rightDirection) { col += 1; }
        else { col -= 1; }
    }
}