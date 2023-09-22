using System.Xml.Linq;

class Department
{
    public string Name
    {
        get { return Name; }
        set { if (value.Length > 20) { Name = value.Substring(0, 20); } else { Name = value; } }
    }
    public List<Room> rooms { get; set; } = new List<Room>(0);

    public bool canFit()
    {
        foreach (Room room in rooms)
        { if (room.hasFreeBed())
                { return true;}
        }
        return false;
        
    }

    public List<Patient> fromRoom(int number)
    {
        return rooms[number].patients;
    }

    public Room? firstToFitIn()
    {
        foreach (Room room in rooms)
        { if (room.hasFreeBed()) return room; }
        return null;
    }

    public Department(string name)
    {
        Name = name;
        rooms = new List<Room>(20);
    }
}