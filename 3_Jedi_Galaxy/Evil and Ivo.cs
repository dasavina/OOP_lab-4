

class IvoDiagonal : _3_Jedi_Galaxy.Diagonal
{

    int[] startingCoords {  get; set; }
    
    public int findSum(List <EvilDiagonal> evilDiagonals)
    {
        int sum = 0;

        bool[,] destroyed = new bool[matrixLength, matrixHeight]; 
        foreach (EvilDiagonal evilDiagonal in evilDiagonals)
        {
            destroyed = evilDiagonal.Destroy(destroyed);
        }
        for (int i = startingCoords[0] +1; i<matrixLength; i++)
        {
            for (int j = startingCoords[1] -1; j>=0; j--)
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

    int[] startingCoords { get; set; }

    public bool[,] Destroy(bool[,] destroyed)
    {
       
        for (int i = startingCoords[0] - 1; i < matrixLength; i++)
        {
            for (int j = startingCoords[1] - 1; j >= 0; j--)
            {
                destroyed[i,j] = true;
            }
        }
        return destroyed;

    }

}