using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Controllers
{
    public class GuideController1 : Controller
    {
        GuideManager guideManager = new GuideManager(new EfGuideDal());
        [AllowAnonymous]
        public IActionResult Index()
        {
            var values = guideManager.TGetList();
            return View(values);
        }
    }
}
