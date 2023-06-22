namespace Hospital.DAL;

public interface IDoctorsRepo : IGenericRepo<Doctor>
{
    IEnumerable<Doctor> GetByPerformance(int rate);
    Doctor? GetDocterByIdWithPatients(Guid id);
}
