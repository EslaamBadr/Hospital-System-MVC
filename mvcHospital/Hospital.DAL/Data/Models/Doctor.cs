namespace Hospital.DAL;

public class Doctor
{
    public Guid Id { get; set; }
    public string Name { get; set; } =string.Empty;
    public string Specialization { get; set; }=string.Empty;
    public decimal Salary { get; set; }
    public int PerformanceRate { get; set; }

    public ICollection<Patient> Patients { get; set; }=new List<Patient>();

    public static List<Doctor> _Doctors => new()    
    {
        new Doctor(){ Id = Guid.NewGuid(), Name = "Eslam",Specialization="aaa", PerformanceRate=1, Salary=1000  },
        new Doctor(){ Id = Guid.NewGuid(), Name = "Ahmed",Specialization="aaa", PerformanceRate=2, Salary=2000  },
        new Doctor(){ Id = Guid.NewGuid(), Name = "Ali",Specialization="aaa", PerformanceRate=3, Salary=3000  },
        new Doctor(){ Id = Guid.NewGuid(), Name = "Mostafa",Specialization="aaa", PerformanceRate=4, Salary=4000  },
        new Doctor(){ Id = Guid.NewGuid(), Name = "Mohamed",Specialization="aaa", PerformanceRate=5, Salary=5000  },
        new Doctor(){ Id = Guid.NewGuid(), Name = "Sally",Specialization="aaa", PerformanceRate=6, Salary=6000  }
    };
}
