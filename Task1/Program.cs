Hospital hospital = new Hospital();
while(true)
{
    string command = Console.ReadLine();
    switch (command)
    {
        case ("End"): Environment.Exit(0); break;
        case "Output":
            {
               string output = Console.ReadLine();

            } 
            break;
        default:
            {
                string[] patientInfo = command.Split(" ");
                //dep name surname patientName
                Department department = new Department(patientInfo[0]);
                Doctor doctor = new Doctor(patientInfo[2], patientInfo[1]);

                Patient patient = new Patient();


               if (!hospital.departments.Any(x => x.Name.Equals(patientInfo[0])))
                {
                    Department newDepartment = new Department(patientInfo[0]);
                    hospital.departments.Add(newDepartment);
                }
                if (hospital.departments.Find(x => x.Equals(department)).canFit())
                {
                    hospital.departments.Find(x => x.Equals(department)).firstToFitIn().Add()
                }


            } break;
    }
}