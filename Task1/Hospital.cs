class Hospital
{
    public List<Department> departments { get; set; }
    public List<Doctor> doctors { get; set; }

    public List<Patient> patients { get; set; }

    public void addPatient(string[] patientInfo)
    {

        //dep name surname patientName
        Department department = new Department(patientInfo[0]);
        Doctor doctor = new Doctor(patientInfo[1], patientInfo[2]);

        Patient patient = new Patient(patientInfo[3], doctor, department);
        if (patients.Any(x=> x.Equals(patient)))
        {
            Console.WriteLine("patient is already included");

        }
        else
        {
            patients.Add(patient);

            int departmentIndex;

            if (!departments.Any(x => x.Name.Equals(patientInfo[0])))
            {

                departments.Add(department);
                departmentIndex = departments.IndexOf(department);
            }
            else
            {
                departmentIndex = departments.IndexOf(departments.Find(x => x.Equals(department)));
            }

            if (departments[departmentIndex].canFit())
            {
                departments[departmentIndex].firstToFitIn().patients.Add(patient);
            }
            else
            { Console.WriteLine("no space left"); }
        }

    }

    public List<Patient> output(string[] parameters)
    {
        List<Patient> output = new List<Patient>();
        if (parameters.Length == 1)
        {
            Department forOutput = departments.Find(x => x.Name.Equals(parameters[0]));
            output.AddRange(patients.FindAll(x => x.department.Equals(forOutput)));
        }
        else if (parameters[1].All(char.IsDigit))
        {
            Department forOutput = departments.Find(x => x.Name.Equals(parameters[0]));
            output.AddRange(forOutput.fromRoom(Convert.ToInt32(parameters[1])));
            output.OrderBy(x => x.name);
        }
        else
        {
            Doctor forOutput = new Doctor(parameters[0], parameters[1]);
            output.AddRange(patients.FindAll(x => x.doctor.Equals(forOutput)));
            output.OrderBy(x => x.name);
        }
        return output;
    }
}