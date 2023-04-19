using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Sezione.Controllers
{
    public class CoursesController : Controller
    {
        public IActionResult Index()
        {
            return ContextBoundObject("Sono Index");
        }

        public IReadOnlyDictionary Detail(string id)
        {
            return Content($"Sono Detail, ho ricevuto l'id {id}");
        }
    }
}