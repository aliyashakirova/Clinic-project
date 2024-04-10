using Clinic_project;
using static Clinic_project.Doctors;


void TreatPatient(ITreat doc)
{
    doc.Treat();
}

var dentist = new Dentist();
var surgeon = new Surgeon();
var operation = Enum.Parse(typeof(Operation),Console.ReadLine());
var patient = new Patient()
{
    Name = "Ivan",
    LastName = "Ivanov",
    TreatmentPlan = new TreatmentPlan()
    {
        TreatmentPlanName = "some treatment plan name"
    }
};
switch (operation)
{
    case Operation.Dentist:
        {
            Console.WriteLine($"{patient.Name} {patient.LastName} {patient.TreatmentPlan.TreatmentPlanName}");
            TreatPatient(dentist);
            break;
        }
    case Operation.Surgeon:
        {
            Console.WriteLine($"{patient.Name} {patient.LastName} {patient.TreatmentPlan.TreatmentPlanName}");
            TreatPatient(surgeon);
            break;
        }
}


    public enum Operation
    {
        Surgeon = 0,
        Dentist = 1,
    }


