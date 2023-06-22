using System.ComponentModel.DataAnnotations;

namespace Hospital.BL;

public class DoctorAddVM
{
    [Required]
    [MinLength(3)]
    public string Name { get; set; } = string.Empty;

    [MaxLength(100)]
    [MinLength(3)]
    public string Specialization { get; set; } = string.Empty;
    
    [Range(100,1000)]
    public decimal Salary { get; set; }
    
    [Range(1,20)]
    public int PerformanceRate { get; set; }
}
