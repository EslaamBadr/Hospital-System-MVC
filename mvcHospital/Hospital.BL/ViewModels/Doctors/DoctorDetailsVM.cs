namespace Hospital.BL.ViewModels;

public class DoctorDetailsVM
{
    public string Name { get; set; }=string.Empty;
    public string Specialization { get; set; } = string.Empty;
    public int PerformanceRate { get; set; }
    public IEnumerable<PatientChildVM> Patients { get; set; }
}

public class PatientChildVM
{
    public string Name { get; set; } = string.Empty;
    public int NumOfIssues { get; set; }
}