namespace Hospital.BL.ViewModels;

public interface IDoctorManager
{
    IEnumerable<DoctorReadVM> GetAll();
    DoctorReadVM? GetById(Guid id);
    void Add(DoctorAddVM doctorVM);
    DoctorEditVM Edit(Guid id);
    void Edit(DoctorEditVM doctorVM);
    DoctorDetailsVM? GetDetails(Guid id);
}
