using MailKit;
using Microsoft.AspNetCore.Mvc;
using MyProject.Models;
using Umbraco.Cms.Core.Cache;
using Umbraco.Cms.Core.Logging;
using Umbraco.Cms.Core.Routing;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Infrastructure.Persistence;
using Umbraco.Cms.Web.Website.Controllers;
using Umbraco.Cms.Web.Website.ActionResults;

    

namespace MyProject.Controllers
{
    public class ContactsController : SurfaceController
    {
        public ContactsController(IUmbracoContextAccessor umbracoContextAccessor, IUmbracoDatabaseFactory databaseFactory, ServiceContext services, AppCaches appCaches, IProfilingLogger profilingLogger, IPublishedUrlProvider publishedUrlProvider) : base(umbracoContextAccessor, databaseFactory, services, appCaches, profilingLogger, publishedUrlProvider)
        {
        }
        [HttpPost]
        public IActionResult Index(ContactForm contactForm)
        {

            if (!ModelState.IsValid)
                return CurrentUmbracoPage();
       
            return LocalRedirect(contactForm.RedirectUrl ?? "/");

            
        }
    }
}
