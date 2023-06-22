namespace Hospital.DAL;

public interface IIssueRepo : IGenericRepo<Issue>
{
    Issue? GetByName (string name);
}
