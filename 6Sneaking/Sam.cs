﻿class Sam
{
    public int row { get; set; }
    public int col { get; set; }
    public char symbol { get; set; }
    bool dead { get; set; }

    public Sam(int row, int col)
    {
        this.row = row;
        symbol = 'S';
        this.col = col;
        dead = false;
    }

    public void die()
    {
        symbol = 'X';
        dead = true;
        Console.WriteLine("Sam died at {0}, {1}", row, col);
    }

    public void Move(char command)
    {
        if (!dead)
        {
            switch (command)
            {
                case 'U': { row--; }; break;
                case 'D': { row++; }; break;
                case 'R': { col++; }; break;
                case 'L': { col--; }; break;
                case 'W': { }; break;
                default: { Console.WriteLine("no such command, wait instead"); }; break;

            }
        }


    }
}