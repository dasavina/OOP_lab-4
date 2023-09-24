

class IvoDiagonal : _3_Jedi_Galaxy.Diagonal
{
    public IvoDiagonal(int matrixLength, int matrixHeight, int[,] matrix, string[] startingCoords) : base(matrixLength, matrixHeight, matrix, startingCoords)
    {
    }

    public int findSum(List <EvilDiagonal> evilDiagonals)
    {
        int sum = 0;

        bool[,] destroyed = new bool[matrixLength, matrixHeight]; 
        foreach (EvilDiagonal evilDiagonal in evilDiagonals)
        {
            destroyed = evilDiagonal.Destroy(destroyed);
        }
        for (int i = Convert.ToInt32( startingCoords[0]) +1; i<matrixLength; i++)
        {
            for (int j = Convert.ToInt32(startingCoords[1]) -1; j>=0; j--)
            {
                if (!destroyed[i,j])
                sum += i + (j * matrixLength);
            }
        }

        return sum;
    }



}

 class EvilDiagonal : _3_Jedi_Galaxy.Diagonal
{
    public EvilDiagonal(int matrixLength, int matrixHeight, int[,] matrix, string[] startingCoords) : base(matrixLength, matrixHeight, matrix, startingCoords)
    {
    }

    public bool[,] Destroy(bool[,] destroyed)
    {
       
        for (int i = Convert.ToInt32(startingCoords[0]) - 1; i < matrixLength; i++)
        {
            for (int j = Convert.ToInt32(startingCoords[1]) - 1; j >= 0; j--)
            {
                destroyed[i,j] = true;
            }
        }
        return destroyed;

    }

}