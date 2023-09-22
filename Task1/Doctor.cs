using System.Xml.Linq;

class Doctor
{
    public string name
    {
        get { return name; }
        set { if (value.Length > 20) { name = value.Substring(0, 20); } else { name = value; } }
    }
    public string surname
    {
        get { return surname; }
        set { if (value.Length > 20) { surname = value.Substring(0, 20); } else { surname = value; } }
    }
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