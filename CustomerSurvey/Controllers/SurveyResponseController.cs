using System.Web.Mvc;
using CustomerSurvey.Domain.Repositories;
using CustomerSurvey.Dto;
using CustomerSurvey.Helpers;

namespace CustomerSurvey.Controllers
{
    public class SurveyResponseController : Controller
    {
        private readonly SiteRepository siteRepository;

        public SurveyResponseController()
        {
            siteRepository = new SiteRepository();
        }

        [HttpGet]
        public ActionResult Create(int? id)
        {
            if (id.HasValue && id.Value > 0)
            {
                CookieHelper.SetCookie("EmployeeID", id.ToString());
                return View(new SurveyResponse());
            }
            else
            {
                return View("Error");   
            }
        }

        [HttpPost]
        public ActionResult Create(SurveyResponse surveyResponse)
        {
            surveyResponse.Rating = "Good";
            siteRepository.AddSurveyResponse(surveyResponse);
            return RedirectToAction("Complete");
        }

        [HttpGet]
        public ActionResult Complete()
        {
            return View("Complete");
        }

        //public ActionResult Import()
        //{
        //    return View(new FileExporter());
        //}

        //[HttpPost]
        //[ValidateInput(false)]
        //public ActionResult Import(FileExporter fileImporter, FileRowModel[] file)
        //{
        //    if (!ModelState.IsValid || file == null)
        //    {
        //        ModelState.AddModelError("Errors", "Please choose a valid CSV file");
        //    }
        //    else
        //    {
        //        if (file.Any())
        //        {
        //            try
        //            {
        //                var sites = new List<Site>();
                        
        //                //Map CSV file to Dto objects
        //                for (int i = 0; i < file.Count(); i++)
        //                {
        //                    sites.Add(MapFileModelToDto(file[i]));
        //                }

        //                //Add to database
        //                foreach (SurveyResponse site in sites)
        //                {
        //                    siteRepository.AddSite(site);
        //                }
        //                return RedirectToAction("Index");
        //            }
        //            catch (Exception ex)
        //            {
        //                ModelState.AddModelError("Errors", "Incorrect data in the CSV file. Please check the columns and validity of the data");
        //            }
        //        }
        //    }

        //    return View(fileImporter);
        //}


        #region Private Methods

        //private void PopulateViewBags()
        //{
        //    ViewBag.Categories = GetCategories();
        //    ViewBag.PageRanks = GetPageRanks();
        //    ViewBag.PostingSpeeds = GetPostingSpeeds();
        //}

        //private IEnumerable<SelectListItem> GetCategories()
        //{
        //    List<Employee> categories = siteRepository.GetAllCategories().ToList();

        //    return categories.Select(x => new SelectListItem
        //    {
        //        Value = x.ID.ToString(),
        //        Text = x.Name
        //    });
        //}

        //private IEnumerable<SelectListItem> GetPageRanks()
        //{
        //    var pageRanks = new List<int>();
        //    for (int i = 0; i <= 10; i++)
        //    {
        //        pageRanks.Add(i);
        //    }

        //    return pageRanks.Select(x => new SelectListItem
        //    {
        //        Value = x.ToString(),
        //        Text = x.ToString()
        //    });
        //}

        //private IEnumerable<SelectListItem> GetPostingSpeeds()
        //{
        //    var postingSpeeds = new List<string>();
        //    postingSpeeds.Add(PostingSpeed.Instant.ToString());
        //    postingSpeeds.Add(PostingSpeed.Fast.ToString());
        //    postingSpeeds.Add(PostingSpeed.Normal.ToString());
        //    postingSpeeds.Add(PostingSpeed.Slow.ToString());

        //    return postingSpeeds.Select(x => new SelectListItem
        //    {
        //        Value = x.ToString(),
        //        Text = x.ToString()
        //    });

        //}

        //private Site MapFileModelToDto(FileRowModel fileRowModel)
        //{
        //    var site = new Site
        //    {
        //        DomainName = fileRowModel.Domain,
        //        Category = fileRowModel.Category,
        //        CategoryID = Convert.ToInt32(GetCategories().Where(c => c.Text == fileRowModel.Category).FirstOrDefault().Value),
        //        PageRank = fileRowModel.PageRank,
        //        DomainAuthority = fileRowModel.DomainAuthority,
        //        PostingSpeed = fileRowModel.PostingSpeed,
        //        Cost = fileRowModel.Cost,
        //        Details = fileRowModel.Details,
        //        Notes = fileRowModel.Notes
        //    };

        //    return site;
        //}

        #endregion
    }
}
    