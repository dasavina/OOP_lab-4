class Patient
{
    public string name { get; set; } = "none";
    public Doctor? doctor { get; set; } = default;
    public Department? department { get; set; } = default;

    public Patient(string name, Doctor? doctor, Department? department)
    {
        this.name = name;
        this.doctor = doctor;
        this.department = department;
    }
}