using Hospital.DAL;
using Hospital.DAL;
using System.Numerics;

namespace Hospital.BL.ViewModels;

public class DoctorManager : IDoctorManager
{
    private readonly IUnitOfWork _unitOfWork;

    public DoctorManager(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public IEnumerable<DoctorReadVM> GetAll()
    {
        IEnumerable<Doctor> doctorFromDb = _unitOfWork.DoctorsRepo.GetAll();
        IEnumerable<DoctorReadVM> doctorVM = doctorFromDb
            .Select(d => new DoctorReadVM
            {
                Id = d.Id,
                Name = d.Name,
                Specialization = d.Specialization,
                PerformanceRate = d.PerformanceRate,
            });
        return doctorVM;
    }

    public DoctorReadVM? GetById(Guid id)
    {
        Doctor? doctorFromDb = _unitOfWork.DoctorsRepo.GetById(id);
        if (doctorFromDb == null)
        {
            return null;
        }
        return new DoctorReadVM
        {
            Id = doctorFromDb.Id,
            Name = doctorFromDb.Name,
            PerformanceRate = doctorFromDb.PerformanceRate,
            Specialization = doctorFromDb.Specialization
        };
    }

    public void Add(DoctorAddVM doctorVM)
    {
        var doctor = new Doctor
        {
            Name = doctorVM.Name,
            Specialization = doctorVM.Specialization,
            Salary = doctorVM.Salary,
            PerformanceRate = doctorVM.PerformanceRate,
            Id = Guid.NewGuid()
        };
        _unitOfWork.DoctorsRepo.Add(doctor);
        _unitOfWork.SaveChanges();
    }

    public DoctorEditVM Edit(Guid id)
    {
        Doctor? doctorFromDb = _unitOfWork.DoctorsRepo.GetById(id);
        return new DoctorEditVM
        {
            Id = id,
            Name = doctorFromDb.Name,
            Specialization = doctorFromDb.Specialization,
            Salary = doctorFromDb.Salary,
            PerformanceRate = doctorFromDb.PerformanceRate
        };
    }

    public void Edit(DoctorEditVM doctorVM)
    {
        Doctor? doctorFromDb = _unitOfWork.DoctorsRepo.GetById(doctorVM.Id);

        doctorFromDb.Name = doctorVM.Name;
        doctorFromDb.Specialization = doctorVM.Specialization;
        doctorFromDb.PerformanceRate = doctorVM.PerformanceRate;

        _unitOfWork.DoctorsRepo.Update(doctorFromDb);
        _unitOfWork.SaveChanges();
    }

    public DoctorDetailsVM? GetDetails(Guid id)
    {
        Doctor? doctorFromDb = _unitOfWork.DoctorsRepo.GetDocterByIdWithPatients(id);
        if (doctorFromDb is null)
        {
            return null;
        }
        return new DoctorDetailsVM
        {
            Name = doctorFromDb.Name,
            Specialization = doctorFromDb.Specialization,
            PerformanceRate = doctorFromDb.PerformanceRate,
            Patients = doctorFromDb.Patients
                .Select(p => new PatientChildVM
                {
                    Name = p.Name,
                    NumOfIssues = p.Issues.Count
                }).ToList()
        };
    }
}
