using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspWedsite.DB;
using Microsoft.AspNetCore.Mvc;
//using Mydemo.Models;

namespace Mydemo.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDBContext _db; 
        
        public CategoryController(ApplicationDBContext db)
        {
            this._db = db;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}