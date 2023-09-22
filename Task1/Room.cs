class Room
{
    public List<Patient> patients { get; set; } = new List<Patient>(3);

    public bool hasFreeBed()
    {
        return (patients.Count() < 3); 
    }

    public Room(List<Patient> patients)
    {
        this.patients = patients;
        
    }
}
