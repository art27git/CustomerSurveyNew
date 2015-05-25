using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Cache;
using System.Web;
using CustomerSurvey.Dto;

namespace CustomerSurvey.Domain.Repositories
{
    public class SiteRepository
    {
        private readonly SiteDBContext db = new SiteDBContext();

        public IEnumerable<SurveyResponse> GetAllSurveyResponses()
        {
            var result = db.Database.SqlQuery<SurveyResponse>("exec up_getSurveyResponses").ToList();
            return result;
        }

        public void AddSurveyResponse(SurveyResponse surveyResponse)
        {
            var cookies = HttpContext.Current.Request.Cookies;
            if (cookies.Count > 0 && cookies.Get("EmployeeID") != null)
            {
                int employeeID = Convert.ToInt32(cookies.Get("EmployeeID").Value);
                db.Database.ExecuteSqlCommand("exec up_addSurveyResponse " +
                                                          "@EmployeeID = {0}," +
                                                          "@Rating = {1}," +
                                                          "@HospitalName = {2}," +
                                                          "@Comments = {3}",
                                                          employeeID, surveyResponse.Rating, surveyResponse.HospitalName, surveyResponse.Comments);
            }

        }


        public IEnumerable<Employee> GetAllEmployees()
        {
            var result = db.Database.SqlQuery<Employee>("exec up_getEmployees").ToList();
            return result;
        }

        public void AddEmployee(Employee employee)
        {
            db.Database.ExecuteSqlCommand("exec up_addEmployee " +
                                                      "@FirstName = {0}," +
                                                      "@LastName = {1}",
                                                      employee.FirstName, employee.LastName);
        }
    }
}
