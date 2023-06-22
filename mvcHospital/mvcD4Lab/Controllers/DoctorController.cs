using Hospital.BL;
using Hospital.BL.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Hospital.MVC.Controllers;

public class DoctorController : Controller
{
    private readonly IDoctorManager _doctorManager;

    private readonly IConfiguration _config;

    public DoctorController(IDoctorManager doctorManager, IConfiguration config)
    {
        _doctorManager = doctorManager;
        this._config = config;
    }

    #region Get All

    [HttpGet]
    public IActionResult Index()
    {
        IEnumerable<DoctorReadVM> doctors = _doctorManager.GetAll();
        return View(doctors);
    }

    #endregion

    #region Add

    [HttpGet]
    public IActionResult Add()
    {
        ViewBag.ChangingValue = _config.GetValue<int>("ChangingValue");
        return View();
    }
    [HttpPost]
    public IActionResult Add(DoctorAddVM doctorAddVM)
    {
        if (!ModelState.IsValid)
        {
            return View();
        }
        _doctorManager.Add(doctorAddVM);
        return RedirectToAction(nameof(Index));
    }

    #endregion

    #region Edit

    [HttpGet]
    public IActionResult Edit(Guid id)
    {
        DoctorEditVM? doctor = _doctorManager.Edit(id);
        return View(doctor);
    }
    [HttpPost]
    public IActionResult Edit(DoctorEditVM doctorEditVM)
    {
        if (!ModelState.IsValid)
        {
            return View();
        }
        _doctorManager.Edit(doctorEditVM);
        return RedirectToAction(nameof(Index));
    }

    #endregion

    #region Details

    [HttpGet]
    public IActionResult Details(Guid id)
    {
        DoctorDetailsVM? doctorVM = _doctorManager.GetDetails(id);
        return View(doctorVM);
    }

    #endregion


}
