namespace Hospital.DAL;

public class Issue
{
    public Guid Id { get; set; }
    public string Name { get; set; }

    public ICollection<Patient> Patients { get; set; } = new List<Patient>();
}
