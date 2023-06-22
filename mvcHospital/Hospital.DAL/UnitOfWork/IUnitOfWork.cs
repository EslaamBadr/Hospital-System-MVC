namespace Hospital.DAL;

public interface IUnitOfWork
{
    public IPatientRepo PatientsRepo { get; }
    public IIssueRepo IssuesRepo { get; }
    public IDoctorsRepo DoctorsRepo { get; }
    int SaveChanges();
}
