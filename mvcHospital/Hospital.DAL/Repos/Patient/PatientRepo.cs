namespace Hospital.DAL;

public class PatientRepo : GenericRepo<Patient>, IPatientRepo
{
    private readonly HospitalContext _context;
    public PatientRepo(HospitalContext context) : base(context)
    {
        _context = context;
    }

    public IEnumerable<Patient> GetPatientForDoctor(Guid doctorId)
    {
        return _context.Set<Patient>()
            .Where(p => p.DoctorId == doctorId);
    }
}
