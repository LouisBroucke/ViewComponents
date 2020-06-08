using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

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
        }
    }
}
