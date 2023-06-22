using Microsoft.EntityFrameworkCore;

namespace Hospital.DAL;

public class DoctorsRepo : GenericRepo<Doctor>, IDoctorsRepo
{
    private readonly HospitalContext _context;

    public DoctorsRepo(HospitalContext context) : base(context)
    {
        _context = context;
    }

    public IEnumerable<Doctor> GetByPerformance(int rate)
    {
        return _context.Set<Doctor>().Where(d => d.PerformanceRate >= rate);
    }

    public Doctor? GetDocterByIdWithPatients(Guid id)
    {
        return _context.Set<Doctor>()
            .Include(d => d.Patients)
                .ThenInclude(p => p.Issues)
            .FirstOrDefault(d => d.Id == id);
    }
}
