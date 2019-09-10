using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pagination.Models;
using Pagination.Paginate;

namespace Pagination.Controllers
{
    public class HomeController : Controller
    {
        private readonly ContactContext _context;
       
        public HomeController(ContactContext context)
        {
            _context = context;
           
        }
        public async Task<IActionResult> Index(int? pageNumber)
        {
            var contacts = from c in _context.Contacts
                           select c;

            int pageSize = 5;

            return View(await PagerList<Contact>.CreateAsync(contacts.AsNoTracking(), pageNumber ?? 1, pageSize));
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
