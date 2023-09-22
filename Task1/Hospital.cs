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
        if (doctors.Any(y => y.patients.Any(x => x.name.Equals(patientInfo[3]))) || departments.Any(y => y.rooms.Any(x => x.patients.Any(z => z.name.Equals(patientInfo[3])))))
        {
            Console.WriteLine("patient is already included");

        }
        else
        {

            int departmentIndex, doctorIndex;

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

    public List<Patient> output(string[] parameters)
    {
        List<Patient> output = new List<Patient>();
        if (parameters.Length == 1)
        {
            Department forOutput = departments.Find(x => x.Name.Equals(parameters[0]));
            for (int i = 0; i < forOutput.rooms.Count(); i++)
            {
                output.AddRange(forOutput.fromRoom(i));

            }
        }
        else if (parameters[1].All(char.IsDigit))
        {
            Department forOutput = departments.Find(x => x.Name.Equals(parameters[0]));
            output.AddRange(forOutput.fromRoom(Convert.ToInt32(parameters[1])));
            output.OrderBy(x => x.name);
        }
        else
        {
            Doctor forOutput = doctors.Find(x => x.name.Equals(parameters[0]) && x.surname.Equals(parameters[1]));
            output.AddRange(forOutput.patients);
            output.OrderBy(x => x.name);
        }
        return output;
    }
}