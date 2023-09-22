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
                hospital.addPatient(patientInfo);

            } break;
    }
}