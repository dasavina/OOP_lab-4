class Doctor
{
    public string name { get; set; } = "none";
    public string surname { get; set; } = "none";
    public List<Patient> patients { get; set; }

    public string GetPatients()
    {
        string result="";
         foreach (Patient pat in patients)
        {
            result += pat.name + "\n";
        }
         return result;
    }

    public Doctor(string name, string surname)
    {
        this.name = name;
        this.surname = surname;
        patients = new List<Patient>();
    }
}