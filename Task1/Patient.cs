class Patient
{
    public string name { 
        get { return name; }
        set { if (value.Length > 20) { name = value.Substring(0, 20); } else { name = value; } }
    }
    public Doctor? doctor { get; set; } = default;
    public Department? department { get; set; } = default;

    public Patient(string name, Doctor? doctor, Department? department)
    {
        this.name = name;
        this.doctor = doctor;
        this.department = department;
    }
}