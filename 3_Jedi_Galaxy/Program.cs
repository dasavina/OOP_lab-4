string[] matrixDimensions = Console.ReadLine().Split(" ");
int[,] matrix = new int[Convert.ToInt32(matrixDimensions[0]), Convert.ToInt32(matrixDimensions[1])];
string[] IvoCoords = Console.ReadLine().Split(" ");
List<int[]> evil = new List<int[]>(); 

string inputs = Console.ReadLine();
while (!inputs.Equals("Let the Force be with you"))
{
    string[] evilCoords = inputs.Split(" ");
    int[] toAdd = { Convert.ToInt16(evilCoords[0]), Convert.ToInt16(evilCoords[1]) };
    evil.Add(toAdd);
}

    
