using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NguyenPhuLoc.Models;

namespace NguyenPhuLoc.Controllers
{
    public class AdminController : Controller
    {
          private AppDbContext _db;
        public AdminController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Cbnv()
        {
            return View();
        }
        
         public IActionResult Danhmucnghiepvu()
        {
            return View();
        } 
        public IActionResult Danhmucquanly()
        {
            return View();
        }
          public IActionResult Chaomung()
        {
            return View();
        }

        
        
    }
}
