using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace EasyCashIdentityProject.PresentationLayer.ViewComponents.Customer
{
    public class _CustomerLayoutNavbarPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
