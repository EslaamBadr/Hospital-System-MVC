namespace Hospital.DAL;

public class UnitOfWork : IUnitOfWork
{
    public IPatientRepo PatientsRepo { get; }

    public IIssueRepo IssuesRepo { get; }

    public IDoctorsRepo DoctorsRepo { get; }

    private readonly HospitalContext _context;

    public UnitOfWork(HospitalContext context,
        IDoctorsRepo doctorsRepo,
        IIssueRepo issuesRepo,
        IPatientRepo patientsRepo)
    {
        _context = context;
        DoctorsRepo = doctorsRepo;
        IssuesRepo = issuesRepo;
        PatientsRepo = patientsRepo;
    }
    public int SaveChanges()
    {
       return _context.SaveChanges();
    }
}
