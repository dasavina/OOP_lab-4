﻿class Doctor
{
    string name { get; set; } = "none";
    string surname { get; set; } = "none";
    List<Patient> patients { get; set; };

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