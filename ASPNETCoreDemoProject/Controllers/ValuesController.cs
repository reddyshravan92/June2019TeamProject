using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ASPNETCoreDemoProject.Controllers
{
    public class ValuesController : Controller
    {
        public string Index()
        {
            return "Test Action";
        }
    }
}