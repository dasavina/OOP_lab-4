int rows = Convert.ToInt32(Console.ReadLine());
string[] matrix = new string[rows];
matrix[0] = Console.ReadLine();
for (int i = 1; i < rows; i++)
{
    string row = Console.ReadLine();
    if (row.Length != matrix[0].Length)
    { Console.WriteLine("Room is not rectangular"); Environment.Exit(0); }
    else matrix[i] = row;
}
string directions = Console.ReadLine();
Room room = new Room(matrix);

room.move(directions);

if (!(room.sam.symbol.Equals('X') || room.n.symbol.Equals('X')))
{ Console.WriteLine("not enough commands"); Environment.Exit(0); }

room.returnRoom();