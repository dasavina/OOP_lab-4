string[] matrixDimensions = Console.ReadLine().Split(" ");
int[,] matrix = new int[Convert.ToInt32(matrixDimensions[0]), Convert.ToInt32(matrixDimensions[1])];
string[] IvoCoords = Console.ReadLine().Split(" ");
IvoDiagonal Ivo = new IvoDiagonal(matrixLength: Convert.ToInt32(matrixDimensions[0]), matrixHeight:Convert.ToInt32(matrixDimensions[1]), matrix, IvoCoords);
List<EvilDiagonal> evils = new List<EvilDiagonal>(); 

string inputs = Console.ReadLine();
while (!inputs.Equals("Let the Force be with you"))
{
    string[] evilCoords = inputs.Split(" ");
    EvilDiagonal toAdd = new EvilDiagonal(matrixLength: Convert.ToInt32(matrixDimensions[0]), matrixHeight: Convert.ToInt32(matrixDimensions[1]), matrix, evilCoords);
    evils.Add(toAdd);
    inputs = Console.ReadLine();
}

Console.WriteLine(Ivo.findSum(evils));
    
