using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
 // For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WishList.Model
{
    public class Item : Controller
    {
        public int ID
        {
            get;set;
        }
        [Required][MaxLength(50)]
        public string Description
        {
            get;set;
        }

        public DbSet<Item> Items
        {
            get;set;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
    }
}
