namespace Hospital.DAL;

public class Patient
{
    public Guid Id { get; set; }
    public string Name { get; set; }=string.Empty;

    public Guid DoctorId { get; set; }
    public Doctor Doctor { get; set; } = null!;

    public ICollection<Issue> Issues { get; set; } = new List<Issue>();

    public static List<Patient> _Patients => new()
    {
        new Patient(){ Id = Guid.NewGuid(), Name = "Ahmed", DoctorId= Guid.Parse("f2281eaf-e5fe-470c-a0e1-3da8d1050081")},
        new Patient(){ Id = Guid.NewGuid(), Name = "Ali", DoctorId= Guid.Parse("f2281eaf-e5fe-470c-a0e1-3da8d1050081")},
        new Patient(){ Id = Guid.NewGuid(), Name = "Kamal", DoctorId= Guid.Parse("f2281eaf-e5fe-470c-a0e1-3da8d1050081") },
        new Patient(){ Id = Guid.NewGuid(), Name = "Alaa", DoctorId= Guid.Parse("f2281eaf-e5fe-470c-a0e1-3da8d1050081") },
        new Patient(){ Id = Guid.NewGuid(), Name = "Sara", DoctorId= Guid.Parse("f2281eaf-e5fe-470c-a0e1-3da8d1050081") },
        new Patient(){ Id = Guid.NewGuid(), Name = "Karma", DoctorId=  Guid.Parse("f2281eaf-e5fe-470c-a0e1-3da8d1050081") }
    };
}
