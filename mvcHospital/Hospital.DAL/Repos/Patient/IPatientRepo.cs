namespace Hospital.DAL;

public interface IPatientRepo : IGenericRepo<Patient>
{
    IEnumerable<Patient> GetPatientForDoctor(Guid doctorId);
}
