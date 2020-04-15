using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Diagnostics;
using WishList.Data;
using WishList.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WishList.Controllers
{
    public class ItemController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ItemController(ApplicationDbContext context)
        {
            _context = context;
        } 
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View("Index");
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View("Create");
        }
         
        [HttpPost]
        public IActionResult Create(Item item)
        {
            _context.Items.Add(item);
            _context.SaveChanges();
            return RedirectToAction("Index","Item");
        }
        public IActionResult Delete(int id)
        {
               _context.Items.FirstOrDefault();
            _context.Items.Remove(_context.Items.Find(id));
            _context.SaveChanges();
            return RedirectToAction();
 
         }
    }
}
