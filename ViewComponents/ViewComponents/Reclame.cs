using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace ViewComponents.wwwroot.ViewComponents
{
    public class Reclame : ViewComponent 
    {
        static string[] powerbars = { "mars", "bounty", "snickers", "twix" };

        public IViewComponentResult Invoke()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 4);
            return View((object)powerbars[randomNumber]);
            //return new ContentViewComponentResult("Deze tekst zal <letterlijk> worden weergegeven.");
            //return new HtmlContentViewComponentResult(new HtmlString("Deze tekst zal <letterlijk> worden weergegeven."));
        }
    }
}
