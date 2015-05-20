using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace CustomerSurvey.Domain
{
    public class SiteDBContext : DbContext
    {
        public SiteDBContext() :
            base(System.Configuration.ConfigurationManager.ConnectionStrings["SiteDB"].ConnectionString)
        {
            var objectContext = (this as IObjectContextAdapter).ObjectContext;
            objectContext.CommandTimeout = 180;
        }
    }
}
