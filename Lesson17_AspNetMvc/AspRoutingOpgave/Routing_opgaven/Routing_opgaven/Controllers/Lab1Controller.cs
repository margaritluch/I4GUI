using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Routing_opgaven.Controllers
{
    public class Lab1Controller : Controller
    {
        public IActionResult ShowResult (int x = 2, int y = 4)
        {
            return Content(string.Format($"x={x}, og y={y}"));
        }
    }
}