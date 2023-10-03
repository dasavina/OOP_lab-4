int rows = Convert.ToInt32( Console.ReadLine() );
string[] matrix =  new string[rows];
for ( int i = 0; i < rows; i++ )
{
    matrix[i] = Console.ReadLine();
}
string directions = Console.ReadLine();
Room room = new Room(matrix);

for ( int i = 0;i < directions.Length; i++ )
{
    room.move(directions[i]);
    if (room.sam.symbol.Equals('X') || room.n.symbol.Equals('X')) break;
}

room.returnRoom();