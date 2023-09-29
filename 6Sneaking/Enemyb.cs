class Enemyb
{
    public int row { get; set; }
    public int col { get; set; }
    public bool rightDirection { get; set; }
    public char symbol { get; set; }

    public void ChangeDirection()
    {
        if (rightDirection)
        { symbol = 'b'; }
        else { symbol = 'd'; }
        
    }
}