
namespace _3_Jedi_Galaxy
{
    class Diagonal
    {
       
            public int matrixLength { get; set; }
            public int matrixHeight { get; set; }
            public int[,] matrix { get; set; }
            public string[] startingCoords { get; set; }

        public Diagonal(int matrixLength, int matrixHeight, int[,] matrix, string[] startingCoords)
        {
            this.matrixLength = matrixLength;
            this.matrixHeight = matrixHeight;
            this.matrix = matrix;
            this.startingCoords = startingCoords;
        }
    }
}
