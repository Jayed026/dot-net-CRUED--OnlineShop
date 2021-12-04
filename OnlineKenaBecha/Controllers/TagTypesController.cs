using Microsoft.AspNetCore.Mvc;
using OnlineKenaBecha.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineKenaBecha.Models;

namespace OnlineKenaBecha.Controllers
{
    public class TagTypesController : Controller
    { 
    private ApplicationDbContext _db;
    public TagTypesController(ApplicationDbContext db)
    {
        _db = db;
    }
        public IActionResult Index()
        {
            return View(_db.TagNames.ToList());
        }
        #region Create
        //create get
        public ActionResult Create()
        {
            return View();
        }
        //create Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(TagNames tagTypes)
        {
            if (ModelState.IsValid)
            {
                _db.TagNames.Add(tagTypes);
                await _db.SaveChangesAsync();
                return RedirectToAction(actionName: nameof(Index));
            }
            return View(tagTypes);
        }
        #endregion
    }

}
