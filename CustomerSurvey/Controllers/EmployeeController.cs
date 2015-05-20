using System.Linq;
using System.Web.Mvc;
using CustomerSurvey.Domain.Repositories;
using CustomerSurvey.Dto;

namespace CustomerSurvey.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly SiteRepository siteRepository;

        public EmployeeController()
        {
            siteRepository = new SiteRepository();
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View(siteRepository.GetAllEmployees().ToList());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View(new Employee());
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Create(Employee employee)
        {
            siteRepository.AddEmployee(employee);
            return RedirectToAction("Index");
        }
    }
}
    