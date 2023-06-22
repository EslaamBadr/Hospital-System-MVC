namespace Hospital.DAL;

public class IssueRepo : GenericRepo<Issue>, IIssueRepo
{
    private readonly HospitalContext _context;

    public IssueRepo(HospitalContext context) : base(context)
    {
        _context = context;
    }

    public Issue? GetByName(string name)
    {
        return _context.Set<Issue>()
            .FirstOrDefault(i => i.Name == name);
    }
}
