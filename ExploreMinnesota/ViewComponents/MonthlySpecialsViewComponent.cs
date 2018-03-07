using ExploreMinnesota.Models;
using Microsoft.AspNetCore.Mvc;
using System;
namespace ExploreMinnesota.ViewComponents
{
    [ViewComponent]
    public class MonthlySpecialsViewComponent : ViewComponent
    {
        private readonly SpecialsDataContext _specials;

        public MonthlySpecialsViewComponent(SpecialsDataContext specials) => _specials = _specials;

        public IViewComponentResult Invoke()
        {
            var specials = _specials.GetMonthlySpecials();
            return View(specials);
        }
    }
}
