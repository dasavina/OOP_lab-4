class Hospital
{
    public List<Department> departments { get; set; }
    public List<Doctor> doctors { get; set; }

    public void addPatient(string[] patientInfo)
    {

        //dep name surname patientName
        Department department = new Department(patientInfo[0]);
        Doctor doctor = new Doctor(patientInfo[1], patientInfo[2]);

        Patient patient = new Patient(patientInfo[3], doctor, department);

        int departmentIndex, doctorIndex;

        if (!departments.Any(x => x.Name.Equals(patientInfo[0])))
        {
           
            departments.Add(department);
            departmentIndex =departments.IndexOf(department);
        }
        else
        {
            departmentIndex = departments.IndexOf(departments.Find(x => x.Equals(department)));
        }

        if (departments[departmentIndex].canFit())
        {
            departments[departmentIndex].firstToFitIn().patients.Add(patient);


            if (!doctors.Any(x => x.Equals(doctor)))
            {
               doctors.Add(doctor);
                doctorIndex = doctors.IndexOf(doctor);
            }
            else
            {
                doctorIndex = doctors.IndexOf(doctors.Find(x => x.Equals(doctor)));
            }
            doctors[doctorIndex].patients.Add(patient);

        }
        else
        { Console.WriteLine("no space left"); }

    }
}