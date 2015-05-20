using System;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FileHelpers;

namespace CustomerSurvey.Dto
{
    [DelimitedRecord(",")]
    [IgnoreFirst(1)]
    public class FileRowModel
    {
        public string Domain { get; set; }

        public string Category { get; set; }

        public Int16 PageRank { get; set; }

        public int DomainAuthority { get; set; }

        public string PostingSpeed { get; set; }

        public int Cost { get; set; }

        public string Details { get; set; }

        public string Notes { get; set; }
    }
    
    public class CsvModelBinder<T> : DefaultModelBinder where T : class
    {
        public override object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            var csv = bindingContext.ValueProvider.GetValue(bindingContext.ModelName);
            var file = ((csv.RawValue as HttpPostedFileBase[]) ?? Enumerable.Empty<HttpPostedFileBase>()).FirstOrDefault();

            if (file == null || file.ContentLength < 1)
            {
                bindingContext.ModelState.AddModelError(
                    "",
                    "Please select a valid CSV file"
                );
                return null;
            }

            using (var reader = new StreamReader(file.InputStream))
            {
                try
                {
                    var engine = new FileHelperEngine<T>();
                    return engine.ReadStream(reader);
                }
                catch (Exception c)
                {
                    bindingContext.ModelState.AddModelError(bindingContext.ModelName, c.Message);
                    return null;
                }

            }
        }
    }
}